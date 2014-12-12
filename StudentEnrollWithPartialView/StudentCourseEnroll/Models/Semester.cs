using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}