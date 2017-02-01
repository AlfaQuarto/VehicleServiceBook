using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Core.DataAccess;
using VSB.Core.ViewModels.Dictionary;

namespace VSB.Core.Common.Utils
{
    public class AutoMapperConfig
    {
        protected static MapperConfigurationExpression config;

        public AutoMapperConfig()
        {
            config = new MapperConfigurationExpression();
        }

        public void Init()
        {
            this.RegisterDaoMappings();
            this.RegisterViewModelMappings();
            Mapper.Initialize(config);
        }

        private void RegisterDaoMappings()
        {
            config.CreateMap<ActionTypeBusinessModel, dictionary_action_type>();
            config.CreateMap<BodyTypeBusinessModel, dictionary_body_type>();
            config.CreateMap<BrandBusinessModel, dictionary_brand>();
            //config.CreateMap<IList<BrandBusinessModel>, IList<dictionary_brand>>();
            config.CreateMap<DriveTypeBusinessModel, dictionary_drive_type>();
            config.CreateMap<EngineTypeBusinessModel, dictionary_enigine_type>();
            config.CreateMap<ModelBusinessModel, dictionary_model>();
            config.CreateMap<VehicleTypeBusinessModel, dictionary_vehicle_type>();

            config.CreateMap<dictionary_action_type, ActionTypeBusinessModel>();
            config.CreateMap<dictionary_body_type, BodyTypeBusinessModel>();
            config.CreateMap<dictionary_brand, BrandBusinessModel>();
            config.CreateMap<dictionary_drive_type, DriveTypeBusinessModel>();
            config.CreateMap<dictionary_enigine_type, EngineTypeBusinessModel>();
            config.CreateMap<dictionary_model, ModelBusinessModel>();
            config.CreateMap<dictionary_vehicle_type, VehicleTypeBusinessModel>();
        }

        private void RegisterViewModelMappings()
        {
            config.CreateMap<ActionTypeBusinessModel, ActionTypeViewModel>();
            config.CreateMap<IList<ActionTypeBusinessModel>, IList<ActionTypeViewModel>>();
            config.CreateMap<BrandBusinessModel, BrandViewModel>();
            config.CreateMap<ModelBusinessModel, ModelViewModel>();

            config.CreateMap<ActionTypeViewModel, ActionTypeBusinessModel>();
            config.CreateMap<IList<ActionTypeViewModel>, IList<ActionTypeBusinessModel>>();
            config.CreateMap<BrandViewModel, BrandBusinessModel>();
            config.CreateMap<ModelViewModel, ModelBusinessModel>();
        }
    }
}
