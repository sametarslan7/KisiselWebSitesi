using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class IconController : Controller
    {
        Context c = new Context();

        // GET: Icon
        public ActionResult Index()
        {
            var deger = c.Icons.ToList();
            return View(deger);
        }

        public ActionResult IkonlariGoster(int id)
        {
            var ikonlarigoster = c.Icons.Find(id);
            return View("IkonlariGoster", ikonlarigoster);
        }

        public ActionResult IkonlariGuncelle(Icons parametre)
        {
            var anasayfa = c.Icons.Find(parametre.id);
            anasayfa.icon_name = parametre.icon_name;
            anasayfa.icon_link = parametre.icon_link;

            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YeniIkonEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkonEkle( Icons i)
        {
            c.Icons.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}