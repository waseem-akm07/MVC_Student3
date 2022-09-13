using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Mvc3_Student3.Models
{
    public class ViewModel
    {
        [Key]
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_add { get; set; }
        public string student_phn { get; set; }
        public Nullable<int> student_clsid { get; set; }
        public int class_id { get; set; }
        public string class_name { get; set; }
        public int map_id { get; set; }
        public Nullable<int> map_stdid { get; set; }
        public Nullable<int> map_subid { get; set; }
        public int subject_id { get; set; }
        public string subject_name { get; set; }
        public bool IsChecked { get; set; }
    }
}