//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSB.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class dictionary_vehicle_type
    {
        public dictionary_vehicle_type()
        {
            this.vsb_vehicle = new HashSet<vsb_vehicle>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<vsb_vehicle> vsb_vehicle { get; set; }
    }
}
