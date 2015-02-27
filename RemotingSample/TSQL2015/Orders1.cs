//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSQL2015
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders1
    {
        public Orders1()
        {
            this.OrderDetails1 = new HashSet<OrderDetails1>();
        }
    
        public int orderid { get; set; }
        public Nullable<int> custid { get; set; }
        public int empid { get; set; }
        public System.DateTime orderdate { get; set; }
        public System.DateTime requireddate { get; set; }
        public Nullable<System.DateTime> shippeddate { get; set; }
        public int shipperid { get; set; }
        public decimal freight { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string shipcity { get; set; }
        public string shipregion { get; set; }
        public string shippostalcode { get; set; }
        public string shipcountry { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetails1> OrderDetails1 { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
