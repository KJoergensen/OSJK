using OSJK.Web.Models;
using OSJK.Web.Resources;
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
    public partial class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("omklubben")]
        public virtual ActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("kontakt")]
        public virtual ActionResult Contact()
        {
            return View(new EmailFormVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> SendEmail(EmailFormVM vm)
        {
            // TODO: Use dropdown for contacts to determine recipient (enum.chosen.value.tostring())s
            if (ModelState.IsValid)
            {
                var message = new MailMessage();
                // TODO: Put values in config (transforms)
                message.To.Add(new MailAddress("kasp.joer@gmail.com"));
                message.From = new MailAddress("test@joergensen.nu");
                message.Subject = "Kontaktformular";
                message.Body = $"<p>Email Fra: {vm.FromName} ({vm.FromEmail})</p><p>Besked:</p><p>{vm.Message}</p>";
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "test@joergensen.nu",
                        Password = "yLXY%zwHzbV4r86&YruecXj@Ie01s8"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.unoeuro.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    try
                    {
                        await smtp.SendMailAsync(message);
                    }
                    catch (Exception e)
                    {
                        ViewBag.ErrorMessage = Strings.ERROR_PROBLEM_SENDING_EMAIL;
                        return View(MVC.Shared.Views.ViewNames.Error);
                    }
                    ViewBag.EmailSuccesful = true;
                    ModelState.Clear();
                    return View(MVC.Home.Views.ViewNames.Contact, new EmailFormVM());
                }
            }
            return View(MVC.Home.Views.ViewNames.Contact, vm);
        }
    }
}