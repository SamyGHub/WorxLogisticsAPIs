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
    
    public partial class Wrx_ShipInstruct
    {
        public long id { get; set; }
        public Nullable<long> Transloader { get; set; }
        public string FCLNum { get; set; }
        public Nullable<long> SrvType { get; set; }
        public string UnitNum { get; set; }
        public string BagsNum { get; set; }
        public string MTNum { get; set; }
        public string CFIA { get; set; }
        public string SGS { get; set; }
        public string Tags { get; set; }
        public string LoadInstructions { get; set; }
        public string InstructBal { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public Nullable<long> modifiedby { get; set; }
    }
}
