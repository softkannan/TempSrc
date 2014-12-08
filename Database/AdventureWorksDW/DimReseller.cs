//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksDW
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimReseller
    {
        public DimReseller()
        {
            this.FactResellerSales = new HashSet<FactResellerSale>();
        }
    
        public int ResellerKey { get; set; }
        public Nullable<int> GeographyKey { get; set; }
        public string ResellerAlternateKey { get; set; }
        public string Phone { get; set; }
        public string BusinessType { get; set; }
        public string ResellerName { get; set; }
        public Nullable<int> NumberEmployees { get; set; }
        public string OrderFrequency { get; set; }
        public Nullable<byte> OrderMonth { get; set; }
        public Nullable<int> FirstOrderYear { get; set; }
        public Nullable<int> LastOrderYear { get; set; }
        public string ProductLine { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Nullable<decimal> AnnualSales { get; set; }
        public string BankName { get; set; }
        public Nullable<byte> MinPaymentType { get; set; }
        public Nullable<decimal> MinPaymentAmount { get; set; }
        public Nullable<decimal> AnnualRevenue { get; set; }
        public Nullable<int> YearOpened { get; set; }
    
        public virtual DimGeography DimGeography { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSales { get; set; }
    }
}
