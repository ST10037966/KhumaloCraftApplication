using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhumaloCraftApplication.Controllers
{
    public class AboutController : Controller // Inherit from Controller class
    {
        // GET: /About
        public ActionResult Index()
        {
            return View();
        }
    }
}
