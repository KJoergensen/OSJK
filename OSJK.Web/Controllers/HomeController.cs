using OSJK.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OSJK.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new EmailFormVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendEmail(EmailFormVM vm)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email Fra: {0} ({1})</p><p>Besked:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("kasp.joer@gmail.com"));
                message.From = new MailAddress("test@joergensen.nu");
                message.Subject = "Kontaktformular";
                message.Body = string.Format(body, vm.FromName, vm.FromEmail, vm.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "test@joergensen.nu", 
                        Password = "yLXY%zwHzbV4r86&YruecXj@Ie01s8" 
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "asmtp.unoeuro.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    ViewBag.EmailSuccesful = true;
                    ModelState.Clear();
                    return View("Contact", new EmailFormVM());
                }
            }
            return View("Contact", vm);
        }
    }
}