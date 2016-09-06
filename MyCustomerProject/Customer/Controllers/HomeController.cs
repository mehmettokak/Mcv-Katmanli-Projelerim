using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer.BAL.Providers.IndexProvider;
using Customer.BAL.Providers.AboutProvider;
using Customer.Models;
using Customer.BAL.Providers.ContactProvider;
using Customer.Models.Classes;
using Customer.Models.Classes.Contact;



namespace Customer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home 
       
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            var _sp = new SliderProvider();
            model.SliderModel = _sp.GetSliderModel();
            return View(model);
        }
       
        public JsonResult SetEmail(string Email, bool Status)
        {
            string err = "";
            var _np = new NewsLetterProvider();
            if (Status == false)
            {
                err = _np.NewsletterRemove(Email);
                if (!string.IsNullOrEmpty(err))
                {
                    err = "Hata oluştu," + err;
                }
                else
                {
                    err = "Bülten üyeliğiniz iptal edilmiştir.";
                }
            }
            else
            {
                err = _np.NewsletterAdd(Email);
                if (!string.IsNullOrEmpty(err))
                {
                    err = "Hata oluştu," + err;
                }
                else
                {
                    err = "Bülten üyeliğiniz aktif duruma getirilmiştir.";
                }
            }

            return Json(err);
        }
        public ActionResult About()
        {
            AboutViewModel model = new AboutViewModel();
            var _ap = new AboutProvider();
            model.AboutSliderModel = _ap.GetAboutSliderModel();
            model.AboutContentModel = _ap.GetAboutContentModel();
           
           
            return View(model);
        }

        public ActionResult Contact()
        {
           var model = new ContactViewModel();
            var _cp = new ContactProvider();
           model.ContactSliderModel = _cp.GetContactSliderModel();
            //model.ContactContentModel=.....
            return View(model);
        }
        public ActionResult JQuery()
        {
            return View();
        }
    }
}