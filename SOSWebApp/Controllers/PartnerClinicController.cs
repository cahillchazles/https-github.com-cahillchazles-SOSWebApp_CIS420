using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOSWebApp.Controllers
{
    public class PartnerClinicController : Controller
    {
        // GET: PartnerClinic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPartnerClinic()
        {
            return View();
        }
    }
}