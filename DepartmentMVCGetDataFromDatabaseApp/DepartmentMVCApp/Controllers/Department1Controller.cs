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


        DepartmentContainer aContainer = new DepartmentContainer();
        public ActionResult DepartmentList()
        {

            return View((List<Department>) aContainer.GetAllDept());
        }
        [HttpGet]
        public ActionResult SaveDepartment()
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult SaveDepartment(Department aDepartment)
        {
            if (aDepartment.Name != null)
            {
                aContainer.Save(aDepartment);
            }
            return RedirectToAction("DepartmentList");
           
        }
      
	}
}