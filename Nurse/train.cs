//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nurse
{
    using System;
    using System.Collections.Generic;
    
    public partial class train
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public train()
        {
            this.nurse_list = new HashSet<nurse_list>();
        }
    
        public int id { get; set; }
        public string place { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> fk_educate { get; set; }
    
        public virtual educates educates { get; set; }
        public virtual educates educates1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nurse_list> nurse_list { get; set; }
    }
}