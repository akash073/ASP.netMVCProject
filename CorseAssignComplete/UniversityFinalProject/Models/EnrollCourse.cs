using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityFinalProject.Models
{
    public class EnrollCourse
    {
        public int EnrollCourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required(ErrorMessage = "Select a course")]

        //public string Name { set; get; }

        //public string Email { set; get; }
        //public int DepartmentId { set; get; }

      
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }
    }
}