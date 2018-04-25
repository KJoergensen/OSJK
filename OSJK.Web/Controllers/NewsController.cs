using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSJK.Web.Controllers
{
    public partial class NewsController : Controller
    {
        [HttpGet]
        [Route("nyheder")]
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}