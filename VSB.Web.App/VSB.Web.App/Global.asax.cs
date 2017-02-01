using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VSB.Core.Common.Utils;
using VSB.Web.App.IoC;

namespace VSB.Web.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer iocContainer;

        private static void IocConfiguration()
        {
            iocContainer = new WindsorContainer();

            iocContainer.Install(new ApplicationInstaller());
            iocContainer.Install(FromAssembly.Named("VSB.Services"));
            //iocContainer.Install(FromAssembly.Named("VSB.Managers"));
            iocContainer.Install(FromAssembly.Named("VSB.Managers"));

            var controllerFactory = new CastleControllerFactory(iocContainer);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MvcApplication.IocConfiguration();
            AutoMapperConfig autoMapperCfg = new AutoMapperConfig();
            autoMapperCfg.Init();
        }

    }
}
