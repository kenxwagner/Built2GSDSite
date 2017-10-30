using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KWBuilt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            //ViewBag.Message = "Enjoy!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nice to meet you.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "The Resume.";
         
            return View();
        }
        
    }
}