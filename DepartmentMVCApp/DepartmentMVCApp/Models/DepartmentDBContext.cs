using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.Models
{
    public class DepartmentDBContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}