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
    
    public partial class dictionary_body_type
    {
        public dictionary_body_type()
        {
            this.vsb_car = new HashSet<vsb_car>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<vsb_car> vsb_car { get; set; }
    }
}
