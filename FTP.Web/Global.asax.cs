using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FPT.Data.Infrastructure;
using FPT.Data.Repositories;
using FPT.Service;
using FTP.Web.Security;
using Microsoft.Owin.Security.OAuth;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FTP.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
