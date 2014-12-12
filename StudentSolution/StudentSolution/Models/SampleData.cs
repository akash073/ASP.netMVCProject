using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentSolution.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<StudentDbContext>
    {
        protected override void Seed(StudentDbContext context)
        {
            context.Students.Add(new Student() {Name = "Tariq", RegNo = "678765", Address = "Comilla"});
            context.Students.Add(new Student() { Name = "Salma", RegNo = "6764" });
            context.Students.Add(new Student() { Name = "Himi", RegNo = "9768", Address = "Dhaka"});
            context.SaveChanges();
        }
    }
}