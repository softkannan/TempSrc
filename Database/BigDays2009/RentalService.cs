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
    
    public partial class RentalService
    {
        public int RentalServiceID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int ResourceID { get; set; }
        public int CustomerID { get; set; }
        public int RentalServiceStateID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual RentalServiceState RentalServiceState { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
