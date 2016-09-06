using CompanyWeb.BAL.Provider;
using CompanyWeb.BAL.Repositories;
using CompanyWeb.BAL.UnitOfWork;
using CompanyWeb.DAL.Context;
using CompanyWeb.Entity.Model;
using CompanyWeb.Tool.Crypto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CompanyWeb.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeLang(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }

            HttpCookie cookie = new HttpCookie("lang") {Value = lang};
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl = "/")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User model, string returnUrl = "/")
        {
            if (HttpContext.Request.IsAuthenticated) { FormsAuthentication.SignOut(); }

            if (ModelState.IsValid)
            {
                var db = new DbProvider<User>();
                User user = db.Get(x=>x.Email == model.Email);
                
                if (user != null)
                {
                    var hashPassword = Md5.Convert(model.Password);
                    if (user.Password == hashPassword)
                    {
                        FormsAuthentication.SetAuthCookie(user.Email, true);
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Parola geçerli değil!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı geçerli değil!");
                }
            }
            return View(model);
        }
    }
}