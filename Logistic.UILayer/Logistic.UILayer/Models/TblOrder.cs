//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistic.UILayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOrder
    {
        public int OrderID { get; set; }
        public Nullable<int> OrderCustomer { get; set; }
        public Nullable<int> FromCity { get; set; }
        public Nullable<int> ArrivalCity { get; set; }
        public string OrderProduct { get; set; }
        public string OrderSize { get; set; }
        public Nullable<decimal> OrderPrice { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        public virtual TblCity TblCity { get; set; }
        public virtual TblCity TblCity1 { get; set; }
        public virtual TblCustomer TblCustomer { get; set; }
    }
}
