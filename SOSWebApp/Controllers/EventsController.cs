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
    public class EventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult GetCalendar()
        {
            return View(db.Events.ToList());
        }

        // GET: Events
        public ActionResult Index()
        {
            return View();
        }

    }
}


