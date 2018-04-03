using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;
using SOSWebApp.Models;

namespace SOSWebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Home()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            EmailFormModel email = new EmailFormModel();
            Contact2(email);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void  Contact2(EmailFormModel model)
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

                //Super duper fun logic stuff aronies. 
                ////actually they are not actually super
                //////actually they are super my man
                ////////just a comment on the last comment
                if (model.IsPhysicianOnly)
                {
                    var physicianEmailList = db.Volunteers.Where(Volunteer => Volunteer.IsPhysician).Select(Volunteer => Volunteer.Email).ToList();
                    foreach (var email in physicianEmailList)
                    {
                        message.To.Add(new MailAddress(email));  // replace with valid value 
                    }

                }
                if(model.IsClinicalOnly)
                {
                    var clinicalEmailList = db.Volunteers.Select(Volunteer => Volunteer.Email).ToList();


                    foreach (var email in clinicalEmailList)
                    {
                        message.To.Add(new MailAddress(email));  // replace with valid value 
                    }

                }
                if(model.IsGeneralOnly)
                {
                    var generalEmailList = db.Volunteers.Select(Volunteer => Volunteer.Email).ToList();


                    foreach (var email in generalEmailList)
                    {
                        message.To.Add(new MailAddress(email));  // replace with valid value 
                    }

                }
                if(model.IsInterpreterOnly)
                {
                    var interpreterEmailList = db.Volunteers.Select(Volunteer => Volunteer.Email).ToList();


                    foreach (var email in interpreterEmailList)
                    {
                        message.To.Add(new MailAddress(email));  // replace with valid value 
                    }

                }
                //else
                //{
                //    var emailList = db.Volunteers.Select(Volunteer => Volunteer.Email).ToList();


                //    foreach (var email in emailList)
                //    {
                //        message.To.Add(new MailAddress(email));  // replace with valid value 
                //    }

                //}
                //var stop = "stop";
                //var emailList = db.Volunteers.Select(Volunteer => Volunteer.Email).ToList();


                //foreach (var email in emailList)
                //{
                //    message.To.Add(new MailAddress(email));  // replace with valid value 
                //}
                message.To.Add(new MailAddress("sostestemail270@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("sostestemail270@gmail.com");  // replace with valid value
                    message.Subject = "SOS Louisville Email Blast";
                    message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                //message.Attachments.Add(new Attachment(HttpContext.Server.MapPath("~/App_Data/Test.docx")));
                message.IsBodyHtml = true;


                if (model.Upload != null && model.Upload.ContentLength > 0)
                {
                    message.Attachments.Add(new Attachment(model.Upload.InputStream, Path.GetFileName(model.Upload.FileName)));

                }

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
                    //return View("Sent");
                }

            }
        }

        public ActionResult Sent()
        {
            return View();
        }
    }
}