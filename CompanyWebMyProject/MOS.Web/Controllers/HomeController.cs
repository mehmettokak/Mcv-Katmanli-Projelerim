using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Threading;
using System.Globalization;
using CompanyWeb.Tool.Mail;

namespace CompanyWeb.Web.Controllers
{
    public class HomeController : Controller
    {
        #region References
        // GET: Home
        HomeViewModel Model = new HomeViewModel();
        private readonly DbProvider<Slider> _dbSliderModel = new DbProvider<Slider>();
        private readonly DbProvider<Reference> _dbReferenceModel = new DbProvider<Reference>();
        private readonly DbProvider<Page> _dbAboutModel = new DbProvider<Page>();
        private readonly DbProvider<Company> _dbCompanyModel = new DbProvider<Company>();
        private readonly DbProvider<Category> _dbCategoryModel = new DbProvider<Category>();
        private readonly DbProvider<Employee> _dbEmployeModel = new DbProvider<Employee>();

        #endregion
        public ActionResult Index()
        {
            int LangId = Helper.LangId;

            #region SliderViewModel 

            var dbSlider = _dbSliderModel.GetAll().Include(x => x.SliderLangs);

            Model.SliderListModel = new List<SliderViewModel>();
            var sliderItem = new SliderViewModel();
            foreach (var dbsliderItem in dbSlider)
            {
                sliderItem = new SliderViewModel()
                {
                    ID = dbsliderItem.Id,
                    ImageURL = dbsliderItem.ImageUrl.ToSetFilePath(),
                    RowNumber = dbsliderItem.RowNumber,
                    IsActive = dbsliderItem.IsActive

                };
                var dbSliderLang = dbsliderItem.SliderLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbSliderLang != null)
                {
                    sliderItem.Title = dbSliderLang.Title;

                }
                Model.SliderListModel.Add(sliderItem);

            }
            #endregion

            #region ReferenceViewModel 
            var dbReferenceList = _dbReferenceModel.GetAll().Include(s => s.ReferenceLangs).Where(x => x.IsActive).OrderBy(x => x.RowNumber).Take(3);

            Model.ReferenceListModel = new List<ReferenceViewModel>();
            var referenceItem = new ReferenceViewModel();
            foreach (var item in dbReferenceList)
            {
                referenceItem = new ReferenceViewModel()
                {
                    ID = item.ID,
                    ImageURL = item.ImageURL,
                    RowNumber = item.RowNumber,
                    IsActive = item.IsActive,
                    WebURL = item.WebURL,
                    IsTestimonial = item.IsTestimonial

                };
                var dbReferenceLang = item.ReferenceLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbReferenceLang != null)
                {
                    referenceItem.LogoName = dbReferenceLang.LogoName;
                    referenceItem.Testimonial = dbReferenceLang.Testimonial;

                }
                Model.ReferenceListModel.Add(referenceItem);

            }
            #endregion

            #region AboutViewModel 
            var dbAboutModel = _dbAboutModel.GetAll().Include(s => s.PageLangs).FirstOrDefault(x => x.Code == "Hakkımızda" && x.Isactive);

            var dbAboutLang = dbAboutModel.PageLangs.FirstOrDefault(x => x.LanguageId == LangId);
            if (dbAboutLang != null)
            {
                Model.AboutModel = new PageViewModel()
                {
                    Id = dbAboutModel.Id,
                    Code = dbAboutModel.Code,
                    IsActive = dbAboutModel.Isactive,
                    Title = dbAboutLang.Title,
                    Description = dbAboutLang.Description
                };
            }
            #endregion

            #region ContactViewModel 
            Model.ContactModel = new Contact();
            #endregion

    #region ServiceViewModel 

            var dbServiceList = _dbCategoryModel.GetAll()
                                 .Include(s => s.CategoryLangs)
                                 .Include(x => x.Categories)
                                 .Include(a => a.Categories.Select(c => c.CategoryLangs))
                                 .Where(x => x.IsActive && x.CategoryType == 2 &&x.MainId==1&& x.IsMainActive);
            var serviceItem = new ServiceViewModel();
            var subItem = new ServiceViewModel();
            Model.ServiceListModel = new List<ServiceViewModel>();
            foreach (var item in dbServiceList)
            {
                serviceItem = new ServiceViewModel()
                {
                    Id = item.Id,
                    IconUrl = item.IconUrl,
                    IsMainActive = item.IsMainActive,
                    IsMenuActive = item.IsMenuActive,
                    MainId = item.MainId,
                    RowNumber = item.RowNumber,
                    IsActive = item.IsActive,
                    ContentType = item.ContentType,
                    CategoryLang = item.CategoryLangs
                };
                var dbServiceLang = item.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbServiceLang != null)
                {
                    serviceItem.Description = dbServiceLang.Description;
                    serviceItem.Link = dbServiceLang.Link;
                    serviceItem.Name = dbServiceLang.Name;
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
                    }
                    serviceItem.Categories.Add(subItem);
                }

                Model.ServiceListModel.Add(serviceItem);

            }

            #endregion

            #region EmployeeViewModel 
            var dbEmployeeList = _dbEmployeModel.GetAll().Include(s => s.EmployeeLangs).Include(s => s.SocialLinks).Where(x => x.IsActive).OrderBy(x => x.RowNumber);

            Model.EmployeeListModel = new List<EmployeeViewModel>();
            var employeeItem = new EmployeeViewModel();
            foreach (var item in dbEmployeeList)
            {
                employeeItem = new EmployeeViewModel()
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,

                    AvatarURL = item.AvatarURL,
                    RowNumber = item.RowNumber,
                    IsActive = item.IsActive,
                    Email = item.Email,
                    MobilePhone = item.MobilePhone,
                    SocialLinks = item.SocialLinks
                };
                var dbEmployeeLang = item.EmployeeLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbEmployeeLang != null)
                {
                    employeeItem.Title = dbEmployeeLang.Title;
                    employeeItem.Description = dbEmployeeLang.Description;
                    employeeItem.Content = dbEmployeeLang.Content;

                }
                Model.EmployeeListModel.Add(employeeItem);

            }
            #endregion

            #region BlogViewModel 

            var dbBlogList = _dbCategoryModel.GetAll().Include(s => s.CategoryLangs)
                .Where(x => x.IsActive&&x.CategoryType==2&&x.MainId==2&&x.IsMainActive)
                .OrderBy(x => x.RowNumber);

            Model.BlogListModel = new List<BlogViewModel>();
            var blogItem = new BlogViewModel();
            foreach (var item in dbBlogList)
            {
                blogItem = new BlogViewModel()
                {
                    Id  = item.Id,
                    IconUrl = item.IconUrl,
                  };
                var dbBlogLang = item.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
                if (dbBlogLang != null)
                {
                    blogItem.Name = dbBlogLang.Name;
                    blogItem.Description = dbBlogLang.Description;

                }
                Model.BlogListModel.Add(blogItem);

            }

            #endregion

            //#region BlogViewModel 
            //var dbBlogList = _dbCategoryModel.GetAll().Include(x => x.CategoryLangs).Where(x => x.MainId == 2);

            //Model.BlogListModel = new List<BlogViewModel>();
            //var blogItem = new BlogViewModel();
            //foreach (var item in dbBlogList)
            //{
            //    blogItem = new BlogViewModel()
            //    {
            //        Id = item.Id,
            //        IconUrl = item.IconUrl,
            //        IsMainActive = item.IsMainActive,
            //        IsActive = item.IsActive,
            //        IsMenuActive = item.IsMenuActive,
            //        RowNumber = item.RowNumber,
            //        MainId = item.MainId,
            //        ContentType = item.ContentType


            //    };
            //    var dbBlogLang = item.CategoryLangs.FirstOrDefault(x => x.LanguageId == LangId);
            //    if (dbBlogLang != null)
            //    {
            //        blogItem.Name = dbBlogLang.Name;
            //        blogItem.Description = dbBlogLang.Description;
            //        blogItem.Link = dbBlogLang.Link;

            //    }
            //    Model.BlogListModel.Add(blogItem);

            //}
            //#endregion


            return View(Model);
        }
        public ActionResult ChangeLang(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }

            HttpCookie cookie = new HttpCookie("lang") { Value = lang };
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

        public JsonResult SendMail(Contact model)
        {
            var mailsender = new MailSender();
            string err = mailsender.Send(model);

            return Json(err);
        }
    }
}