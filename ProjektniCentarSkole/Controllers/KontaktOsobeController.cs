using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentarSkole.Controllers
{
    public class KontaktOsobeController : Controller
    {
        BazaSkoleContext db=new BazaSkoleContext();

        //Akcija koja sluzi za ispis kontakt osoba vezanih za izabranu skolu
        // GET: KontaktOsobe/Index/1
       
        public ActionResult Index(int? IdSkole)
        {
            int id =(int) TempData["id"];
            
                ViewBag.id = TempData["id"];
                return View(db.KontaktOsobe.ToList());
            
            
        }

        //Akcija koja sluzi za dodavanje kontakt osobe kojoj prosledjujemo IdSkole
        [HttpGet]
        public ActionResult DodajKontaktOsobu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajKontaktOsobu(KontaktOsoba kontaktOsoba, int? IdSkola)
        {
            ViewBag.idskola = IdSkola;
            if (ModelState.IsValid)
            {
                kontaktOsoba.IdSkola = IdSkola;
                db.KontaktOsobe.Add(kontaktOsoba);
                db.SaveChanges();

                return RedirectToAction("Index", "Skole");
            }
            return View(kontaktOsoba);
        }

        //Akcija za izmenu kontakt osobe kojoj prosledjujemo Id te kontakt osobe
        public ActionResult IzmeniKontaktOsobu(int? idKO)
        {
            KontaktOsoba kontaktOsoba = db.KontaktOsobe.Find(idKO);
            if (kontaktOsoba == null)
            {
                return HttpNotFound();
            }

            return View(kontaktOsoba);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IzmeniKontaktOsobu(KontaktOsoba kontaktOsoba)
        {
            if (ModelState.IsValid)
            {

                db.Entry(kontaktOsoba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Skole");
            }

            return View(kontaktOsoba);
        }

        //Akcija za brisanje kontakt osobe preko njenog Id-ja
        public ActionResult ObrisiKontaktOsobu(int idKO = 0)
        {
            KontaktOsoba kontaktOsoba = db.KontaktOsobe.Find(idKO);
            /* if (skola == null)
             {
                 return HttpNotFound();
             }
             */
            return View(kontaktOsoba);
        }

        [HttpPost, ActionName("ObrisiKontaktOsobu")]
        [ValidateAntiForgeryToken]
        public ActionResult BrisanjePotvrdjenoKO(int? id)
        {
            KontaktOsoba kontaktOsoba = db.KontaktOsobe.Find(id);
            db.KontaktOsobe.Remove(kontaktOsoba);
            db.SaveChanges();
            return RedirectToAction("Index", "Skole");
        }


        //Akcija koja prikazuje detalje kontakt osobe
        public ActionResult DetaljiKontaktOsobe(KontaktOsoba kontaktO, int? idKO)
        {
            KontaktOsoba kontaktOsoba = db.KontaktOsobe.Find(idKO);
            return View(kontaktOsoba);
        }
    }
}