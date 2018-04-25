using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSJK.Web.Controllers
{
    public partial class GalleryController : Controller
    {
        [HttpGet]
        [Route("galleri")]
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}