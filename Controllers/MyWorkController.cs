using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhumaloCraftApplication.Controllers
{
    public class MyWorkController : Controller // Inherit from Controller class
    {
        // GET: /MyWork
        public ActionResult Index()
        {
            return View();
        }
    }
}
