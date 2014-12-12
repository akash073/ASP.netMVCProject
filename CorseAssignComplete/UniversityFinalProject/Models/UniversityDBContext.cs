using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using UniversityFinalProject.Controllers;

namespace UniversityFinalProject.Models
{
    public class UniversityDBContext : DbContext
    {

       // public UniversityDBContext() : base("UniversityFinalProject"){}

        public DbSet<Course> Courses { set; get; }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Semester> Semesters { set; get; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Designation> Designations { get; set; }

        public DbSet<CourseAssign> CourseAssigns { get; set; }

        public DbSet<Student> Students { set; get; }

        public DbSet<EnrollCourse> EnrollCourses { get; set; }
        public DbSet<GradeLatter> GradeLatters { get; set; }
        public DbSet<ResultEntry> ResultEntries { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}