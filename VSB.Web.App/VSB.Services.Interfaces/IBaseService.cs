using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Services.Interfaces
{
    public interface IBaseService<T>
    {
        T GetItem();
        T GetItemById(int id);
        void SaveItem(T item);

        IList<T> GetItems();
    }
}
