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
    public class UserController : Controller
    {
        DbProvider<User> _db = new DbProvider<User>();
        // GET: Admin/User
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
                return RedirectToAction("Index");
            var model = _db.GetById(Id.ToInt());
            return View(model);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
                return RedirectToAction("Index");
            var model = _db.GetById(Id.ToInt());
            model.Password = "";
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(User model, HttpPostedFileBase avatar_file, string avatar_data)
        {
            if (model == null)
                return RedirectToAction("Index");

            if (avatar_file != null)
            {
                var cropKoord = JsonConvert.DeserializeObject<CropKoord>(avatar_data);
                ImageCrop ic = new ImageCrop();
                var imgByte = ic.Crop(avatar_file.InputStream, cropKoord.x.ToInt(), cropKoord.y.ToInt(), cropKoord.width.ToInt(), cropKoord.height.ToInt());

                ImageProcess ip = new ImageProcess();
                model.AvatarURL = ip.SaveImage(imgByte, Helper.GetSetting("UserImageFilePath"), avatar_file.FileName);
            }
            var dbUser = _db.GetById(model.ID);
            
            dbUser.Email = model.Email;
            dbUser.FirstName = model.FirstName;
            dbUser.IsActive = model.IsActive;
            dbUser.LastName = model.LastName;
            if (!string.IsNullOrEmpty(model.Password))
                dbUser.Password = Tool.Crypto.Md5.Convert(model.Password);
            if(!string.IsNullOrEmpty(model.AvatarURL))
                dbUser.AvatarURL = model.AvatarURL;
            
            _db.Update(dbUser);
            _db.SaveChanges();

            return RedirectToAction("Index","User",null);
        }

        public ActionResult Create()
        {
            var model = new User();
            model.IsActive = true;
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(User model, HttpPostedFileBase avatar_file, string avatar_data)
        {
            if (avatar_file != null)
            {
                var cropKoord = JsonConvert.DeserializeObject<CropKoord>(avatar_data);
                ImageCrop ic = new ImageCrop();
                var imgByte = ic.Crop(avatar_file.InputStream, cropKoord.x.ToInt(), cropKoord.y.ToInt(), cropKoord.width.ToInt(), cropKoord.height.ToInt());

                ImageProcess ip = new ImageProcess();
                model.AvatarURL = ip.SaveImage(imgByte, Helper.GetSetting("UserImageFilePath"), avatar_file.FileName);
            }

            _db.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
                return RedirectToAction("Index");
            var model = _db.GetById(Id.ToInt());
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? Id)
        {
            if (Id == null)
                return RedirectToAction("Index");
            _db.Delete(Id.ToInt());
            return RedirectToAction("Index");
        }

        public JsonResult LoadCropImage(HttpPostedFileBase file, string cropJs)
        {
            var cropKoord = JsonConvert.DeserializeObject<CropKoord>(cropJs);
            ImageCrop ic = new ImageCrop();
            var imgByte = ic.Crop(file.InputStream, cropKoord.x.ToInt(), cropKoord.y.ToInt(), cropKoord.width.ToInt(), cropKoord.height.ToInt());
            var imageData = "data:image/jpeg;base64," + Convert.ToBase64String(imgByte);
            return Json(imageData);
        }
    }

    public class CropKoord
    {
        public float x { get; set; }
        public float y { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public float rotate { get; set; }
    }
}