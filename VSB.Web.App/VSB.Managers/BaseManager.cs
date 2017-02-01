using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSB.Core.DataAccess;

namespace VSB.Managers
{
    public abstract class BaseManager
    {
        public BaseManager()
        {
            VehicleServiceBookDB = new vsbDb();
        }

        internal vsbDb VehicleServiceBookDB { get; set; }

    }
}
