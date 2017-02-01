using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Managers.Dictionary;
using VSB.Managers.Interfaces;
using VSB.Managers.Interfaces.Dictionary;

namespace VSB.Managers.Ioc
{
    public class ManagersInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<ICarManager>().ImplementedBy<CarManager>().LifestylePerWebRequest());
            
            #region - Dictionary -
            
            container.Register(Component.For<IDictionaryManager<ActionTypeBusinessModel>>().ImplementedBy<ActionTypeManager>().LifestylePerWebRequest());
            container.Register(Component.For<IDictionaryManager<BrandBusinessModel>>().ImplementedBy<BrandManager>().LifestylePerWebRequest());
            container.Register(Component.For<IModelDictionaryManager<ModelBusinessModel>>().ImplementedBy<ModelManager>().LifestylePerWebRequest());

            #endregion
        }
    }
}
