using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class CourseEnroll
    {
        public int CourseEnrollId { get; set; }


        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }



        [Required(ErrorMessage = "Select a course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }



        [Required(ErrorMessage = "Date missing")]
        public DateTime Date { get; set; }
    }
}