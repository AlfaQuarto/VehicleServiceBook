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
    
    public partial class dictionary_model
    {
        public dictionary_model()
        {
            this.vsb_vehicle = new HashSet<vsb_vehicle>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public Nullable<bool> Delted { get; set; }
    
        public virtual dictionary_brand dictionary_brand { get; set; }
        public virtual ICollection<vsb_vehicle> vsb_vehicle { get; set; }
    }
}
