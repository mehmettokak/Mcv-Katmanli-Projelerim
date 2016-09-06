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
    public class EmployeeController : Controller
    {
        DbProvider<Employee> _db = new DbProvider<Employee>();
        // GET: Employee
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = _db.GetById(id);

            var model = new EmployeeViewModel
            {
                ID = employee.ID,
                AvatarURL = employee.AvatarURL,
                IsActive = employee.IsActive,
                RowNumber = employee.RowNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email=employee.Email,
                MobilePhone=employee.MobilePhone

            };
            if (employee.EmployeeLangs != null)
            {
                var referenceLang = employee.EmployeeLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                    model.Title = referenceLang.Title;
                model.Description = referenceLang.Description;
                model.Content = referenceLang.Content;
            }
            return View(model);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            var model = new EmployeeViewModel();
            model.IsActive = true;
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeViewModel model, HttpPostedFileBase avatar_file, string avatar_data)
        {
            try
            {
                if (avatar_file != null)
                {
                    var cropKoord = JsonConvert.DeserializeObject<CropKoord>(avatar_data);
                    ImageCrop ic = new ImageCrop();
                    var imgByte = ic.Crop(avatar_file.InputStream, cropKoord.x.ToInt(), cropKoord.y.ToInt(), cropKoord.width.ToInt(), cropKoord.height.ToInt());

                    ImageProcess ip = new ImageProcess();
                    model.AvatarURL = ip.SaveImage(imgByte, Helper.GetSetting("EmployeeImageFilePath"), avatar_file.FileName);
                }

                var employee = new Employee
                {
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    AvatarURL = model.AvatarURL,
                   Email=model.Email,
                   MobilePhone=model.MobilePhone,
                    IsActive = model.IsActive,
                    RowNumber = model.RowNumber.ToInt(),
                   EmployeeLangs  = new List<EmployeeLang>()
                };

                var employeeLang = new EmployeeLang
                {
                    LanguageId = Helper.LangId,
                    Title = model.Title,
                    Description = model.Description,
                    Content = model.Content
                };
                employee.EmployeeLangs.Add(employeeLang);

                _db.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Server Error", ex);
                return View();
            }
         
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _db.GetById(id);

            var model = new EmployeeViewModel
            {
                ID = employee.ID,
                AvatarURL = employee.AvatarURL,
                IsActive = employee.IsActive,
                RowNumber = employee.RowNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email=employee.Email,
                MobilePhone=employee.MobilePhone
            };
            if (employee.EmployeeLangs != null)
            {
                var referenceLang = employee.EmployeeLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                    model.Title = referenceLang.Title;
                model.Description = referenceLang.Description;
                model.Content = referenceLang.Content;
            }
            return View(model);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeViewModel model, HttpPostedFileBase ImageUrl)
        {
            try
            {
                var employee = _db.GetById(id);
                if (ImageUrl != null)
                {
                    var path = Helper.GetSetting("UploadFilePath") + "/Employee/";
                    var imp = new ImageProcess();
                    employee.AvatarURL = imp.SaveImage(ImageUrl, path);
                }
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.MobilePhone = model.MobilePhone;
                employee.Email = model.Email;
                employee.IsActive = model.IsActive;
                employee.RowNumber = model.RowNumber;
               
                if (employee.EmployeeLangs == null)
                    employee.EmployeeLangs = new List<EmployeeLang>();

                var referenceLang = employee.EmployeeLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);

                if (referenceLang == null) referenceLang = new EmployeeLang { LanguageId = Helper.LangId };
                referenceLang.Title = model.Title;
                referenceLang.Description = model.Description;
                referenceLang.Content = model.Content;
                _db.Update(employee);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = _db.GetById(id);

            var model = new EmployeeViewModel
            {
                ID = employee.ID,
                AvatarURL = employee.AvatarURL,
                IsActive = employee.IsActive,
                RowNumber = employee.RowNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                MobilePhone = employee.MobilePhone
            };
            if (employee.EmployeeLangs != null)
            {
                var referenceLang = employee.EmployeeLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
                if (referenceLang != null)
                    model.Title = referenceLang.Title;
                model.Description = referenceLang.Description;
                model.Content = referenceLang.Content;
            }
            return View(model);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EmployeeViewModel model)
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

        public JsonResult LoadCropImage(HttpPostedFileBase file, string cropJs)
        {
            var cropKoord = JsonConvert.DeserializeObject<CropKoord>(cropJs);
            ImageCrop ic = new ImageCrop();
            var imgByte = ic.Crop(file.InputStream, cropKoord.x.ToInt(), cropKoord.y.ToInt(), cropKoord.width.ToInt(), cropKoord.height.ToInt());
            var imageData = "data:image/jpeg;base64," + Convert.ToBase64String(imgByte);
            return Json(imageData);
        }
    }
}
