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
    
    public partial class nurse_list
    {
        public int id { get; set; }
        public int fk_nurse { get; set; }
        public int fk_train { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual train train { get; set; }
    }
}
