using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.BusinessModels;
using VSB.Managers.Interfaces;

namespace VSB.Managers
{
    public class CarManager : VSB.Managers.Interfaces.ICarManager
    {
        public CarBusinessModel GetItem()
        {
            return new CarBusinessModel();
        }

        public CarBusinessModel GetItemById(int id)
        {
            return new CarBusinessModel();
        }

        public void SaveItem(CarBusinessModel item)
        {
            throw new NotImplementedException();
        }
    }
}
