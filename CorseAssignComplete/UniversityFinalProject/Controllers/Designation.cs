using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityFinalProject.Models;

namespace UniversityFinalProject.Controllers
{
    public class Designation
    {
        public int DesignationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}