using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.Models
{
    public class DepartmentContainer:DbContext
    {

        public List<Department> GetAllDepartment() { 
        List<Department> Dpartments = new List<Department>()
            {
                new Department() {DepartmentID = 101, Code = "CSE", Name = "Computer Science and Engineering"},
                 new Department() {DepartmentID = 102, Code = "EEE", Name = "Electronics and Electrical Engineering"},
                  new Department() {DepartmentID = 103, Code = "CE", Name = "Civil Engineering"},
            };
        return Dpartments;
        }
    }
}