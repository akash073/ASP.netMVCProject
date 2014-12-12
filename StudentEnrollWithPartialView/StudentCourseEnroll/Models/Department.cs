using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Code is required.")]
        [StringLength(31, MinimumLength = 2)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(63, ErrorMessage = "Maximum 63 characters.")]
        public string Name { get; set; }

        public virtual List<Course> Courses { get; set; }
        public virtual List<Student> Students { get; set; }
      
    }
}