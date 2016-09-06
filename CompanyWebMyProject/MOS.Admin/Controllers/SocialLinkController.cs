using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Tool.CropImage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Admin.Controllers
{
    public class SocialLinkController : Controller
    {
        DbProvider<SocialLink> _db = new DbProvider<SocialLink>();
        // GET: SocialLink
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        // GET: SocialLink/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocialLink/Create
        public ActionResult Create()
        {
            var model = new SocialLink();
            model.IsActive = true;
            return View(model);
        }

        // POST: SocialLink/Create
        [HttpPost]
        public ActionResult Create(SocialLink socialLink, HttpPostedFileBase IconURL)
        {
            try
            {
                if (IconURL!=null)
                {
                    ImageProcess ip = new ImageProcess();
                    socialLink.IconURL ="~"+ Helper.GetSetting("UploadFilePath") + "/SocialIcons/" ;
                    if (!Directory.Exists(Server.MapPath(socialLink.IconURL)))
                        Directory.CreateDirectory(Server.MapPath(socialLink.IconURL));
                    socialLink.IconURL += IconURL.FileName;
                    IconURL.SaveAs(Server.MapPath(socialLink.IconURL));
                }

                _db.Add(socialLink);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: SocialLink/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocialLink/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SocialLink/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocialLink/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
