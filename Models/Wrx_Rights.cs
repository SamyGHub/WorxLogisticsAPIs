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
    
    public partial class Wrx_Rights
    {
        public Nullable<int> RoleID { get; set; }
        public string ScopeLevel { get; set; }
        public Nullable<bool> Access { get; set; }
        public Nullable<bool> AddRight { get; set; }
        public Nullable<bool> ReadRight { get; set; }
        public Nullable<bool> EditRight { get; set; }
        public Nullable<bool> DeleteRight { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<long> modifiedby { get; set; }
    
        public virtual Wrx_Roles Wrx_Roles { get; set; }
    }
}
