using BAL.Provider;
using BAL.Tools;
using Kullanici_Islemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Kullanici_Islemleri.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
       
        public ActionResult Index()
        {
            if (HttpContext.Request.IsAuthenticated) { return View(); }//kullanıcı giriş yaptıysa bu sayfaya yonlendırılır.Dikkat(if sartı tru donerse yanı ıcıne girerse altındakı kodu gormeden gecer.False donerse altındakı kod calısacaktır.)
           
           return RedirectToAction("Login", "Account", new { area = "" });//eğer giriş yapmadıysa UI deki login sayfasına gider.new area "" yazmamızdakı amac=area ıcınde admin/account/Login aramasın diye admin yerine "" tanımladık.Account/Login diye url olusur.
        }
       
    }
}