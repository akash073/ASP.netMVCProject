using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentCourseEnroll.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<StudentEnrollDBContext>
    {
        protected override void Seed(StudentEnrollDBContext context)
        {
            context.Grades.Add(new Grade() { GradeLatter = "A+" });
            context.Grades.Add(new Grade() { GradeLatter = "A" });
            context.Grades.Add(new Grade() { GradeLatter = "A-" });
            context.Grades.Add(new Grade() { GradeLatter = "B+" });
            context.Grades.Add(new Grade() { GradeLatter = "B" });
            context.Grades.Add(new Grade() { GradeLatter = "C" });
            context.Grades.Add(new Grade() { GradeLatter = "D" });
            context.Grades.Add(new Grade() { GradeLatter = "F" });
            context.SaveChanges();


            context.Semesters.Add(new Semester() { SemesterName = "First Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Second Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Thrid Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Fourth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Fifth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Sixth Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Seventh Semester" });
            context.Semesters.Add(new Semester() { SemesterName = "Eighth Semester" });
            context.SaveChanges();
           

        }
    }
}