using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentarSkole.Controllers
{
    public class TelefoniController : Controller
    {
        BazaSkoleContext db = new BazaSkoleContext();

        //Akcija koja prikazuje sve telefone odredjene kontakt osobe
        // GET: Mailovi
        public ActionResult IndexTelefon(int? IdKontaktOsoba)
        {
            TempData["idKoTel"] = IdKontaktOsoba;
            
            return View(db.Telefoni.ToList());
        }

        //Akcija koja dodaje telefon odredjenoj kontakt osobi
        [HttpGet]
        public ActionResult DodajTelefon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajTelefon(Telefon telefon, int? IdKontaktOsoba)
        {

            if (ModelState.IsValid)
            {
                telefon.IdKontaktOsoba = IdKontaktOsoba;
                db.Telefoni.Add(telefon);
                db.SaveChanges();

                return RedirectToAction("IndexTelefon", "Telefoni", TempData["idKoTel"]);
            }
            return View(telefon);
        }


        //Akcija koja menja telefon odredjene kontakt osobe
        public ActionResult IzmeniTelefon(int? idTel)
        {
            Telefon telefon = db.Telefoni.Find(idTel);
            if (telefon == null)
            {
                return HttpNotFound();
            }

            return View(telefon);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IzmeniTelefon(Telefon telefon)
        {
            if (ModelState.IsValid)
            {

                db.Entry(telefon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Skole");
            }

            return View(telefon);
        }

        //Akcija za brisanje telefona odredjene kontakt osobe
        public ActionResult ObrisiTelefon(int idTel = 0)
        {
            Telefon telefon = db.Telefoni.Find(idTel);
            /* if (skola == null)
             {
                 return HttpNotFound();
             }
             */
            return View(telefon);
        }

        [HttpPost, ActionName("ObrisiTelefon")]
        [ValidateAntiForgeryToken]
        public ActionResult BrisanjePotvrdjenoTel(int? id)
        {
            Telefon telefon = db.Telefoni.Find(id);
            db.Telefoni.Remove(telefon);
            db.SaveChanges();
            return RedirectToAction("Index", "Skole");
        }


        //Akcija koja prikazuje detalje telefona odredjene kontakt osobe
        public ActionResult DetaljiTelefon(Telefon telefon, int? idTel)
        {
            Telefon tel = db.Telefoni.Find(idTel);
            return View(tel);
        }
    }
}