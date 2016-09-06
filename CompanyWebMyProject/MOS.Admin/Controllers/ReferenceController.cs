using CompanyWeb.Admin.Models;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Tool.CropImage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Admin.Controllers
{
    public class ReferenceController : Controller
    {
        // GET: Reference
        DbProvider<Reference> _db = new DbProvider<Reference>();
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var reference = _db.GetById(id);

            var model = new ReferenceViewModel
            {
                Id = reference.ID,
                ImageURL = reference.ImageURL,
                IsActive = reference.IsActive,
                RowNumber = reference.RowNumber,
                IsTestimonial = reference.IsTestimonial,
                WebURL= reference.WebURL

            };
            if (reference.ReferenceLangs != null)
            {
                var referenceLang = reference.ReferenceLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                    model.LogoName = referenceLang.LogoName;
                    model.Testimonial = referenceLang.Testimonial;
            }

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var reference = _db.GetById(id);

            var model = new ReferenceViewModel
            {
                Id = reference.ID,
                ImageURL = reference.ImageURL,
                IsActive = reference.IsActive,
                RowNumber = reference.RowNumber,
                IsTestimonial = reference.IsTestimonial,
                WebURL = reference.WebURL
            };
            if (reference.ReferenceLangs != null)
            {
                var referenceLang = reference.ReferenceLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                    model.LogoName = referenceLang.LogoName;
                model.Testimonial = referenceLang.Testimonial;
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id, ReferenceViewModel model, HttpPostedFileBase ImageUrl)
        {
            try
            {
                var reference = _db.GetById(id);
                if (ImageUrl != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Reference/";
                    var imp = new ImageProcess();
                    reference.ImageURL = imp.SaveImage(ImageUrl, path);
                }
                reference.IsActive = model.IsActive;
                reference.RowNumber = model.RowNumber;
                reference.IsTestimonial = model.IsTestimonial;
                if (reference.ReferenceLangs == null)
                    reference.ReferenceLangs = new List<ReferenceLang>();

                var referenceLang = reference.ReferenceLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);

                if (referenceLang == null) referenceLang = new ReferenceLang { LanguageId = Helper.LangId };
                referenceLang.LogoName = model.LogoName;
                referenceLang.Testimonial = model.Testimonial;

                _db.Update(reference);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            var model = new ReferenceViewModel();
            model.IsActive = true;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ReferenceViewModel model, HttpPostedFileBase ImageUrl)
        {
            try
            {
                if (ImageUrl != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Reference/";
                    var imp = new ImageProcess();
                    model.ImageURL = imp.SaveImage(ImageUrl, path);
                }

                var reference = new Reference
                {
                    ImageURL = model.ImageURL,
                    IsActive = model.IsActive,
                    RowNumber = model.RowNumber.ToInt(),
                    WebURL = model.WebURL,
                    ReferenceLangs = new List<ReferenceLang>()
                };

                var referenceLang = new ReferenceLang
                {
                    LanguageId = Helper.LangId,
                    LogoName = model.LogoName,
                    Testimonial = model.Testimonial
                };
                reference.ReferenceLangs.Add(referenceLang);

                _db.Add(reference);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Server Error", ex);
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var reference = _db.GetById(id);

            var model = new ReferenceViewModel
            {
                Id = reference.ID,
                ImageURL = reference.ImageURL,
                IsActive = reference.IsActive,
                RowNumber = reference.RowNumber,
                IsTestimonial= reference.IsTestimonial,
                WebURL= reference.WebURL

            };
            if (reference.ReferenceLangs != null)
            {
                var referenceLang = reference.ReferenceLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                {
                    model.LogoName = referenceLang.LogoName;
                    model.Testimonial = referenceLang.Testimonial;
                }
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ReferenceViewModel model)
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