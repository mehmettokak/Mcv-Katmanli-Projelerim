using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kullanici_Islemleri.Models;
using System.Web.Security;
using BAL.Provider;
using BAL.Tools;
namespace Kullanici_Islemleri.Controllers
{
    public class AccountController : Controller
    {
        UserProvider _up = new UserProvider();
     
        #region Giris Islemleri
        [AllowAnonymous]//herkese açık,
        [HttpGet, OutputCache(NoStore = true, Duration = 0)] 
        //Formu HttpGet ile kullanıcıya gondererek goster,her kullanıcıya önbellek ismi (client bazlı olarak ) belirlensin ,0 sn onbellekte dursun.OutputCacheyle girilen bilgi önbellekte saklanır.
        public ActionResult Login()
        {
            //if (HttpContext.Request.IsAuthenticated) { return Redirect("/"); }		// Kullanıcı giriş yapmışsa ana sayfaya yönlendir
            if (Session["ActivationError"] != null)//burası register sifre olayı ıcın activasyon error null degılse null yapar.
            {
                ModelState.AddModelError("", Session["ActivationError"].ToString());
                Session["ActivationError"] = null;
            }
            return View(new LoginViewModel());
        }
        
        [HttpPost]//Formdan bilgi gelecek
        [AllowAnonymous]//herkese acık
        [ValidateAntiForgeryToken]//formdan gelen tokenle karsılastırma yapar.Aynı degılse metoda girmez.
        public  ActionResult Login(LoginViewModel model)
        {
            //if (HttpContext.Request.IsAuthenticated) { FormsAuthentication.SignOut(); }
            if (ModelState.IsValid)//Formdan gelen Model de eksiklik veya  hatalı degilse
            {//entity modelimdeki user bilgilerinini çagırıp,formdan gelen modelle karsılastırma yapıcaz.
                //Formdan gelen modelden once mail konrolu yapılaca.Boyle bır maıl varmı yokmu dıye sonra sıfre kontrolu yapılacak
              
                var _model = _up.getUser(model.eMail);
                if (_model!=null) //model bos degilse boyle bir email adresi var ise
                {
                    _model = _up.getUser(_model.id,MD5Crypto.Convert( model.password));//id yi entityden gonderdik.formdan gelen modelden tanımlaya gerek yok.zaten boyle ıd ve password varsa dogru gırılmısıtır demektır.
                    if (_model!=null) //Paswword bilgisi db de var ise 
                    {
                        //Girilen email ve sifre dogrulandıktan sonra email ve hatırla benı cookie de tutacaz.
                        FormsAuthentication.SetAuthCookie(_model.email, model.beniHatirla);
                        //Bunun yanında kullanıcı id ve giris yapıldıgını da sessıon da tutacaz.
                        Session["Kullanici_Id"] = _model.id;//Bütün olaylar kullanıcı ıd uzerınden dondugu ıcın bunu session da tutuyoruz.
                        Session["Giris_Yapildi"] = true;
                        return RedirectToAction("Index", "Admin/Home");

                    }
                    else
                    {
                        ModelState.AddModelError("", "Parola geçerli değil!");//_model null(sifre) geliyorsa bu hata doner.Hata mesajı login viewda tanımlanan validation sumary de gozukecektir.
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı geçerli değil!");//Mail adresi null gellirse bu hata doner
                }
                
            }
            return View();
        }
#endregion

        #region Cikis Islemleri
        public ActionResult LogOff()
        {
            if (HttpContext.Request.IsAuthenticated) { FormsAuthentication.SignOut(); }
            return Redirect("Login");
        }
        #endregion

        #region Sifremi Unuttum-Aktivasyon Linki Gonderme
        public ActionResult RegisterPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterPassword(RegisterViewModel model)
        {
          
            var _user = _up.getUser(model.email);//email e ait kullanıcı bılgılerını getirdik
            if (_user !=null)//mail dogruysa
            {//Activasyon code uretip kullanıcıya maiil atılacak.
                _user.activasyonkey = Guid.NewGuid().ToString();//activasyon ıcın guid deger urettik.
                _user.activasyondate = DateTime.Now;//activasyon tarhini aldık.bu tarih sfre yenıleme yaptıgı zaman 24 saat gecip gecmeme kontrolu ıcın tutlyor.
                //key ve activasyon kodunu dbmize kaydedicez.
                var dbResult = _up.setUser(_user);
                if (dbResult > 0)//db kayıt guncelleme basarılıysa
                {//Mail Gönderme işlemi yapılacak.
                    var _mp = new MailProvider();
                    string mailResult = _mp.SendActivationCode(_user.activasyonkey, _user.email);
                    if (!string.IsNullOrEmpty(mailResult))//mailda hata olustumu 0 degeri dondursun dedık.0 degeri allırsa bos degıldır hata vardır  demektir.
                    {
                        ViewBag.Error = mailResult;
                    }
                    else
                    {

                        TempData["MailMessages"] = "<span style='color: green; '>Mail Adresinize Activasyon linki Gönderilmiştir.Gönderilen linki tıklayarak şifrenizi güncelleyebilirsiniz.</span>";
                        return RedirectToAction("RegisterPassword");//her sey yolundaysa sifre sifare olusturması ıcın sayfaya yonlendırılır.
                    }
                }
            }
            else
            {
                ModelState.AddModelError("","Girmiş olduğunuz mail adresi kayıtlarımızda bulunmamaktadır.");
            }
            return View();
        }
        #endregion

        #region AktivasyonKey'e Gore Sifre yenileme Islemleri
        [HttpGet]//dısardan gelen aktivasyon kodunu yakalar
        public ActionResult ActivasyonKey(string id)
        {
           
            var _user = _up.getUserWithActivationKey(id);
            var model = new ActivationViewModel();
            if (_user != null)
            {
                var startime = (DateTime)_user.activasyondate;
                var totalhour = (int)(DateTime.Now - startime).TotalHours;
                if (totalhour >= 24)//kullanıcıya gonderılen aktivasyon linki 24 saati gecmiş ise sifre yenile işlemi yapılmaz.
                {
                    TempData["Error"] = "Aktivasyon kodu 24 saati geçtiği için geçersiz duruma getirilmiştir. Yeni aktivasyon kodu alınız.";
                }
                else
                {
                    model.ActivationKey = _user.activasyonkey;
                    model.UserId = _user.id;
                    model.Password = "";//burada sıfre ve tekrar sıfre bos olacak.kulanıcı dolduracak burayı
                    model.RePassword = "";
                }
            }
            else
            {
                TempData["Error"] = "Geçersiz aktivasyon kodu.";
            }

            return View(model);
        }

        [HttpPost] //Formdan Gelen modeli alır.
        public ActionResult ActivasyonKey(ActivationViewModel model)
        {
            if (model.Password != model.RePassword)
            {
                TempData["ActivationError"] = "Parola tekrarı hatalı.Lütfen mail adresinize gönderilen aktivasyon kodunu tekra tıklayarak sifrenizi güncelleyiniz?";
                return RedirectToAction("ActivasyonKey", new { @id = model.ActivationKey });//şifre yanlış gırılırse aktivasyon kodu parametre olarak view e gonderilir.ki tekra yakalasın aktivasyon kodunu
            }

            //şifre yenileme işlemi başarılı oldugu taktirde sifre cryptolanarak ve aktivasyonkey silinip dbye kaydedılır.
            var _user = _up.GetWithId(model.UserId);
            _user.password = MD5Crypto.Convert(model.Password);
            _user.activasyondate = DateTime.Now;
            _user.activasyonkey = "";
            _up.setUser(_user);
           
            return RedirectToAction("Login");
        }
        #endregion
    }
      
}