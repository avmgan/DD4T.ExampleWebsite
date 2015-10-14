using Autofac;
using Autofac.Integration.Mvc;
using DD4T.DI.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DD4TExampleWebsite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        ILifetimeScope BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.UseDD4T();
            return builder.Build();
        }
        protected void Application_Start()
        {
            var container = BuildContainer();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
