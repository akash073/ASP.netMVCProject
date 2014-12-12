using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class Course
    {
        [Display(Name = "Course")]
        public int CourseId { get; set; }



        [Required(ErrorMessage = "Code is required.")]
        [StringLength(63, MinimumLength = 2)]
        public string Code { get; set; }



        [Required(ErrorMessage = "Name is required.")]
        [StringLength(127, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public double Credit { get; set; }

        public string Description { get; set; }



        [Required(ErrorMessage = "Please select department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }


        [Required(ErrorMessage = "Please select semester")]
        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual List<CourseEnroll> CoursesEnroll { get; set; }
        public virtual List<Result> Results { get; set; }
     
    }
}