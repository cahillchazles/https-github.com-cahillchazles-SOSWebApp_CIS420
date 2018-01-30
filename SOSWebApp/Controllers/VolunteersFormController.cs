using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOSWebApp.Controllers
{
    public class VolunteersFormController : Controller
    {
        // GET: VolunteersForm
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPhysicianForm()
        {
            return View();
        }
        public ActionResult GetNonPhysicianForm()
        {
            return View();
        }
    }
}