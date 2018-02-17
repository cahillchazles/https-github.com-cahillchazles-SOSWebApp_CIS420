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
    public class NonPhysicianClinicalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NonPhysicianClinical
        public ActionResult Index()
        {
            return View(db.NonPhysicianClinicals.ToList());
        }
        public ActionResult GetNonPhysicianForm()
        {
            return View(db.NonPhysicianClinicals.ToList());
        }

        // GET: NonPhysicianClinical/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysicianClinical nonPhysicianClinical = db.NonPhysicianClinicals.Find(id);
            if (nonPhysicianClinical == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysicianClinical);
        }

        // GET: NonPhysicianClinical/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NonPhysicianClinical/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProfessionalTitle,LicensedState,ProfessionalLicenseNumber,TShirtSize,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] NonPhysicianClinical nonPhysicianClinical)
        {
            if (ModelState.IsValid)
            {
                db.NonPhysicianClinicals.Add(nonPhysicianClinical);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nonPhysicianClinical);
        }

        // GET: NonPhysicianClinical/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysicianClinical nonPhysicianClinical = db.NonPhysicianClinicals.Find(id);
            if (nonPhysicianClinical == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysicianClinical);
        }

        // POST: NonPhysicianClinical/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProfessionalTitle,LicensedState,ProfessionalLicenseNumber,TShirtSize,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] NonPhysicianClinical nonPhysicianClinical)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nonPhysicianClinical).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nonPhysicianClinical);
        }

        // GET: NonPhysicianClinical/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysicianClinical nonPhysicianClinical = db.NonPhysicianClinicals.Find(id);
            if (nonPhysicianClinical == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysicianClinical);
        }

        // POST: NonPhysicianClinical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NonPhysicianClinical nonPhysicianClinical = db.NonPhysicianClinicals.Find(id);
            db.NonPhysicianClinicals.Remove(nonPhysicianClinical);
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
