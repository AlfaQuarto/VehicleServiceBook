using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.ViewModels;
using VSB.Managers.Interfaces;
using VSB.Services.Interfaces;

namespace VSB.Services
{
    public class CarService : ICarService
    {
        public ICarManager Manager { get; set; }

        public CarViewModel GetItem()
        {
            var model = this.Manager.GetItem();

            return new CarViewModel();
        }

        public CarViewModel GetItemById(int id)
        {
            return new CarViewModel();
        }

        public void SaveItem(CarViewModel item)
        {
            throw new NotImplementedException();
        }


        public IList<CarViewModel> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
