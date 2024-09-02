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
    }
}