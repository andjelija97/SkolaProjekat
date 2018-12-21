using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ProjektniCentarSkole.Models;
using Microsoft.AspNet.Identity.Owin;

namespace ProjektniCentarSkole.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public UserManager<ApplicationUser> UserManager { get; private set; }

        public ActionResult Index()
        {

            return View();
        }

        //Preko ove akcije prikazujemo listu registrovanih korisnika i tu listu moze videti samo Admin
        [CustomAuthorize(Roles = "Admin")]
        public ActionResult ListaKorisnika()
        {

            return View(db.Users.ToList());
        }


        //Naredne metode za DodajKorisnika i IzmeniKorisnika smo napisali, medjutim pojavljuje se odredjena
        // greska(Object reference not set to an instance of an object.) ali u debugeru korisnik kojeg
        //prosledjujemo ovim metodama(CreateAsync i UpdateAsync) nije null vec ima popunjena sva polja
        //pa zbog nedostatka vremena nismo se dalje bavili zasto se to desilo


        /*
                [HttpGet]
                public ActionResult DodajKorisnika()
                {


                    return View();
                }

                [HttpPost]
                public async Task<ActionResult> DodajKorisnika(UserViewModel model)
                {
                    var user = new ApplicationUser();
                    user.UserName = model.UserName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;
                    user.PravaPristupa = model.PravaPristupa;
                    user.TwoFactorEnabled = false;
                    user.LockoutEnabled = false;
                    user.EmailConfirmed = false;

                    /*   var user = new ApplicationUser()
                       {

                           LastName = model.LastName,
                           UserName = model.UserName,
                           PravaPristupa = model.PravaPristupa,
                           Email=model.Email
                       };
                       *//*
                    await UserManager.CreateAsync(user, model.Password);
                    return RedirectToAction("Index");
                }
                */

        /* 
         public async Task<ActionResult> Edit(string id)
         {
             var user = await UserManager.FindByIdAsync(id);
             return View(new UserViewModel(user));
         }

         [HttpPost]
         public async Task<ActionResult> Edit(UserViewModel model)
         {
             var user = new ApplicationUser()
             {
                 Id = model.Id, UserName = model.UserName, LastName = model.LastName, PravaPristupa = model.PravaPristupa
             };
             await UserManager.UpdateAsync(user);
             return RedirectToAction("Index");


         }
     */
    }
}
