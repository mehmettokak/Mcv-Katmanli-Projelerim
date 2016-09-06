using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Tool.CropImage;

namespace CompanyWeb.Admin.Controllers
{
    public class LanguageController : Controller
    {
        private readonly DbProvider<Language> _db = new DbProvider<Language>();
        // GET: Language
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            var model = _db.GetById(id);

            return View(model);
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Language/Create
        [HttpPost]
        public ActionResult Create(Language model, HttpPostedFileBase IconURL)
        {
            try
            {
                if (IconURL != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Language/";
                    var imp = new ImageProcess();
                    model.IconURL = imp.SaveImage(IconURL, path);
                }

                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Server Error", ex);
                return View();
            }
        }

        // GET: Language/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _db.GetById(id);
            return View(model);
        }

        // POST: Language/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Language model, HttpPostedFileBase IconURL)
        {
            try
            {
                // TODO: Add update logic here
                var lang = _db.GetById(id);
                lang.Name = model.Name;
                lang.Code = model.Code;
                lang.IsActive = model.IsActive;

                if (IconURL != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Language/";
                    var imp = new ImageProcess();
                    lang.IconURL = imp.SaveImage(IconURL, path);
                }

                _db.Update(lang);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _db.GetById(id);

            return View(model);
        }

        // POST: Language/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Language model)
        {
            try
            {
                // TODO: Add delete logic here
                _db.Delete(id);
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