using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thi_WAD.Models;

namespace Thi_WAD.Controllers
{
    public class ExamsController : Controller
    {
        private Thi_WADContext db = new Thi_WADContext();

        // GET: Exams
        public ActionResult Index()
        {
            var exams = db.Exams.Include(e => e.Class).Include(e => e.Subject).Include(e => e.Faculty1);
            return View(exams.ToList());
        }

        // GET: Exams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Exams/Create
        public ActionResult Create()
        {
            ViewBag.classRoom = new SelectList(db.Classes, "id", "name");
            ViewBag.examSubject = new SelectList(db.Subjects, "id", "name");
            ViewBag.faculty = new SelectList(db.Faculties, "id", "name");
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,examSubject,startTime,examDate,duration,classRoom,faculty")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Exams.Add(exam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.classRoom = new SelectList(db.Classes, "id", "name", exam.classRoom);
            ViewBag.examSubject = new SelectList(db.Subjects, "id", "name", exam.examSubject);
            ViewBag.faculty = new SelectList(db.Faculties, "id", "name", exam.faculty);
            return View(exam);
        }

        // GET: Exams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            ViewBag.classRoom = new SelectList(db.Classes, "id", "name", exam.classRoom);
            ViewBag.examSubject = new SelectList(db.Subjects, "id", "name", exam.examSubject);
            ViewBag.faculty = new SelectList(db.Faculties, "id", "name", exam.faculty);
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,examSubject,startTime,examDate,duration,classRoom,faculty")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.classRoom = new SelectList(db.Classes, "id", "name", exam.classRoom);
            ViewBag.examSubject = new SelectList(db.Subjects, "id", "name", exam.examSubject);
            ViewBag.faculty = new SelectList(db.Faculties, "id", "name", exam.faculty);
            return View(exam);
        }

        // GET: Exams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exam exam = db.Exams.Find(id);
            db.Exams.Remove(exam);
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
