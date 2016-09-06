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
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        private readonly DbProvider<Reference> _dbList = new DbProvider<Reference>();
        public ActionResult Index()
        {
            #region ReferenceViewModel 
            var dbTestimonialList = _dbList.GetAll().Include(s => s.ReferenceLangs).Where(x => x.IsActive).OrderBy(x => x.RowNumber);

           var TestimonialListModel = new List<ReferenceViewModel>();
            var testimonialItem = new ReferenceViewModel();
            foreach (var item in dbTestimonialList)
            {
                testimonialItem = new ReferenceViewModel()
                {
                    ID = item.ID,
                    ImageURL = item.ImageURL,
                    RowNumber = item.RowNumber,
                    IsActive = item.IsActive,
                    WebURL = item.WebURL,
                    IsTestimonial = item.IsTestimonial

                };
                var dbReferenceLang = item.ReferenceLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (dbReferenceLang != null)
                {
                    testimonialItem.LogoName = dbReferenceLang.LogoName;
                    testimonialItem.Testimonial = dbReferenceLang.Testimonial;

                }
                TestimonialListModel.Add(testimonialItem);

            }
            #endregion
            return View(TestimonialListModel);
        }
    }
}