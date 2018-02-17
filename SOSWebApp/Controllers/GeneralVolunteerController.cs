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
    public class GeneralVolunteerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GeneralVolunteer
        public ActionResult Index()
        {
            return View(db.GeneralVolunteers.ToList());
        }
        public ActionResult GetNonClinicForm()
        {
            return View(db.GeneralVolunteers.ToList());
        }

        // GET: GeneralVolunteer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralVolunteer generalVolunteer = db.GeneralVolunteers.Find(id);
            if (generalVolunteer == null)
            {
                return HttpNotFound();
            }
            return View(generalVolunteer);
        }

        // GET: GeneralVolunteer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralVolunteer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Employer,DescribesYou,Interests,TShirtSize,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] GeneralVolunteer generalVolunteer)
        {
            if (ModelState.IsValid)
            {
                db.GeneralVolunteers.Add(generalVolunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(generalVolunteer);
        }

        // GET: GeneralVolunteer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralVolunteer generalVolunteer = db.GeneralVolunteers.Find(id);
            if (generalVolunteer == null)
            {
                return HttpNotFound();
            }
            return View(generalVolunteer);
        }

        // POST: GeneralVolunteer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Employer,DescribesYou,Interests,TShirtSize,FirstName,LastName,Address,City,State,ZipCode,PreferredName,PhoneNumber,Email,Birthday")] GeneralVolunteer generalVolunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(generalVolunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generalVolunteer);
        }

        // GET: GeneralVolunteer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeneralVolunteer generalVolunteer = db.GeneralVolunteers.Find(id);
            if (generalVolunteer == null)
            {
                return HttpNotFound();
            }
            return View(generalVolunteer);
        }

        // POST: GeneralVolunteer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GeneralVolunteer generalVolunteer = db.GeneralVolunteers.Find(id);
            db.GeneralVolunteers.Remove(generalVolunteer);
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
