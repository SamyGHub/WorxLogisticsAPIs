//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorxLogisticsAPIs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wrx_Customers
    {
        public long id { get; set; }
        public string CustName { get; set; }
        public string CustNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string TeleFax { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<long> modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
    }
}
