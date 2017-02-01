using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Core.ViewModels.Dictionary;
using VSB.Managers.Interfaces.Dictionary;
using VSB.Services.Interfaces.Dictionary;

namespace VSB.Services.Dictionary
{
    public class ModelService : IModelService
    {
        public IModelDictionaryManager<ModelBusinessModel> Manager { get; set; }

        public IList<ModelViewModel> GetModelsByBrandId(int brandId)
        {
            IList<ModelBusinessModel> models = this.Manager.GetModelsByBrandId(brandId);
            return AutoMapper.Mapper.Map<IList<ModelBusinessModel>, IList<ModelViewModel>>(models);
        }

        public ModelViewModel GetItem()
        {
            var model = this.Manager.GetItem();
            return AutoMapper.Mapper.Map<ModelViewModel>(model);
        }

        public ModelViewModel GetItemById(int id)
        {
            var model = this.Manager.GetItemById(id);
            return AutoMapper.Mapper.Map<ModelViewModel>(model);
        }

        public void SaveItem(ModelViewModel item)
        {
            var model = AutoMapper.Mapper.Map<ModelBusinessModel>(item);
            this.Manager.SaveItem(model);
        }

        public IList<ModelViewModel> GetItems()
        {
            var models = this.Manager.GetDictionaryItems();
            return AutoMapper.Mapper.Map<IList<ModelBusinessModel>, IList<ModelViewModel>>(models);
        }
    }
}
