using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using KisiselWebProjesi.Models.Classes;

namespace KisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {

        Context c = new Context();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password==ad.password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.username, false);
                Session["username"]=bilgiler.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }

    }
}