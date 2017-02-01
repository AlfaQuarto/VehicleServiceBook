using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.Common.Enums;

namespace VSB.Core.ViewModels
{
    public class VehicleActionViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public ActionCategoryEnum Category { get; set; }
    }
}
