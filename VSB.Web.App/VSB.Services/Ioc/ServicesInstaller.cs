using Castle.MicroKernel.Registration;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Services.Dictionary;
using VSB.Services.Interfaces;
using VSB.Services.Interfaces.Dictionary;

namespace VSB.Services.Ioc
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            // Register working dependencies
            container.Register(Component.For<ICarService>().ImplementedBy<CarService>().LifestylePerWebRequest());

            #region - Dictionary -

            container.Register(Component.For<IActionTypeService>().ImplementedBy<ActionTypeService>().LifestylePerWebRequest());
            container.Register(Component.For<IBrandService>().ImplementedBy<BrandService>().LifestylePerWebRequest());
            container.Register(Component.For<IModelService>().ImplementedBy<ModelService>().LifestylePerWebRequest());

            #endregion
        }
    }
}
