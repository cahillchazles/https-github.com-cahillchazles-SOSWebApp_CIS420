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
    }
}