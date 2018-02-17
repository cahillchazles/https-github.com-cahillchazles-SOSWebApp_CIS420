using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SOSWebApp.Models;

namespace SOSWebApp.Controllers
{
    public class InterpreterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Interpreter
        public ActionResult Index()
        {
            return View(db.Interpreters.ToList());
        }
        public ActionResult GetInterpreterForm()
        {
            return View(db.Interpreters.ToList());
        }

        // GET: Interpreter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interpreter interpreter = db.Interpreters.Find(id);
            if (interpreter == null)
            {
                return HttpNotFound();
            }
            return View(interpreter);
        }

        // GET: Interpreter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interpreter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Language,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] Interpreter interpreter)
        {
            if (ModelState.IsValid)
            {
                db.Interpreters.Add(interpreter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interpreter);
        }

        // GET: Interpreter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interpreter interpreter = db.Interpreters.Find(id);
            if (interpreter == null)
            {
                return HttpNotFound();
            }
            return View(interpreter);
        }

        // POST: Interpreter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Language,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] Interpreter interpreter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interpreter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interpreter);
        }

        // GET: Interpreter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interpreter interpreter = db.Interpreters.Find(id);
            if (interpreter == null)
            {
                return HttpNotFound();
            }
            return View(interpreter);
        }

        // POST: Interpreter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Interpreter interpreter = db.Interpreters.Find(id);
            db.Interpreters.Remove(interpreter);
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
