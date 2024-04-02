using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhumaloCraftApplication.Controllers
{
    public class ContactController : Controller // Inherit from Controller class
    {
        // GET: /Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}
