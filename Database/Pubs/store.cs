//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pubs
{
    using System;
    using System.Collections.Generic;
    
    public partial class store
    {
        public store()
        {
            this.sales = new HashSet<sale>();
            this.discounts = new HashSet<discount>();
        }
    
        public string stor_id { get; set; }
        public string stor_name { get; set; }
        public string stor_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    
        public virtual ICollection<sale> sales { get; set; }
        public virtual ICollection<discount> discounts { get; set; }
    }
}
