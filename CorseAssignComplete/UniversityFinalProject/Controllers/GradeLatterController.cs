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
    public class GradeLatterController : Controller
    {
        private UniversityDBContext db = new UniversityDBContext();

        // GET: /GradeLatter/
        public ActionResult Index()
        {
            return View(db.GradeLatters.ToList());
        }

        // GET: /GradeLatter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeLatter gradelatter = db.GradeLatters.Find(id);
            if (gradelatter == null)
            {
                return HttpNotFound();
            }
            return View(gradelatter);
        }

        // GET: /GradeLatter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /GradeLatter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="GradeLatterId,Grade")] GradeLatter gradelatter)
        {
            if (ModelState.IsValid)
            {
                db.GradeLatters.Add(gradelatter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gradelatter);
        }

        // GET: /GradeLatter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeLatter gradelatter = db.GradeLatters.Find(id);
            if (gradelatter == null)
            {
                return HttpNotFound();
            }
            return View(gradelatter);
        }

        // POST: /GradeLatter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="GradeLatterId,Grade")] GradeLatter gradelatter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gradelatter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gradelatter);
        }

        // GET: /GradeLatter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeLatter gradelatter = db.GradeLatters.Find(id);
            if (gradelatter == null)
            {
                return HttpNotFound();
            }
            return View(gradelatter);
        }

        // POST: /GradeLatter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GradeLatter gradelatter = db.GradeLatters.Find(id);
            db.GradeLatters.Remove(gradelatter);
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
