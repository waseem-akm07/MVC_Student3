//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc3_Student3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb2_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb2_student()
        {
            this.tb2_mapping = new HashSet<tb2_mapping>();
        }
    
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_add { get; set; }
        public string student_phn { get; set; }
        public Nullable<int> student_clsid { get; set; }
    
        public virtual tb2_class tb2_class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb2_mapping> tb2_mapping { get; set; }
    }
}
