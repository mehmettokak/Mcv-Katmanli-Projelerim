using CompanyWeb.Admin.Models;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Admin.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbProvider<Page> _db = new DbProvider<Page>();
        public ActionResult Index()
        {
            var about = _db.GetAll().FirstOrDefault();

            var model = new AboutViewModel
            {
                Id = about.Id,
            };
            if (about.PageLangs != null)
            {
                var aboutLang = about.PageLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (aboutLang != null)
                    model.Title = aboutLang.Title;
                model.Description = aboutLang.Description;
            }

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var about = _db.GetById(id);

            var model = new AboutViewModel
            {
                Id = about.Id
            };
            if (about.PageLangs != null)
            {
                var aboutLang = about.PageLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (aboutLang != null)
               model.Title = aboutLang.Title;
               model.Description = aboutLang.Description;
             
                }

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id, AboutViewModel model)
        {
            try
            {
                var about = _db.GetById(id);


                if (about.PageLangs == null) about.PageLangs = new List<PageLang>();


                var aboutLang = about.PageLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);

                if (aboutLang == null) aboutLang = new PageLang { LanguageId = Helper.LangId };
                aboutLang.Title = model.Title;
                aboutLang.Description = model.Description;

                _db.Update(about);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}