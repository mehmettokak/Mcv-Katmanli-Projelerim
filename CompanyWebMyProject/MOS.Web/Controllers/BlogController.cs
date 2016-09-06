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
    public class BlogController : Controller
    {
        private readonly DbProvider<Category> _dbProductModel = new DbProvider<Category>();
        public void Test()
        {
            Category list = _dbProductModel.GetAll().SingleOrDefault(x => x.CategoryType == 1);

            //var model =list.Where(x => x.Id == x.MainId || x.CategoryType == null).ToList(); 

            var model = _dbProductModel.GetAll().Where(x => x.MainId == list.Id && x.CategoryType == null).ToList(); // danışman koç..
            
            
            
            //Getir(1);



        }
        public List<Category> Getir(int id)
        {
            return _dbProductModel.GetAll().Where(x => x.MainId == id && x.CategoryType == null).ToList(); // danışman koç..
        }

        // GET: Blog
        //private readonly DbProvider<Product> _dbProductModel = new DbProvider<Product>();
        //HomeViewModel Model = new HomeViewModel();
        //public ActionResult Index(int id)
        //{
        //    #region BlogViewModel 
        //    var dbBlogList = _dbProductModel.GetAll(x=>x.CategoryId==id).Include(x=>x.ProductLangs);

        //var model = new List<ProductViewModel>();
        //    var blogItem = new ProductViewModel();
        //    foreach (var item in dbBlogList)
        //    {
        //        blogItem = new ProductViewModel()
        //        {
        //            Id = item.Id,
        //        ImageUrl=item.ImageUrl,
        //        DateTime=item.DateTime,
        //            ContentType = item.ContentType,


        //        };
        //        var dbBlogLang = item.ProductLangs.FirstOrDefault(x => x.LanguageId ==Helper.LangId);
        //        if (dbBlogLang != null)
        //        {
        //            blogItem.Title = dbBlogLang.Title;
        //            blogItem.Description = dbBlogLang.Description;


        //        }
        //        model.Add(blogItem);

        //    }
        //    #endregion

        //    return View(model);
        //}

        //public ActionResult Detail(int id)
        //{
        //    #region EmployeeViewModel 
        //    var dbModel = _dbProductModel.GetById(id);
        //    var dbListModel = _dbProductModel.GetAll().Include(s => s.ProductLangs);

        //    var productModel = new ProductViewModel();

        //    productModel = new ProductViewModel()
        //    {
        //        Id = dbModel.Id,
        //        ImageUrl = dbModel.ImageUrl,
        //        DateTime = dbModel.DateTime,
        //        ContentType=dbModel.ContentType

        //    };
        //    var dbEmployeeLang = dbModel.ProductLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
        //    if (dbEmployeeLang != null)
        //    {
        //        productModel.Title = dbEmployeeLang.Title;
        //        productModel.Description = dbEmployeeLang.Description;


        //    }
        //    #endregion
        //    return View(productModel);
        //}
    }
}