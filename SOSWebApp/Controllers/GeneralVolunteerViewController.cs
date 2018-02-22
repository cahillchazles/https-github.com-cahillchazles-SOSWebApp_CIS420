using SOSWebApp.Models;
using SOSWebApp.Models.VolunteerViewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOSWebApp.Controllers
{
    public class GeneralVolunteerViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GeneralVolunteerView
        public ActionResult Index()
        {
            return View(new GeneralVolunteer());
        }
        public ActionResult Index(GeneralVolunteer viewModel)
        {
            var volunteer = new Volunteer()
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                PreferredName = viewModel.PreferredName,
                Address = viewModel.Address,
                City = viewModel.City,
                State = viewModel.State,
                ZipCode = viewModel.ZipCode,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,
                Birthday = viewModel.Birthday,
                tShirtSize = viewModel.tShirtSize,
                Employer = viewModel.Employer,
                DescribesYou= viewModel.DescribesYou,
                Interest = viewModel.Interest

            };
            db.Volunteers.Add(volunteer);

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int id)
        {
            var volunteer = db.Volunteers.FirstOrDefault(s => s.Id == id);

            var viewModel = new GeneralVolunteer()
            {
                FirstName = volunteer.FirstName,
                LastName = volunteer.LastName,
                PreferredName = volunteer.PreferredName,
                Address = volunteer.Address,
                City = volunteer.City,
                State = volunteer.State,
                ZipCode = volunteer.ZipCode,
                Email = volunteer.Email,
                PhoneNumber = volunteer.PhoneNumber,
                Birthday = volunteer.Birthday,
                tShirtSize = volunteer.tShirtSize,
                Employer = volunteer.Employer,
                DescribesYou = volunteer.DescribesYou,
                Interest = volunteer.Interest
            };


            return View(viewModel);
        }

    }
}