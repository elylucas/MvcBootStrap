using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcBootStrap.Web.Infrastructure;
using Ninject;
using Ninject.Activation;
using Ninject.Extensions.Conventions;
using Ninject.Web.Common;

namespace MvcBootStrap.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            
            //Setup Ninject Kernel and wire up services using convention based binding in Ninject 3.0
            var kernel = new StandardKernel();
            kernel.Bind(x => x
                .FromAssembliesMatching("*")
                .SelectAllClasses()
                .BindDefaultInterface());
            //Or bind each class using the following syntax:
            //kernel.Bind<IStupidLittleService>().To<StupidLittleService>().InRequestScope();

            //Setup DR for MVC Controllers
            NinjectDependencyResolver resolver = new NinjectDependencyResolver(kernel);
            DependencyResolver.SetResolver(resolver);

            //Setup DR for Web API Controllers
            NinjectWebApiDependencyResolver webApiDependencyResolver = new NinjectWebApiDependencyResolver(kernel);
            GlobalConfiguration.Configuration.DependencyResolver = webApiDependencyResolver;
            
        }
    }
}   