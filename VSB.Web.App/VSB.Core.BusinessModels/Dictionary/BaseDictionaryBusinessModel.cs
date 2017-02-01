using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Core.BusinessModels.Dictionary
{
    public class BaseDictionaryBusinessModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public bool Deleted { get; set; }
    }
}
