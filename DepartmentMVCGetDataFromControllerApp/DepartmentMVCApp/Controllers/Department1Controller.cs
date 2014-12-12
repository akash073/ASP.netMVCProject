using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepartmentMVCApp.Models;

namespace DepartmentMVCApp.Controllers
{
    public class Department1Controller : Controller
    {
        //
        // GET: /Department1/
        public ActionResult DepartmentList()
        {
            List<Department> Dpartments = new List<Department>()
            {
                new Department() {DepartmentID = 101, Code = "CSE", Name = "Computer Science and Engineering"},
                 new Department() {DepartmentID = 102, Code = "EEE", Name = "Electronics and Electrical Engineering"},
                  new Department() {DepartmentID = 103, Code = "CE", Name = "Civil Engineering"},
            };
            return View(Dpartments);
        }
	}
}