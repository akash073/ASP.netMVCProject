﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityFinalProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        //[Remote("IsExist", "Department", ErrorMessage = "URL exist!")]
        //[Index("CodeIndex", unique: true)]
        //[Index("IX_FirstAndSecond", 1, IsUnique = true)]
        //[UniqueKey] 
        //[UniqueKey, 1]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(10, MinimumLength = 2)]
        [Remote("IsCodeExist", "Department", ErrorMessage = "This code already Exits")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(40, ErrorMessage = "Maximum 40 characters.")]
        [Remote("IsNameExist", "Department", ErrorMessage = "This name already Exits")]
        public string Name { get; set; }

        public virtual List<Course> Courses { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<CourseAssign> CourseAssigns { get; set; }
    //    public virtual List<ViewCourseStatus> ViewCourseStatuss { get; set; }

        public virtual List<Student> Students { get; set; }
        
    }
}