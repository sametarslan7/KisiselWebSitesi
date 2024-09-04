using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class MainPageController : Controller
    {

        Context c = new Context();

        // GET: MainPage
        public ActionResult Index()
        {
            var deger=c.MainPages.ToList();

            return View(deger);
        }

        public PartialViewResult Icons()
        {
            var deger=c.Icons.ToList();
            return PartialView(deger);
        }
        public ActionResult Experience() 
        {
            var deger = c.Experiences.ToList();
            return PartialView(deger);
        }
        public ActionResult ExperienceIndex()
        {
            var deger = c.Experiences.ToList();
            return PartialView(deger);
        }

        public ActionResult DeneyimGoster(int id)
        {
            var deneyimgoster = c.Experiences.Find(id);
            return View("DeneyimGoster", deneyimgoster);
        }

        public ActionResult DeneyimiGuncelle(Experience exp)
        {
            var anasayfa = c.Experiences.Find(exp.id);
            anasayfa.experience_name = exp.experience_name;
            anasayfa.experience_description = exp.experience_description;

            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YeniDeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDeneyimEkle(Experience exp)
        {
            c.Experiences.Add(exp);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimSil(int id)
        {
            var sil = c.Experiences.Find(id);
            c.Experiences.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //SERTİFİKA ALANI
        public ActionResult Sertificiate()
        {
            var deger= c.Sertificiates.ToList();
            return PartialView(deger);
        }
        public ActionResult SertificiateIndex()
        {
            var deger = c.Sertificiates.ToList();
            return PartialView(deger);
        }
        public ActionResult SertifikaGoster(int id)
        {
            var deneyimgoster = c.Sertificiates.Find(id);
            return View("SertifikaGoster", deneyimgoster);
        }

        public ActionResult SertifikaGuncelle(Sertificiate srt)
        {
            var anasayfa = c.Sertificiates.Find(srt.id);
            anasayfa.sertificiate_name = srt.sertificiate_name;
            anasayfa.sertificiate_description = srt.sertificiate_description;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifikaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifikaEkle(Sertificiate srt)
        {
            c.Sertificiates.Add(srt);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sil = c.Sertificiates.Find(id);
            c.Sertificiates.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}