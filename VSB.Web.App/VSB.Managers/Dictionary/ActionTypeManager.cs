using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Core.DataAccess;
using VSB.Managers.Interfaces.Dictionary;

namespace VSB.Managers.Dictionary
{
    public class ActionTypeManager : BaseManager, IDictionaryManager<ActionTypeBusinessModel>
    {
        public ActionTypeBusinessModel GetItem()
        {
            throw new NotImplementedException();
        }

        public ActionTypeBusinessModel GetItemById(int id)
        {
            var query = VehicleServiceBookDB.dictionary_action_type.FirstOrDefault(x => x.ID == id);

            ActionTypeBusinessModel model = AutoMapper.Mapper.Map<ActionTypeBusinessModel>(query);
            return model;
        }

        public void SaveItem(ActionTypeBusinessModel item)
        {
            dictionary_action_type model = AutoMapper.Mapper.Map<dictionary_action_type>(item);

            if (model.ID > 0)
            {
                var query = VehicleServiceBookDB.dictionary_action_type.FirstOrDefault(x => x.ID == model.ID);

                if (query != null)
                {
                    query.Name = model.Name;
                    query.Description = model.Description;
                    query.Deleted = model.Deleted;
                }
            }
            else
            {
                VehicleServiceBookDB.dictionary_action_type.Add(model);
            }

           int id = VehicleServiceBookDB.SaveChanges();
        }

        public IList<ActionTypeBusinessModel> GetDictionaryItems()
        {
            var query = VehicleServiceBookDB.dictionary_action_type.ToList();

            IList<ActionTypeBusinessModel> result = new List<ActionTypeBusinessModel>();
            foreach (var item in query)
            {
                ActionTypeBusinessModel model = AutoMapper.Mapper.Map<ActionTypeBusinessModel>(item);

                result.Add(model);
            }

            return result;
        }
    }
}
