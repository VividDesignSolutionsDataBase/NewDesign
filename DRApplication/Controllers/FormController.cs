using DRApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DRApplication.App_Start
{
    public class FormController : Controller
    {
        JSOContext db = new JSOContext();
        //
        // GET: /Form/
        [HttpGet]
        public ActionResult Form1a()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Form1a(DR dr)
        {
            
            var blah = db.DRs.Select(drs => dr);
            //db.SaveChanges();
            return View(dr);   
        }

    }
}
