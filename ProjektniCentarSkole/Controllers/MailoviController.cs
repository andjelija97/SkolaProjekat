using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentarSkole.Controllers
{
    public class MailoviController : Controller
    {
        BazaSkoleContext db=new BazaSkoleContext();

        //Akcija koja prikazuje listu mejlova odredjene kontakt osobe
        // GET: Mailovi
        public ActionResult IndexMail(int? IdKontaktOsoba)
        {
            TempData["idKo"] = IdKontaktOsoba;
            ViewBag.idKo=IdKontaktOsoba;
            return View(db.Mailovi.ToList());
        }

        //Akcija za dodavanja mejla za odredjenu kontakt osobu
        [HttpGet]
        public ActionResult DodajMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajMail(Mail mail, int? IdKontaktOsoba)
        {
           
            if (ModelState.IsValid)
            {
                mail.IdKontaktOsoba = IdKontaktOsoba;
                db.Mailovi.Add(mail);
                db.SaveChanges();

                return RedirectToAction("IndexMail", "Mailovi", TempData["idKo"]);
            }
            return View(mail);
        }


        //Akcija za izmenu mejla 
        public ActionResult IzmeniMail(int? idMail)
        {
            Mail mail = db.Mailovi.Find(idMail);
            if (mail == null)
            {
                return HttpNotFound();
            }

            return View(mail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IzmeniMail(Mail mail)
        {
            if (ModelState.IsValid)
            {

                db.Entry(mail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Skole");
            }

            return View(mail);
        }

        //Akcija za brisanje odabranog mejla
        public ActionResult ObrisiMail(int idMail = 0)
        {
            Mail mail = db.Mailovi.Find(idMail);
            /* if (skola == null)
             {
                 return HttpNotFound();
             }
             */
            return View(mail);
        }

        [HttpPost, ActionName("ObrisiMail")]
        [ValidateAntiForgeryToken]
        public ActionResult BrisanjePotvrdjenoMail(int? id)
        {
            Mail mail = db.Mailovi.Find(id);
            db.Mailovi.Remove(mail);
            db.SaveChanges();
            return RedirectToAction("Index", "Skole");
        }


        //Akcija koja prikazuje detalje odredjenog mejla
        public ActionResult DetaljiMail(Mail mail, int? idMail)
        {
            Mail m=db.Mailovi.Find(idMail);
            return View(m);
        }
    }
}