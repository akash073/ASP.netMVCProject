using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UniversityFinalProject.Controllers;

namespace UniversityFinalProject.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<UniversityDBContext>
    {
        protected override void Seed(UniversityDBContext context)
        {
            context.Semesters.Add(new Semester() { SemesterName = "First Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Second Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Thrid Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Fourth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Fifth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Sixth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Seventh Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Eighth Semester" });
            context.SaveChanges();

            context.GradeLatters.Add(new GradeLatter() { Grade = "A+" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "A" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "A-" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "B+" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "B" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "B-" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "C" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "D" });
            context.GradeLatters.Add(new GradeLatter() { Grade = "F" });
            context.SaveChanges();


            context.Designations.Add(new Designation() { Name = "Lecturer" });
            context.Designations.Add(new Designation() { Name = "Assistant Professor" });
            context.Designations.Add(new Designation() { Name = "Associate Professor" });
            context.Designations.Add(new Designation() { Name = "Professor" });
            context.Designations.Add(new Designation() { Name = "DEAN" });
            context.Designations.Add(new Designation() { Name = "Guest Teacher" });
            context.Designations.Add(new Designation() { Name = "Senior Lecturer" });
            context.SaveChanges();






            context.Departments.Add(new Department() { Code = "CSE", Name = "Computer Science" });
            context.Departments.Add(new Department() { Code = "EEE", Name = "Electrical and Elec." });
            context.Departments.Add(new Department() { Code = "PHY", Name = "Physics" });
            context.Departments.Add(new Department() { Code = "MATH", Name = "Math" });
            context.Departments.Add(new Department() { Code = "CE", Name = "Civil" });
            context.SaveChanges();



            context.Courses.Add(new Course() { Code = "101", Name = "C", Credit = 3, Description = "ComputerF.", DepartmentId =1 ,SemesterId = 1});
            context.Courses.Add(new Course() { Code = "102", Name = "C++", Credit = 3, Description = "Computer Programming", DepartmentId = 2, SemesterId = 2 });
            context.Courses.Add(new Course() { Code = "103", Name = "Electronics....", Credit = 3, Description = "Electrical", DepartmentId = 1, SemesterId = 1});
            context.Courses.Add(new Course() { Code = "104", Name = "Electronics1....", Credit = 3, Description = "Electrical1...", DepartmentId = 2, SemesterId = 2 });
            context.SaveChanges();


            //context.Students.Add(new Student() { RegNo = "1", Name = "RHN", Email = "Sukarno1@gmail.com", ContactNo = "09709", Address =" 2012 / 12 / 3", DepartmentId =  1 });
            //context.Students.Add(new Student() { RegNo = "2", Name = "ASM", Email = "Sukarno2@gmail.com", ContactNo = "456456", Address = "2012 / 12 / 3", DepartmentId = 2 });
            //context.Students.Add(new Student() { RegNo = "3", Name = "ARN", Email = "Sukarno3@gmail.com", ContactNo = "34t3t46", Address = "2012 / 12 / 3", DepartmentId = 1 });
            //context.SaveChanges();

        }
    }
}