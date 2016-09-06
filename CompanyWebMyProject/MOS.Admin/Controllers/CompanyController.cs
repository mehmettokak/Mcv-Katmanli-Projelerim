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
    public class CompanyController : Controller
    {
        // GET: Company
        DbProvider<Company> _db = new DbProvider<Company>();
        public ActionResult Index()
        {
            var company = _db.GetAll().FirstOrDefault();

            var model = new CompanyViewModel
            {
                Id = company.Id,
                EMail = company.EMail,
                Phone1 = company.Phone1,
                Phone2 = company.Phone2,
                Phone3 = company.Fax,
                FacebookUrl = company.FacebookUrl,
                TwitterUrl=company.TwitterUrl,
                LinkedinUrl=company.LinkedinUrl

            };
            if (company.CompanyLangs != null)
            {
                var companyLang = company.CompanyLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (companyLang != null)
                    model.Adress = companyLang.Adress;
                model.Copyright = companyLang.Copyright;
            }

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var company = _db.GetById(id);

            var model = new CompanyViewModel
            {
                Id = company.Id,
                EMail = company.EMail,
                Phone1 = company.Phone1,
                Phone2 = company.Phone2,
                Phone3 = company.Fax,
                FacebookUrl = company.FacebookUrl,
                TwitterUrl = company.TwitterUrl,
                LinkedinUrl = company.LinkedinUrl

            };
            if (company.CompanyLangs != null)
            {
                var companyLang = company.CompanyLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (companyLang != null)
                    model.Adress = companyLang.Adress;
                model.Copyright = companyLang.Copyright;
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id, CompanyViewModel model)
        {
            try
            {
                var company = _db.GetById(id);

                company.EMail = model.EMail;
                company.Phone1 = model.Phone1;
                company.Phone2 = model.Phone2;
                company.Fax = model.Phone3;
                company.FacebookUrl = model.FacebookUrl;
                company.TwitterUrl = model.TwitterUrl;
                company.LinkedinUrl = model.LinkedinUrl;
                if (company.CompanyLangs == null) company.CompanyLangs = new List<CompanyLang>();


                var companyLang = company.CompanyLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);

                if (companyLang == null) companyLang = new CompanyLang { LanguageId = Helper.LangId };
                companyLang.Adress = model.Adress;
                companyLang.Copyright = model.Copyright;

                _db.Update(company);
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