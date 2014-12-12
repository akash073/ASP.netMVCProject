using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentCourseEnroll.Models;

namespace StudentCourseEnroll.Controllers
{
    public class CourseEnrollController : Controller
    {
        private StudentEnrollDBContext db = new StudentEnrollDBContext();

        // GET: /CourseEnroll/
        public ActionResult Index()
        {
            var enrollcourses = db.EnrollCourses.Include(c => c.Course).Include(c => c.Student);
            return View(enrollcourses.ToList());
        }

        // GET: /CourseEnroll/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnroll courseenroll = db.EnrollCourses.Find(id);
            if (courseenroll == null)
            {
                return HttpNotFound();
            }
            return View(courseenroll);
        }

        // GET: /CourseEnroll/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo");
            return View();
        }

        // POST: /CourseEnroll/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourseEnrollId,StudentId,CourseId,Date")] CourseEnroll courseenroll)
        {
            if (ModelState.IsValid)
            {
                db.EnrollCourses.Add(courseenroll);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseenroll.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", courseenroll.StudentId);
            return View(courseenroll);
        }

        // GET: /CourseEnroll/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnroll courseenroll = db.EnrollCourses.Find(id);
            if (courseenroll == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseenroll.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", courseenroll.StudentId);
            return View(courseenroll);
        }

        // POST: /CourseEnroll/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CourseEnrollId,StudentId,CourseId,Date")] CourseEnroll courseenroll)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseenroll).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseenroll.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "RegNo", courseenroll.StudentId);
            return View(courseenroll);
        }

        // GET: /CourseEnroll/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnroll courseenroll = db.EnrollCourses.Find(id);
            if (courseenroll == null)
            {
                return HttpNotFound();
            }
            return View(courseenroll);
        }

        // POST: /CourseEnroll/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseEnroll courseenroll = db.EnrollCourses.Find(id);
            db.EnrollCourses.Remove(courseenroll);
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
    }
}
