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
    
    public partial class Wrx_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wrx_Roles()
        {
            this.Wrx_Rights = new HashSet<Wrx_Rights>();
        }
    
        public string RoleName { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<long> modifiedby { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wrx_Rights> Wrx_Rights { get; set; }
    }
}
