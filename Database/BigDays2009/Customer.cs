//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigDays2009
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.RentalServices = new HashSet<RentalService>();
        }
    
        public int CustomerID { get; set; }
        public Nullable<System.Guid> MembershipID { get; set; }
        public string CustomerName { get; set; }
    
        public virtual ICollection<RentalService> RentalServices { get; set; }
    }
}
