using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityFinalProject.Models
{
    public class GradeLatter
    {
        public int GradeLatterId { get; set; }
        public string Grade { get; set; }
        public virtual List<ResultEntry> ResultEntries { get; set; }
    }
}