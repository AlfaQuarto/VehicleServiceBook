using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Managers.Interfaces.Dictionary;

namespace VSB.Managers.Dictionary
{
    public class ModelManager : BaseManager, IModelDictionaryManager<ModelBusinessModel>
    {
        public IList<ModelBusinessModel> GetDictionaryItems()
        {
            var query = base.VehicleServiceBookDB.dictionary_model.ToList();

            return AutoMapper.Mapper.Map<IList<VSB.Core.DataAccess.dictionary_model>, IList<ModelBusinessModel>>(query);
        }

        public ModelBusinessModel GetItem()
        {
            throw new NotImplementedException();
        }

        public ModelBusinessModel GetItemById(int id)
        {
            var query = base.VehicleServiceBookDB.dictionary_model.FirstOrDefault(x => x.ID == id);

            return AutoMapper.Mapper.Map<ModelBusinessModel>(query);
        }

        public void SaveItem(ModelBusinessModel item)
        {
            if (item.ID != 0)
            {
                var query = base.VehicleServiceBookDB.dictionary_model.FirstOrDefault(x => x.ID == item.ID);

                query.Name = item.Name;
                query.Delted = item.Deleted;
                query.BrandID = item.BrandId;
            }
            else
            {
                var daoModel = AutoMapper.Mapper.Map<VSB.Core.DataAccess.dictionary_model>(item);

                base.VehicleServiceBookDB.dictionary_model.Add(daoModel);
            }

            base.VehicleServiceBookDB.SaveChanges();
        }

        public IList<ModelBusinessModel> GetModelsByBrandId(int brandId)
        {
            var query = base.VehicleServiceBookDB.dictionary_model.Where(x => x.BrandID == brandId).ToList();

            return AutoMapper.Mapper.Map<IList<VSB.Core.DataAccess.dictionary_model>, IList<ModelBusinessModel>>(query);
        }
    }
}
