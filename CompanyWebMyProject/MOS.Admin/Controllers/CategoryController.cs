using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanyWeb.Admin.Models;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;

namespace CompanyWeb.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DbProvider<Category> _db = new DbProvider<Category>();
        // GET: Category
        public ActionResult Index()
        {
            var catList = _db.GetAll().Include(x=>x.CategoryLangs);

            var model = new List<CategoryViewModel>();
            var modelItem = new CategoryViewModel();
            foreach (var catItem in catList)
            {
                modelItem = new CategoryViewModel()
                {
                    Id = catItem.Id,
                    IsActive = catItem.IsActive,
                    IsMainActive = catItem.IsMainActive,
                    IsMenuActive = catItem.IsMenuActive
                };

                var catLang = catItem.CategoryLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (catLang!=null)
                {
                    modelItem.Name = catLang.Name;
                }

                model.Add(modelItem);
            }

            return View(model);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var cat = _db.GetById(id);

            var model = new CategoryViewModel
            {
                Id = cat.Id,
                MainId = cat.MainId,
                IsActive = cat.IsActive,
                IsMainActive = cat.IsMainActive,
                IsMenuActive = cat.IsMenuActive,
                RowNumber = cat.RowNumber,
                IconUrl = cat.IconUrl
            };
            var catLang = cat.CategoryLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
            if (catLang != null)
            {
                model.Name = catLang.Name;
                model.Link = catLang.Link;
                model.Description = catLang.Description;
            }

            return View(model);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            try
            {
                var category = new Category
                {
                    RowNumber = model.RowNumber,
                    IsActive = model.IsActive,
                    MainId = model.MainId,
                    IconUrl = model.IconUrl,
                    IsMainActive = model.IsMainActive,
                    IsMenuActive = model.IsMenuActive,
                    CategoryLangs = new List<CategoryLang>()
                };

                var catLang = new CategoryLang
                {
                    LanguageId = Helper.LangId,
                    Name = model.Name,
                    Description = model.Description,
                    Link = model.Link
                };
                category.CategoryLangs.Add(catLang);

                _db.Add(category);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var cat = _db.GetById(id);

            var model = new CategoryViewModel
            {
                Id = cat.Id,
                MainId = cat.MainId,
                IsActive = cat.IsActive,
                IsMainActive = cat.IsMainActive,
                IsMenuActive = cat.IsMenuActive,
                RowNumber = cat.RowNumber,
                IconUrl = cat.IconUrl
            };
            var catLang = cat.CategoryLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
            if (catLang != null)
            {
                model.Name = catLang.Name;
                model.Link = catLang.Link;
                model.Description = catLang.Description;
            }

            return View(model);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategoryViewModel model)
        {
            try
            {
                var cat = _db.GetById(id);
                //cat.MainId = cat.MainId;
                cat.IsActive = model.IsActive;
                cat.IsMainActive = model.IsMainActive;
                cat.IsMenuActive = model.IsMenuActive;
                cat.RowNumber = model.RowNumber;
                cat.IconUrl = model.IconUrl;

                var catLang = cat.CategoryLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (catLang != null)
                {
                    catLang.Name = model.Name;
                    catLang.Link = model.Link;
                    catLang.Description = model.Description;
                }
                else
                {
                    catLang = new CategoryLang {LanguageId =Helper.LangId, Name = model.Name, Link = model.Link, Description = model.Description};
                    cat.CategoryLangs.Add(catLang);
                }

                _db.Update(cat);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var cat = _db.GetById(id);

            var model = new CategoryViewModel
            {
                Id = cat.Id,
                MainId = cat.MainId,
                IsActive = cat.IsActive,
                IsMainActive = cat.IsMainActive,
                IsMenuActive = cat.IsMenuActive,
                RowNumber = cat.RowNumber,
                IconUrl = cat.IconUrl
            };
            var catLang = cat.CategoryLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
            if (catLang != null)
            {
                model.Name = catLang.Name;
                model.Link = catLang.Link;
                model.Description = catLang.Description;
            }

            return View(model);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategoryViewModel model)
        {
            try
            {
                var cat = _db.GetById(id);
                _db.Delete(cat);
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
