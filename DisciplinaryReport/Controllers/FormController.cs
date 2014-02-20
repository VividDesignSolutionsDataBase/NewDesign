using DisciplinaryReport.Models;
using PagedList;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;


namespace DisciplinaryReport.Controllers
{
    public class FormController : Controller
    {
 

//        //
//        // GET: /Form/

//        public ActionResult Report(string sortOrder, string currentFilter, string searchString, int? page) //adds a page parameter, a current sort order parameter, and a current filter parameter to the method 
//{
//    ViewBag.CurrentSort = sortOrder;   // the view with the current sort order to keep the sort order the same while paging
//           ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
//           ViewBag.DateSortParm = sortOrder == "Date" ? "Date_desc" : "Date";

//           if (searchString != null)
//           {
//               page = 1;  //maintain the filter settings during paging, and it must be restored to the text box when the page is redisplayed
//           }
//           else
//           {
//               searchString = currentFilter;
//           }

//           ViewBag.CurrentFilter = searchString;  // provides the view with the current filter strin


//           var DRForms = from s in db.Forms                     
//                          select s;
//           if (!String.IsNullOrEmpty(searchString))
//           {
//               DRForms = DRForms.Where(s => s.DR_INM_LAST_NAME.ToUpper().Contains(searchString.ToUpper())
//                                      || s.DR_INM_FIRST_NAME.ToUpper().Contains(searchString.ToUpper()));
//           }
//           switch (sortOrder)
//           {
//               case "Name_desc":
//                   DRForms = DRForms.OrderByDescending(s => s.DR_INM_LAST_NAME);
//                   break;
//               case "Date":
//                   DRForms = DRForms.OrderBy(s => s.DR_INCIDENT_DATE);
//                   break;
//               case "Date_desc":
//                   DRForms = DRForms.OrderByDescending(s => s.DR_INCIDENT_DATE);
//                   break;
//               default: //Name ascending
//                   DRForms = DRForms.OrderBy(s => s.DR_INM_LAST_NAME);
//                   break;
//           }
//           int pageSize = 25;   // converts the Report query to a single page of forms in a collection type that supports paging.
//           int pageNumber = (page ?? 1);
//           return View(DRForms.ToPagedList(pageNumber, pageSize));
//        }

//        //
//        // GET: /Report/Details/5
//        public ActionResult Details(int id = 0)
//        {
//            FormModel Form = db.Forms.Find(id);
//            if (Form == null)
//            {
//                return HttpNotFound();
//            }
//            return View(Form);
//        }

//        //
//        // GET: /Form/Create

//        [Authorize]
//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Form/Create

//        [HttpPost]
//        [Authorize]
//        public ActionResult Create(FormModel Form)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Forms.Add(Form);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(Form);
//        }





//        //
//        // GET: /Inmate/Edit/5
//        public ActionResult Edit(int id = 0)
//        {
//            FormModel Form = db.Forms.Find(id);
//            if (Form == null)
//            {
//                return HttpNotFound();
//            }
//            return View(Form);
//        }

//        //
//        // POST: /Inmate/Edit/5

//        [HttpPost]
//        public ActionResult Edit(FormModel Form)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(Form).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Edit");
//            }
//            return View(Form);
//        }

//        //
//        // GET: /Inmate/Delete/5
//        [Authorize(Roles = "Admin, User")]
//        public ActionResult Delete(int id = 0)
//        {
//           FormModel Form = db.Forms.Find(id);
//            if (Form == null)
//            {
//                return HttpNotFound();
//            }
//            return View(Form);
//        }

//        //
//        // POST: /Inmate/Delete/5

//        [HttpPost, ActionName("Delete")]
//        [Authorize(Roles = "Admin, User")]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            FormModel Form = db.Forms.Find(id);
//            db.Forms.Remove(Form);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            db.Dispose();
//            base.Dispose(disposing);
//        }



    //---------------------------------------------------
   //-----------------------------------------------------------------------> Open Pages


        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult DR()
        {
            ViewBag.Title = "JSO";
            ViewBag.Message = "Disciplinary Review Forms";

            return View();
        }

       


        public ActionResult Form1amod()
        {
            ViewBag.Message = "Initial Officer's Report.";

            return View();
        }

        public ActionResult Form1b()
        {
            ViewBag.Message = "1st Supervisor's Review.";

            return View();
        }

        public ActionResult Form2a()
        {
            ViewBag.Message = "1st Investigator's Report.";

            return View();
        }

        public ActionResult Form2b()
        {
            ViewBag.Message = "2nd Supervisor's Review.";

            return View();
        }

        public ActionResult Form3a()
        {
            ViewBag.Message = "DR Hearing Officer's Review";

            return View();
        }

        public ActionResult Form3b()
        {
            ViewBag.Message = "DR Hearing Officer's Review";

            return View();
        }

        public ActionResult Form4()
        {
            ViewBag.Message = "DR Hearing Officer's Review";

            return View();
        }

        public ActionResult FSS9512310()
        {
            ViewBag.Message = "Section 951.23 (10)";

            return View();
        }



    }
}

