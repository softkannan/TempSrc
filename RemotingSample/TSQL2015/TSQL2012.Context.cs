﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TSQL2012Entities : DbContext
    {
        public TSQL2012Entities()
            : base("name=TSQL2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Num> Nums { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetails1> OrderDetails1 { get; set; }
        public virtual DbSet<Orders1> Orders1 { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<EmpOrder> EmpOrders { get; set; }
        public virtual DbSet<OrderValue> OrderValues { get; set; }
    
        [DbFunction("TSQL2012Entities", "GetNums")]
        public virtual IQueryable<GetNums_Result> GetNums(Nullable<long> low, Nullable<long> high)
        {
            var lowParameter = low.HasValue ?
                new ObjectParameter("low", low) :
                new ObjectParameter("low", typeof(long));
    
            var highParameter = high.HasValue ?
                new ObjectParameter("high", high) :
                new ObjectParameter("high", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetNums_Result>("[TSQL2012Entities].[GetNums](@low, @high)", lowParameter, highParameter);
        }
    }
}
