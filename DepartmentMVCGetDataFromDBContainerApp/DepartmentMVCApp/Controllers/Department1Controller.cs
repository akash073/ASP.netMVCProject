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
            DepartmentContainer aContainer=new DepartmentContainer();
             return View(aContainer.GetAllDepartment());
        }
	}
}