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
    
    public partial class vsb_service
    {
        public vsb_service()
        {
            this.vsb_service_action = new HashSet<vsb_service_action>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public bool IsAuthorizedService { get; set; }
        public long ServiceType { get; set; }
        public string AdditionalInformation { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<vsb_service_action> vsb_service_action { get; set; }
    }
}
