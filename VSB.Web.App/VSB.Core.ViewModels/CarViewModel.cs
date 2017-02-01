using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSB.Core.ViewModels
{
    public class CarViewModel
    {
        public string Brand { get; set; }

        public string ModelName { get; set; }

        public DateTime ProductionYear { get; set; }

        public string RegistrationNumber { get; set; }

        public string IdentificationNumber { get; set; }

        public int EngineCcm { get; set; }

        
    }
}
