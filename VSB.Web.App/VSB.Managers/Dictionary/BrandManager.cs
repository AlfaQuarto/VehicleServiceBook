using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels.Dictionary;
using VSB.Managers.Interfaces.Dictionary;

namespace VSB.Managers.Dictionary
{
    public class BrandManager : BaseManager, IDictionaryManager<BrandBusinessModel>
    {
        public IList<BrandBusinessModel> GetDictionaryItems()
        {
            var query = VehicleServiceBookDB.dictionary_brand.ToList();

            IList<BrandBusinessModel> result = new List<BrandBusinessModel>();
            result = AutoMapper.Mapper.Map<IList<Core.DataAccess.dictionary_brand>, IList<BrandBusinessModel>>(query);

            return result;
        }

        public BrandBusinessModel GetItem()
        {
            throw new NotImplementedException();
        }

        public BrandBusinessModel GetItemById(int id)
        {
            var query = VehicleServiceBookDB.dictionary_brand.FirstOrDefault(x => x.ID == id);
            BrandBusinessModel model = AutoMapper.Mapper.Map<BrandBusinessModel>(query);

            return model;
        }

        public void SaveItem(BrandBusinessModel item)
        {
            if (VehicleServiceBookDB.dictionary_brand.Any(x => x.ID == item.ID))
            {
                var query = VehicleServiceBookDB.dictionary_brand.First(x => x.ID == item.ID);

                query.Deleted = item.Deleted;
                query.Name = item.Name;                
            }
            else
            {
                var daoItem = AutoMapper.Mapper.Map<Core.DataAccess.dictionary_brand>(item);
                VehicleServiceBookDB.dictionary_brand.Add(daoItem);
            }

            VehicleServiceBookDB.SaveChanges();
        }
    }
}
