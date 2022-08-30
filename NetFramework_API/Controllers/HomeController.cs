using NetFramework_API.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFramework_API.Controllers
{
    public class HomeController : Controller
    {
        private PersonBL personBL = new PersonBL();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
    }
}
