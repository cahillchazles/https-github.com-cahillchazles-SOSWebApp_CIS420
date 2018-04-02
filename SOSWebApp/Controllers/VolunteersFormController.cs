using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Net;
using System.Net.Mail;

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
        public ActionResult GetNonClinicForm()
        {
            return View();
        }
        public ActionResult GetInterpreterForm()
        {
            return View();
        }
        public ActionResult GetVolunteerCommentForm()
        {
            ViewBag.Message = "Your contact page.";
            EmailFormModel email = new EmailFormModel();
            GetVolunteerCommentForm(email);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void GetVolunteerCommentForm(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
#if DEBUG
                //Debug SMTP Settings
                var debugSmtpClient = new SmtpClient();
                debugSmtpClient.Host = "smtp.gmail.com";
                debugSmtpClient.Port = 587;
                debugSmtpClient.EnableSsl = true;
                //Setup credentials to login to our sender email address("UserName", "Password")
                NetworkCredential credentials = new NetworkCredential("sostestemail270@gmail.com", "w3c@m31!");
                debugSmtpClient.UseDefaultCredentials = false;
                debugSmtpClient.Credentials = credentials;

#else
                //Release SMTP Settings
            var releaseSmtpClient = new SmtpClient();
            releaseSmtpClient.EnableSsl = false;
            releaseSmtpClient.Host = "relay-hosting.secureserver.net";
            releaseSmtpClient.Port = 25;
#endif

                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("sostestemail270@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("sostestemail270@gmail.com");  // replace with valid value
                message.Subject = "Volunteer Comment";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "sostestemail270@gmail.com",  // replace with valid value
                        Password = "w3c@m31!"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
        }
    }
}