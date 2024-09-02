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

    }
}