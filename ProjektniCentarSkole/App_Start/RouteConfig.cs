using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjektniCentarSkole
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
                "Preusmeri",
                "Skole/Preusmeri/{IdSkola}",
                new { controller = "Skole", action = "Preusmeri" });

            routes.MapRoute(
                "DetaljiSkola",
                "Skole/DetaljiSkola/{IdSkola}",
                new { controller = "Skole", action = "DetaljiSkola" });

            routes.MapRoute(
                "IzmeniKO",
                "KontaktOsobe/IzmeniKontaktOsobu/{IdKO}",
                new { controller = "KontaktOsobe", action = "IzmeniKontaktOsobu" });

            routes.MapRoute(
                "IzmeniTel",
                "Telefoni/IzmeniTelefon/{IdTel}",
                new { controller = "Telefoni", action = "IzmeniTelefon" });

            routes.MapRoute(
                "IzmeniMail",
                "Mailovi/IzmeniMail/{IdMail}",
                new { controller = "Mailovi", action = "IzmeniMail" });


            routes.MapRoute(
                "DetaljiTelefon",
                "Telefoni/DetaljiTelefon/{IdTel}",
                new { controller = "Telefoni", action = "DetaljiTelefon" });

            routes.MapRoute(
                "DetaljiMail",
                "Mailovi/DetaljiMail/{IdMail}",
                new { controller = "Mailovi", action = "DetaljiMail" });

          
            routes.MapRoute(
                "DetaljiKO",
                "KontaktOsobe/DetaljiKontaktOsobe/{IdKO}",
                new { controller = "KontaktOsobe", action = "DetaljiKontaktOsobe" });

            routes.MapRoute(
                "Index",
                "KontaktOsobe/Index/{IdSkola}",
                new { controller = "KontaktOsobe", action = "Index" });

            routes.MapRoute(
                "IndexMail",
                "Mailovi/IndexMail/{IdKontaktOsoba}",
                new { controller = "Mailovi", action = "IndexMail" });


            routes.MapRoute(
                "IndexTelefon",
                "Telefoni/IndexTelefon/{IdKontaktOsoba}",
                new { controller = "Telefoni", action = "IndexTelefon" });

            routes.MapRoute(
                "DodajMail",
                "Mailovi/DodajMail/{IdKontaktOsoba}",
                new { controller = "Mailovi", action = "DodajMail" });

            routes.MapRoute(
                "DodajTelefon",
                "Telefoni/DodajTelefon/{IdKontaktOsoba}",
                new { controller = "Telefoni", action = "DodajTelefon" });


            routes.MapRoute(
                "Dodaj",
                "KontaktOsobe/DodajKontaktOsobu/{IdSkola}",
                new { controller = "KontaktOsobe", action = "DodajKontaktOsobu" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
