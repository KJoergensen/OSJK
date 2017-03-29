using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSJK.Web.Controllers
{
    public class CalendarController : Controller
    {
        [HttpGet]
        [Route("kalender")]
        public ActionResult Index()
        {
            return View();
        }
    }
}