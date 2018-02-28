using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOSWebApp.Controllers
{
    public class StaffAccessController : Controller
    {
        // GET: StaffAccess
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetLoginScreen()
        {
            return View();
        }
        public ActionResult StaffAccessScreen()
        {
            return View();
        }
        public ActionResult GetCreateEvents()
        {
            return View();
        }
        public ActionResult GetManageEvents()
        {
            return View();
        }
        public ActionResult GetReports()
        {
            return View();
        }
        public ActionResult GetManageVolunteers()
        {
            return View();
        }
        public ActionResult GetScheduleVolunteers()
        {
            return View();
        }
        public ActionResult GetModifyPhysicianVolunteers()
        {
            return View();
        }
        public ActionResult GetModifyNonPhysicianVolunteers()
        {
            return View();
        }
        public ActionResult GetModifyNonClinicalVolunteers()
        {
            return View();
        }
        public ActionResult GetModifyMedicalInterpreterVolunteers()
        {
            return View();
        }
    }
}