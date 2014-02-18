using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisciplinaryReport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Title = "Dashboard";
            ViewBag.Message = "Dashboard";

            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Title = "Report";
            ViewBag.Message = "Report";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

 
    }
}
