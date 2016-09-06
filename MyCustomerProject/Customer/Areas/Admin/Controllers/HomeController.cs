using Customer.Areas.Admin.Models;
using Customer.Areas.Admin.Provider;
using Customer.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Customer.BAL.Tools;
using DAL;
using Customer.Models.Classes.Contact;
using Customer.Models.Classes.About;
using Customer.Models.Classes.Footer;
using System.Configuration;
using System.Net;

namespace Customer.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        #region References
        HomeWorksProvider _hwp = new HomeWorksProvider();
        ImageProcess _ip = new ImageProcess();
        VideoProcess _vp = new VideoProcess();
        HomeSliderProvider _ahp = new HomeSliderProvider();
        HomeEmployeesProvider _hep = new HomeEmployeesProvider();
        HomeSkillsProvider _hsp = new HomeSkillsProvider();
        HomeSubscriptionProvider _hsbp = new HomeSubscriptionProvider();
        HomeContactProvider _hcp = new HomeContactProvider();
        HomeAboutProvider _hap = new HomeAboutProvider();
        HomeSocialProvider _hscp = new HomeSocialProvider();
        #endregion

        public ActionResult Index()
        {
            return View();
        }

        #region Model
        AdminHomeViewModel myModel = new AdminHomeViewModel();
        #endregion

        #region Slider
        public ActionResult Slider()
        {
          var sliderModel= _ahp.GetSliderListModel();

          return View(sliderModel);
        }
       
        public ActionResult SliderDetails(int? id)
        {
            if (id == 0 || id == null)
            {
                string noImage = "/assets/global/img/no_photo.png";

                myModel.adminSliderModel = new SliderModel() { filePath = noImage};
            }
            else
            {
                myModel.adminSliderModel = _ahp.GetSliderModel();
            }
            return View(myModel.adminSliderModel);
        }
        public ActionResult SetSliderDetails(SliderModel model, HttpPostedFileBase file)
        {
            string stateFile = "";
            if (file != null)
            {
                if (file.ContentType.Contains("image"))
                {
                    model.filePath = "/assets/global/file/slider/image/" + Path.GetFileNameWithoutExtension(file.FileName) + Path.GetExtension(file.FileName);
                    stateFile = _ip.Save(file, model.filePath);
                }
                else
                {
                    model.filePath = "/assets/global/file/slider/video/" + Path.GetFileNameWithoutExtension(file.FileName) + Path.GetExtension(file.FileName);
                    stateFile = _vp.Save(file, model.filePath);
                } 
            }
            TempData["err"] = stateFile + "" + _ahp.SetSliderProvider(model);
            return Redirect("Slider");
        }
        public ActionResult RemoveSlider(int id)
        {
            TempData["err"] = _ahp.removeSliderModel(id);
            return RedirectToAction("Slider");
        }
        #endregion

        #region Works
        public ActionResult Works()
        {
            myModel.adminWorksListModel = _hwp.getListWorkModel();
            return View(myModel);
        }

        public ActionResult WorksDetails(int? id)
        {
            if (id == 0 || id == null)
            {
                string noImage = "/assets/global/img/no_photo.png";

                myModel.adminWorkModel = new WorksModel() { ImageUrl = noImage, Order = "0" };
            }
            else
            {
                myModel.adminWorkModel = _hwp.getWorksModel(id);
            }
            return View(myModel.adminWorkModel);
        }

        public ActionResult SetWorksDetails(WorksModel model, HttpPostedFileBase ImageUrl)
        {

            string stateImage = "";
            if (ImageUrl != null)
            {
                model.ImageUrl = "/assets/global/file/work/" + Path.GetFileNameWithoutExtension(ImageUrl.FileName) + Path.GetExtension(ImageUrl.FileName);
                stateImage = _ip.Save(ImageUrl, model.ImageUrl);
            }

            TempData["err"] = stateImage + "" + _hwp.setWorkModel(model);

            return Redirect("Works");
        }
        public ActionResult RemoveWorks(int id)
        {
            TempData["err"] = _hwp.removeWorkModel(id);
            return RedirectToAction("Works");
        }
        #endregion

        #region Employees
        public ActionResult Employees()
        {
            var listModel = new List<EmployeesModel>();
            listModel = _hep.getListEmployesModel();
            return View(listModel);
        }
        public ActionResult EmployeesDetails(int? id)
        {

            if (id == 0 || id == null)
            {
                string noImage = "/assets/global/img/no_photo.png";

                myModel.adminEmployeesModel = new EmployeesModel() { Image = noImage, Order = "0" };
            }
            else
            {
                myModel.adminEmployeesModel = _hep.getEmployeesModel(id);
            }
            return View(myModel.adminEmployeesModel);
        }
        public ActionResult SetEmployeesDetails(EmployeesModel model, HttpPostedFileBase Image)
        {

            string stateImage = "";
            if (Image != null)
            {
                model.Image = "/assets/global/img/employees/" + Path.GetFileNameWithoutExtension(Image.FileName) + Path.GetExtension(Image.FileName);
                stateImage = _ip.Save(Image, model.Image);
            }

            TempData["err"] = stateImage + "" + _hep.setEmployeesModel(model);

            return Redirect("Employees");
        }
        public ActionResult RemoveEmployees(int id)
        {
            TempData["err"] = _hep.removeEmployeesModel(id);
            return RedirectToAction("Employees");
        }
        #endregion

        #region Skills
        public ActionResult Skills()
        {
            var listModel = new List<SkillsModel>();
            listModel = _hsp.getListSkillsModel();
            return View(listModel);
        }
        public ActionResult SkillsDetails(int? id)
        {

            if (id == 0 || id == null)
            {
                string noIcon = "icon-power-off";

                myModel.adminSkillsModel = new SkillsModel() { IconName = noIcon, Order = "0" };
            }
            else
            {
                myModel.adminSkillsModel = _hsp.getSkillsModel(id);
            }
            CUSTOMER_SQLEntities DBE = new CUSTOMER_SQLEntities();
            ViewData["ICON"] = new SelectList(DBE.ICONS.Where(x=>x.icondescription=="skills"), "iconname", "iconname"
    );
            return View(myModel.adminSkillsModel);
        }

        public ActionResult SetSkillsDetails(SkillsModel model)
        {
            TempData["err"] = _hsp.setSkillsModel(model);

            return Redirect("Skills");
        }

        public ActionResult RemoveSkills(int id)
        {
            TempData["err"] = _hsp.removeSkillsModel(id);
            return RedirectToAction("Skills");
        }
        #endregion

        #region Subscription
        public ActionResult Subscriptions()
        {

            var listModel = _hsbp.getListSubscriptionModel();
            return View(listModel);
        }
        public ActionResult RemoveSubscriptions(int id)
        {
            TempData["err"] = _hsbp.RemoveSubscriptionsModel(id);
            return RedirectToAction("Subscriptions");
        }
        #endregion

        #region About
        public ActionResult About()
        {
            var listModel = new List<AboutModel>();
            listModel = _hap.getListAboutModel();
            return View(listModel);
        }
        public ActionResult AboutDetails(int? id)
        {
            
            if (id == 0 || id == null)
            {
                string noImage = "/assets/global/img/no_photo.png";

                myModel.adminAboutModel = new AboutModel() { FilePath = noImage };
            }
            else
            {
                myModel.adminAboutModel = _hap.getAboutModel(id);
            }
            return View(myModel.adminAboutModel);
        }
        public ActionResult SetAboutDetails(AboutModel model, HttpPostedFileBase file, HttpPostedFileBase VideoUrl)
        {
            string stateFile = "";
            if (file != null)
            {
                if (file.ContentType.Contains("image"))
                {
                    model.FilePath = "/assets/global/file/about/image/" + Path.GetFileNameWithoutExtension(file.FileName) + Path.GetExtension(file.FileName);
                    stateFile = _ip.Save(file, model.FilePath);
                }
                else
                {
                    model.FilePath = "/assets/global/file/about/video/" + Path.GetFileNameWithoutExtension(file.FileName) + Path.GetExtension(file.FileName);
                    stateFile = _vp.Save(file, model.FilePath);
                }
            }

            TempData["err"] = stateFile + "" + _hap.setAboutModel(model);

            return Redirect("About");
        }
        public ActionResult RemoveAbout(int id)
        {
            TempData["err"] = _hap.removeAboutModel(id);
            return RedirectToAction("About");
        }
        #endregion

        #region Contact
        public ActionResult Contact()
        {
            var listModel = new List<ContactModel>();
            listModel = _hcp.getListContactModel();
            return View(listModel);
        }
        public ActionResult ContactDetails(int? id)
        {
            ContactModel myModel = null;
            if (id == 0 || id == null)
            {
                string noImage = "/assets/global/img/no_photo.png";

                myModel = new ContactModel() { LogoImage = noImage };
            }
            else
            {
                myModel = _hcp.getContactModel(id);
            }
            return View(myModel);
        }
        public ActionResult SetContactDetails(ContactModel model, HttpPostedFileBase LogoImage)
        {

            string stateImage = "";
            if (LogoImage != null)
            {
                model.LogoImage = "/assets/global/file/contact/" + Path.GetFileNameWithoutExtension(LogoImage.FileName) + Path.GetExtension(LogoImage.FileName);
                stateImage = _ip.Save(LogoImage, model.LogoImage);
            }

            TempData["err"] = stateImage + "" + _hcp.setContactModel(model);

            return Redirect("Contact");
        }
      
        #endregion

        #region Social
        public ActionResult Social()
        {
            var listModel = new List<SocialModel>();
            listModel = _hscp.getListSocialModel();
            return View(listModel);
        }
        public ActionResult SocialDetails(int? id)
        {

            if (id == 0 || id == null)
            {
                string noIcon = "off";

                myModel.adminSocialModel = new SocialModel() { SocialName = noIcon, Order = "0" };
            }
            else
            {
                myModel.adminSocialModel = _hscp.getSocialModel(id);
            }
            CUSTOMER_SQLEntities DBE = new CUSTOMER_SQLEntities();
            ViewData["SOCIAL"] = new SelectList(DBE.ICONS.Where(x => x.icondescription == "socials"), "iconname", "iconname"
    );
            return View(myModel.adminSocialModel);
        }
        public ActionResult SetSocialDetails(SocialModel model)
        {
            TempData["err"] = _hscp.setSocialModel(model);

            return Redirect("Social");
        }
        public ActionResult RemoveSocial(int id)
        {
            TempData["err"] = _hscp.removeSocialModel(id);
            return RedirectToAction("Social");
        }
        #endregion

        #region Crop
        public ActionResult CropImage(
            string imagePath,
            int? cropPointX,
            int? cropPointY,
            int? imageCropWidth,
            int? imageCropHeight)
        {
            if (string.IsNullOrEmpty(imagePath)
                || !cropPointX.HasValue
                || !cropPointY.HasValue
                || !imageCropWidth.HasValue
                || !imageCropHeight.HasValue)
            {
                return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
            }

            byte[] imageBytes = System.IO.File.ReadAllBytes(Server.MapPath(imagePath));
            byte[] croppedImage = CropsProcess.CropImage(imageBytes, cropPointX.Value, cropPointY.Value, imageCropWidth.Value, imageCropHeight.Value);
            string pathfile = "~/assets/global/img/employees/crop/ ";
            string tempFolderName = Server.MapPath(pathfile);
            string fileName = "crop_" + Path.GetFileName(imagePath);//resim adını alır formatı ile beraber
            string photoPath = string.Concat(pathfile, fileName);//croplanmıs resim adı
            try
            {
               ImageProcess.SaveCropFile(croppedImage, Path.Combine(tempFolderName, fileName), photoPath);
            }
            catch (Exception ex)
            {
                //Log an error     
                return new HttpStatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            return Json(new { photoPath = photoPath });
        }

        #endregion

        #region Maps
        public ActionResult Maps()
        {
            
            return View();
        }
        #endregion

    }
      
    }
