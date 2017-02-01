using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Managers.Interfaces.Dictionary
{
    public interface IDictionaryManager<T> : IBaseManager<T>
    {
        IList<T> GetDictionaryItems();
    }
}
