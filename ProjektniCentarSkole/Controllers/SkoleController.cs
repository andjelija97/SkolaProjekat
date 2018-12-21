using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentarSkole.Controllers
{
    public class SkoleController : Controller
    {
        BazaSkoleContext db=new BazaSkoleContext();

        //Akcija koja sluzi za prikazivanje svih skola unetih u bazu
        // GET: Skole
        public ActionResult Index()
        {

            return View(db.Skole.ToList());
        }

        public ActionResult Preusmeri(int IdSkola)
        {

            TempData["id"] = IdSkola;
            return RedirectToAction("Index", "KontaktOsobe", new{id=IdSkola});
        }


        //Akcija za dodavanje skole, koja nije dozvoljena za korisnike sa ulogom Pregled
        [CustomAuthorize(Roles = "Admin, Unos")]
        [HttpGet]
        public ActionResult DodajSkolu()
        {


            return View();
        }

        [HttpPost]
        public ActionResult DodajSkolu(Skola skola)
        {
            if (ModelState.IsValid)
            {
                db.Skole.Add(skola);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(skola);
        }

        //Akcija za izmenu odredjene skole koja nije dozvoljena za korisnike sa ulogom Pregled
        [CustomAuthorize(Roles = "Admin, Unos")]
        public ActionResult IzmeniSkola(int? id)
        {
            Skola skola = db.Skole.Find(id);
            if (skola == null)
            {
                return HttpNotFound();
            }

            return View(skola);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IzmeniSkola(Skola skola)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(skola).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
         
            return View(skola);
        }


        //Akcija koja prikazuje detalje skole, dozvoljena za sve korisnike
        public ActionResult DetaljiSkola(Skola skola, int idskola)
        {
            
            Skola sk = db.Skole.Find(idskola);
            return View(sk);


        }


        //Akcija za brisanje odabrane skole, dozvoljena samo za Admina
        [CustomAuthorize(Roles = "Admin")]
        public ActionResult ObrisiSkola(int idskola=0)
        {
            Skola skola = db.Skole.Find(idskola);
           /* if (skola == null)
            {
                return HttpNotFound();
            }
            */
            return View(skola);
        }

        [HttpPost, ActionName("ObrisiSkola")]
        [ValidateAntiForgeryToken]
        public ActionResult BrisanjePotvrdjeno(int id)
        {
            Skola skola = db.Skole.Find(id);
            db.Skole.Remove(skola);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}