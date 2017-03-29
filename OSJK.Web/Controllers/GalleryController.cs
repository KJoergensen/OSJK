using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSJK.Web.Controllers
{
    public class GalleryController : Controller
    {
        [HttpGet]
        [Route("galleri")]
        public ActionResult Index()
        {
            return View();
        }
    }
}