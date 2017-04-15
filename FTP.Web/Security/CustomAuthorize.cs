using FPT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace FTP.Web.Security
{
    public class CustomAuthorize: System.Web.Http.AuthorizeAttribute
    {
        //public IUserService UserService { get; set; }
        //public IPermissionService PermissionService { get; set; }

        public override void OnAuthorization(HttpActionContext filterContext)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var UserService = filterContext.Request.GetDependencyScope().GetService(typeof(IUserService)) as IUserService;
                var PermissionService = filterContext.Request.GetDependencyScope().GetService(typeof(IPermissionService)) as IPermissionService;

                var userlogged = UserService.GetSingle(i => i.Username == HttpContext.Current.User.Identity.Name);
                //List<string> permission = new List<string> { "Product-Index"};
                var permission = PermissionService.GetSingle(i => i.RoleID == userlogged.RoleID).ListPermission.Split(';');
                string currentControllerAction = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "-" + filterContext.ActionDescriptor.ActionName;
                if (!permission.Contains(currentControllerAction))
                {
                    filterContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                }
            }
            else
            {
                filterContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
        }
    }
}