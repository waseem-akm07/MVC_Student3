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
    
    public partial class tb2_mapping
    {
        public int map_id { get; set; }
        public Nullable<int> map_stdid { get; set; }
        public Nullable<int> map_subid { get; set; }
    
        public virtual tb2_student tb2_student { get; set; }
        public virtual tb2_subject tb2_subject { get; set; }
    }
}