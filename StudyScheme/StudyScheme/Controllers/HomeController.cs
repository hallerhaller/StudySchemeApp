using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyScheme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Br_Bil = new SelectList(db.Students, "Bil_Id", "Bil_RegNr");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Br_Id,Br_EfterNamn,Br_ForNamn,Br_PersonNr,Br_Stad,Br_Bil")] Tbl_Brukare tbl_Brukare)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Brukare.Add(tbl_Brukare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Br_Bil = new SelectList(db.Tbl_Bil, "Bil_Id", "Bil_RegNr", tbl_Brukare.Br_Bil);
            return View(tbl_Brukare);
        }
    }
}