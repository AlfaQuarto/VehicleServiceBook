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
    public class ActionTypeService : IActionTypeService
    {
        public IDictionaryManager<ActionTypeBusinessModel> Manager { get; set; }

        public IList<ActionTypeViewModel> GetItems()
        {
            var items = Manager.GetDictionaryItems();

            IList<ActionTypeViewModel> models = new List<ActionTypeViewModel>();
            
            foreach(var item in items)
                models.Add(AutoMapper.Mapper.Map<ActionTypeViewModel>(item));

            return models;
        }
        
        public ActionTypeViewModel GetItemById(int id)
        {
            var model = Manager.GetItemById(id);

            return AutoMapper.Mapper.Map<ActionTypeViewModel>(model);
        }
        
        public void SaveItem(ActionTypeViewModel model)
        {
            ActionTypeBusinessModel bm = AutoMapper.Mapper.Map<ActionTypeBusinessModel>(model);

            Manager.SaveItem(bm);
        }

        public ActionTypeViewModel GetItem()
        {
            throw new NotImplementedException();
        }
    }
}
