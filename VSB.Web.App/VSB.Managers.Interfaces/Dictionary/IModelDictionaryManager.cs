using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Managers.Interfaces.Dictionary
{
    public interface IModelDictionaryManager<T> : IDictionaryManager<T> 
    {
        IList<T> GetModelsByBrandId(int brandId);
    }
}
