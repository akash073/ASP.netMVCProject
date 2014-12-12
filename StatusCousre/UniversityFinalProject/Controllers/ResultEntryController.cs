using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityFinalProject.Models;

namespace UniversityFinalProject.Controllers
{
    public class ResultEntryController : Controller
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: /ResultEntry/
        public ActionResult Index()
        {
            var resultentries = db.ResultEntries.Include(r => r.Course).Include(r => r.GradeLatter).Include(r => r.Student);
            return View(resultentries.ToList());
        }

        // GET: /ResultEntry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultEntry resultentry = db.ResultEntries.Find(id);
            if (resultentry == null)
            {
                return HttpNotFound();
            }
            return View(resultentry);
        }

        // GET: /ResultEntry/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code");
            ViewBag.GradeLatterId = new SelectList(db.GradeLatters, "GradeLatterId", "Grade");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo");
            return View();
        }

        // POST: /ResultEntry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ResultEntryId,StudentId,CourseId,GradeLatterId")] ResultEntry resultentry)
        {
            if (ModelState.IsValid)
            {
                db.ResultEntries.Add(resultentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", resultentry.CourseId);
            ViewBag.GradeLatterId = new SelectList(db.GradeLatters, "GradeLatterId", "Grade", resultentry.GradeLatterId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", resultentry.StudentId);
            return View(resultentry);
        }

        // GET: /ResultEntry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultEntry resultentry = db.ResultEntries.Find(id);
            if (resultentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", resultentry.CourseId);
            ViewBag.GradeLatterId = new SelectList(db.GradeLatters, "GradeLatterId", "Grade", resultentry.GradeLatterId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", resultentry.StudentId);
            return View(resultentry);
        }

        // POST: /ResultEntry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ResultEntryId,StudentId,CourseId,GradeLatterId")] ResultEntry resultentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resultentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", resultentry.CourseId);
            ViewBag.GradeLatterId = new SelectList(db.GradeLatters, "GradeLatterId", "Grade", resultentry.GradeLatterId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", resultentry.StudentId);
            return View(resultentry);
        }

        // GET: /ResultEntry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultEntry resultentry = db.ResultEntries.Find(id);
            if (resultentry == null)
            {
                return HttpNotFound();
            }
            return View(resultentry);
        }

        // POST: /ResultEntry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResultEntry resultentry = db.ResultEntries.Find(id);
            db.ResultEntries.Remove(resultentry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



        public ActionResult GetCourseInfo(int regNo)
        {
            var studentInfo = db.Students.Where(x => x.RegNo == regNo).FirstOrDefault();
            return Json(studentInfo, JsonRequestBehavior.AllowGet);

        }
    }
}
