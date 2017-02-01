using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Core.BusinessModels.Dictionary
{
    public class ModelBusinessModel : BaseDictionaryBusinessModel
    {
        public int BrandId { get; set; }

        public BrandBusinessModel Brand { get; set; }
    }
}
