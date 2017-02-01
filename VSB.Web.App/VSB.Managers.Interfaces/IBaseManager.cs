using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Managers.Interfaces
{
    public interface IBaseManager<T>
    {
        T GetItem();

        T GetItemById(int id);

        void SaveItem(T item);

    }
}
