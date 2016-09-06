using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanyWeb.Admin.Models;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Tool.CropImage;

namespace CompanyWeb.Admin.Controllers
{
    public class SliderController : Controller
    {
        private readonly DbProvider<Slider> _db = new DbProvider<Slider>();
        // GET: Slider
        public ActionResult Index()
        {
            var sliders = _db.GetAll().Include(x => x.SliderLangs);
            var model = new List<SliderViewModel>();
            if (sliders != null && sliders.Any())
            {
                foreach (var slider in sliders)
                {
                    var sliderVm = new SliderViewModel
                    {
                        Id = slider.Id,
                        ImageUrl = slider.ImageUrl,
                        IsActive = slider.IsActive,
                        RowNumber = slider.RowNumber,
                        Title = slider.SliderLangs.First().Title
                    };
                    if (slider.SliderLangs != null && slider.SliderLangs.Count > 0)
                    {
                        var sliderLang = slider.SliderLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                        if (sliderLang != null) sliderVm.Title = sliderLang.Title;
                    }
                    model.Add(sliderVm);
                }
            }
            return View(model);
        }

        // GET: Slider/Details/5
        public ActionResult Details(int id)
        {
            var slider = _db.GetById(id);

            var model = new SliderViewModel
            {
                Id = slider.Id,
                ImageUrl = slider.ImageUrl,
                IsActive = slider.IsActive,
                RowNumber = slider.RowNumber
            };
            if (slider.SliderLangs != null)
            {
                var sliderLang = slider.SliderLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (sliderLang != null)
                    model.Title = sliderLang.Title;
            }

            return View(model);
        }

        // GET: Slider/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Slider/Create
        [HttpPost]
        public ActionResult Create(SliderViewModel model, HttpPostedFileBase ImageUrl)
        {
            try
            {
                if (ImageUrl != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Slider/";
                    var imp = new ImageProcess();
                    model.ImageUrl = imp.SaveImage(ImageUrl, path);
                }

                var slider = new Slider
                {
                    ImageUrl = model.ImageUrl,
                    IsActive = model.IsActive,
                    RowNumber = model.RowNumber.ToInt(),
                    SliderLangs = new List<SliderLang>()
                };

                var sliderLang = new SliderLang {LanguageId = Helper.LangId, Title = model.Title};
                slider.SliderLangs.Add(sliderLang);

                _db.Add(slider);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Server Error", ex);
                return View();
            }
        }

        // GET: Slider/Edit/5
        public ActionResult Edit(int id)
        {
            var slider = _db.GetById(id);

            var model = new SliderViewModel
            {
                Id = slider.Id,
                ImageUrl = slider.ImageUrl,
                IsActive = slider.IsActive,
                RowNumber = slider.RowNumber
            };
            if (slider.SliderLangs != null)
            {
                var sliderLang = slider.SliderLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (sliderLang != null)
                    model.Title = sliderLang.Title;
            }

            return View(model);
        }

        // POST: Slider/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SliderViewModel model, HttpPostedFileBase ImageUrl)
        {
            try
            {
                var slider = _db.GetById(id);
                if (ImageUrl != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Slider/";
                    var imp = new ImageProcess();
                    slider.ImageUrl = imp.SaveImage(ImageUrl, path);
                }
                slider.IsActive = model.IsActive;
                slider.RowNumber = model.RowNumber;

                if (slider.SliderLangs == null)
                    slider.SliderLangs = new List<SliderLang>();

                var sliderLang = slider.SliderLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);

                if (sliderLang == null)
                    sliderLang = new SliderLang {LanguageId = Helper.LangId};
                sliderLang.Title = model.Title;

                _db.Update(slider);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Slider/Delete/5
        public ActionResult Delete(int id)
        {
            var slider = _db.GetById(id);

            var model = new SliderViewModel
            {
                Id = slider.Id,
                ImageUrl = slider.ImageUrl,
                IsActive = slider.IsActive,
                RowNumber = slider.RowNumber
            };
            if (slider.SliderLangs != null)
            {
                var sliderLang = slider.SliderLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (sliderLang != null)
                    model.Title = sliderLang.Title;
            }

            return View(model);
        }

        // POST: Slider/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SliderViewModel model)
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