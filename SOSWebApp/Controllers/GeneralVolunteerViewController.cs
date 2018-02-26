using SOSWebApp.Models;
using SOSWebApp.Models.VolunteerViewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace SOSWebApp.Controllers
{
    public class GeneralVolunteerViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var query = (from v in db.Volunteers
                         where v.IsNonClinical == true
                         orderby v.LastName
                         select v).ToList();
            return View(query.ToList());
        }

        // GET: GeneralVolunteerView
        //public ActionResult Index()
        //{
        //    return View(new GeneralVolunteer());
        //}
        //public ActionResult IndexGeneralVolunteer(GeneralVolunteer viewModel)
        //{
        //    var volunteer = new Volunteer()
        //    {
        //        FirstName = viewModel.FirstName,
        //        LastName = viewModel.LastName,
        //        PreferredName = viewModel.PreferredName,
        //        Address = viewModel.Address,
        //        City = viewModel.City,
        //        State = viewModel.State,
        //        ZipCode = viewModel.ZipCode,
        //        Email = viewModel.Email,
        //        PhoneNumber = viewModel.PhoneNumber,
        //        Birthday = viewModel.Birthday,
        //        tShirtSize = viewModel.tShirtSize,
        //        Employer = viewModel.Employer,
        //        DescribesYou= viewModel.DescribesYou,
        //        Interest = viewModel.Interest

        //    };
        //    db.Volunteers.Add(volunteer);

        //    db.SaveChanges();

        //    return RedirectToAction("Index", "Home");
        //}
        //public ActionResult Edit(int id)
        //{
        //    var volunteer = db.Volunteers.FirstOrDefault(s => s.Id == id);

        //    var viewModel = new GeneralVolunteer()
        //    {
        //        FirstName = volunteer.FirstName,
        //        LastName = volunteer.LastName,
        //        PreferredName = volunteer.PreferredName,
        //        Address = volunteer.Address,
        //        City = volunteer.City,
        //        State = volunteer.State,
        //        ZipCode = volunteer.ZipCode,
        //        Email = volunteer.Email,
        //        PhoneNumber = volunteer.PhoneNumber,
        //        Birthday = volunteer.Birthday,
        //        tShirtSize = volunteer.tShirtSize,
        //        Employer = volunteer.Employer,
        //        DescribesYou = volunteer.DescribesYou,
        //        Interest = volunteer.Interest
        //    };


        //    return View(viewModel);
        //}

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,PreferredName,Address,City,State,ZipCode,Email,PhoneNumber,Birthday,IsNonClinical, tShirtSize,Eployer,DescribesYou,Interest")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteer);
        }



        public ActionResult Create()
        {
            var volunteer = new Volunteer();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,PreferredName,Address,City,State,ZipCode,Email,PhoneNumber,Birthday,IsNonClinical, tShirtSize,Eployer,DescribesYou,Interest")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Volunteers.Add(volunteer);
                


           
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteer);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            db.Volunteers.Remove(volunteer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}