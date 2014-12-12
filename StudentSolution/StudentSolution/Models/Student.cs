using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentSolution.Models
{
    public class Student
    {
        public int StudentId { set; get; }
        [Display(Name = "Registration number")]

        [Required]
        public string RegNo { set; get; }
        [Required]
        public string Name { set; get; }

        public string Address { set; get; }

    }
}