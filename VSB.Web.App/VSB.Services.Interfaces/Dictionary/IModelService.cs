using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.ViewModels.Dictionary;

namespace VSB.Services.Interfaces.Dictionary
{
    public interface IModelService : IBaseService<ModelViewModel>
    {
        IList<ModelViewModel> GetModelsByBrandId(int brandId);
    }
}
