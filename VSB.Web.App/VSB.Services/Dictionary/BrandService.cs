
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
    public class BrandService : IBrandService
    {
        public IDictionaryManager<BrandBusinessModel> Manager { get; set; }

        public Core.ViewModels.Dictionary.BrandViewModel GetItem()
        {
            var model = this.Manager.GetItem();
            return AutoMapper.Mapper.Map<BrandViewModel>(model);
        }

        public Core.ViewModels.Dictionary.BrandViewModel GetItemById(int id)
        {
            var model = this.Manager.GetItemById(id);
            return AutoMapper.Mapper.Map<BrandViewModel>(model);
        }

        public void SaveItem(Core.ViewModels.Dictionary.BrandViewModel item)
        {
            var model = AutoMapper.Mapper.Map<BrandBusinessModel>(item);
            this.Manager.SaveItem(model);
        }
        
        public IList<BrandViewModel> GetItems()
        {
            IList<BrandBusinessModel> models = this.Manager.GetDictionaryItems();

            return AutoMapper.Mapper.Map<IList<BrandBusinessModel>, IList<BrandViewModel>>(models);
        }
    }
}
