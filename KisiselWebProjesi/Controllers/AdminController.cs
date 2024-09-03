using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        // GET: Admin
        public ActionResult Index()
        {
            var deger=c.MainPages.ToList();

            return View(deger);
        }

        public ActionResult BilgileriGoster(int id)
        {
            var bilgilerigoster = c.MainPages.Find(id);
            return View("BilgileriGoster",bilgilerigoster);
        }

        public ActionResult BilgileriGuncelle( MainPage parametre)
        {
            var anasayfa = c.MainPages.Find(parametre.id);
            anasayfa.name = parametre.name;
            anasayfa.title = parametre.title;   
            anasayfa.description = parametre.description;
            anasayfa.contact = parametre.contact;

            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult AdminleriGoster()
        {
            var deger = c.Admins.ToList();
            return View(deger);
        }

    }
}