using Autofac;
using Autofac.Integration.Owin;
using FPT.Common;
using FPT.Service;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace FTP.Web.Security
{
    public class CustomOAuthAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        private IUserService _userService;
        private IRoleService _roleService;

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var autofacLifetimeScope = context.OwinContext.GetAutofacLifetimeScope();

            _userService = autofacLifetimeScope.Resolve<IUserService>();
            _roleService = autofacLifetimeScope.Resolve<IRoleService>();

            string password = StringHelper.md5(context.Password);
            var user = _userService.GetSingle(i => i.Username == context.UserName && i.Password == password);

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            if (user != null)
            {
                var userRole = _roleService.GetSingle(i => i.RoleID == user.RoleID);

                identity.AddClaim(new Claim(ClaimTypes.Role, userRole.RoleName));
                identity.AddClaim(new Claim("username", user.Username));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Username));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
        }
    }
}