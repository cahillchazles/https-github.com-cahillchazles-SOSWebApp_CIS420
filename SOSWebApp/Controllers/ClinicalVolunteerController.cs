using SOSWebApp.Models;
using SOSWebApp.Models.VolunteerViewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOSWebApp.Controllers
{
    public class ClinicalVolunteerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClinicalVolunteer
        public ActionResult Index()
        {
            return View(new ClinicalVolunteersViewModel());
        }
        public ActionResult Index(ClinicalVolunteersViewModel viewModel)
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
                ProfessionalTitle = viewModel.ProfessionalTitle,
                LicensedState = viewModel.LicensedState,
                LicenseNumber =viewModel.LicenseNumber,
                MedicalSpecialty = viewModel.MedicalSpecialty,
                tShirtSize = viewModel.tShirtSize
            };
            db.Volunteers.Add(volunteer);

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int id)
        {
            var volunteer = db.Volunteers.FirstOrDefault(s => s.Id == id);

            var viewModel = new ClinicalVolunteersViewModel()
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
                ProfessionalTitle = volunteer.ProfessionalTitle,
                LicensedState = volunteer.LicensedState,
                LicenseNumber = volunteer.LicenseNumber,
                MedicalSpecialty = volunteer.MedicalSpecialty,
                tShirtSize = volunteer.tShirtSize
            };


            return View(viewModel);
        }

    }
}