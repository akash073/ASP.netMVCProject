using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeLatter { get; set; }
        public virtual List<Result> Results { get; set; }
    }
}