using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Web.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        private readonly DbProvider<Category> _dbCategoryModel = new DbProvider<Category>();
        public ActionResult Index(int id)
        {
            int LangId = Helper.LangId;
            var model = new ServiceModel();
            var serviceItem = new ServiceViewModel();
            var subItem = new ServiceViewModel();
            var listModel = new List<ServiceViewModel>();
            
            var dbServisModel = _dbCategoryModel.GetById(id);
            if (dbServisModel.ContentType==2)//Detay Sayfasına Gidecek ise
            {
                #region Model
                serviceItem = new ServiceViewModel()
                {
                    Id = dbServisModel.Id,
                    IconUrl = dbServisModel.IconUrl,
                    ContentType = dbServisModel.ContentType
                };
                var dbServiceLang = dbServisModel.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbServiceLang != null)
                {
                    serviceItem.Name = dbServiceLang.Name;
                    serviceItem.Link = dbServiceLang.Link;
                    serviceItem.Description = dbServiceLang.Description;
                    serviceItem.Content = dbServiceLang.Content;

                }
                model.ServisModel = serviceItem;
                #endregion

                #region Category List Model 

                var dbServisList = _dbCategoryModel.GetAll()
                                                 .Include(s => s.CategoryLangs)
                                                 .Include(x => x.Categories)
                                                 .Include(a => a.Categories.Select(c => c.CategoryLangs))
                                                 .Where(x => x.IsActive && x.CategoryType == 2 && x.MainId == 1 && x.IsMainActive);

                serviceItem = new ServiceViewModel();
                subItem = new ServiceViewModel();
                listModel = new List<ServiceViewModel>();
                foreach (var item in dbServisList)
                {
                    serviceItem = new ServiceViewModel()
                    {
                        Id = item.Id,
                        IconUrl = item.IconUrl,
                        ContentType = item.ContentType,

                    };
                     dbServiceLang = item.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                    if (dbServiceLang != null)
                    {
                        serviceItem.Description = dbServiceLang.Description;
                        serviceItem.Link = dbServiceLang.Link;
                        serviceItem.Name = dbServiceLang.Name;
                        serviceItem.Content = dbServiceLang.Content;
                    }
                    serviceItem.Categories = new List<ServiceViewModel>();
                    foreach (var subCat in item.Categories.Where(c => c.IsMainActive && c.IsActive))
                    {
                        subItem = new ServiceViewModel()
                        {
                            Id = subCat.Id,
                            IconUrl = subCat.IconUrl,
                            IsMainActive = subCat.IsMainActive,
                            IsMenuActive = subCat.IsMenuActive,
                            MainId = subCat.MainId,
                            RowNumber = subCat.RowNumber,
                            IsActive = subCat.IsActive,
                            ContentType = subCat.ContentType,
                            CategoryLang = subCat.CategoryLangs
                        };
                        dbServiceLang = subCat.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                        if (dbServiceLang != null)
                        {
                            subItem.Description = dbServiceLang.Description;
                            subItem.Link = dbServiceLang.Link;
                            subItem.Name = dbServiceLang.Name;
                            subItem.Content = dbServiceLang.Content;
                        }
                        serviceItem.Categories.Add(subItem);
                    }

                    listModel.Add(serviceItem);
                    model.CategoryListModel = listModel;

                }

                #endregion
            }
            else  //liste Sayfasına gidecek ise
            {
                #region SubCategory List Model 

                var dbList = _dbCategoryModel.GetAll(x => x.MainId == dbServisModel.Id && x.IsActive && x.IsMainActive).Include(x=>x.CategoryLangs);
                serviceItem = new ServiceViewModel();
                foreach (var item in dbList)
                {
                    serviceItem = new ServiceViewModel()
                    {
                        Id = item.Id,
                        IconUrl = item.IconUrl,
                        ContentType = item.ContentType
                    };
                    var dbServiceLang = item.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                    if (dbServiceLang != null)
                    {
                        serviceItem.Description = dbServiceLang.Description;
                        serviceItem.Link = dbServiceLang.Link;
                        serviceItem.Name = dbServiceLang.Name;
                        serviceItem.Content = dbServiceLang.Content;
                    }
                   
                

                    listModel.Add(serviceItem);
                    model.SubCategoryListModel = listModel;

                }

                #endregion
            }

               


            return View(model);
        }
    }
}