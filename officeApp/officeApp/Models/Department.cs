using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace officeApp.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }
        [Required(ErrorMessage = "Code is missing")]
        public string Code { set; get; }
         [Display(Name = "Department Name")]
        public string Name { set; get; }


        public virtual List<Section> Sections { set; get; } 
    }
}