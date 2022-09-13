using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3_Student3.Models
{
    public class studViewModel
    {
        public tb2_student getStudent { get; set; }
        public tb2_class getClass { get; set; }
        public tb2_subject getSubject { get; set; }
        public  tb2_mapping getMapping { get; set; }
       
    }
}