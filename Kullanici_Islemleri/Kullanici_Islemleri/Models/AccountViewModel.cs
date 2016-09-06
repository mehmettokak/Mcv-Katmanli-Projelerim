using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kullanici_Islemleri.Models
{

    #region Giris Sayfasi Modeli
    public class LoginViewModel
        {
            [Display(Name = "Email adresini Giriniz?")] //iekranda gozukmesını ıstediğimiz yazıdır.
            [Required(ErrorMessage = "Email Adresi Girilmesi Zorunludur.")] //Kullanıcı email kısmını bos bırakırsa bu uyarı ıle karsılasacak. 
            [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]//Girilen email adresi düzensiz yapıda ise hata verir.
            public string eMail { get; set; }

            [Display(Name = "Şifrenizi Giriniz?")]
            [Required(ErrorMessage = "Sifre Girilmesi Zorunludur?")]
            public string password { get; set; }

            [Display(Name = "Beni Hatırla")]
            public bool beniHatirla { get; set; }  
    }
    #endregion

    #region Sifremi Unuttum Sayfa Modeli
    public class RegisterViewModel
        {
            [Display(Name = "Email")]
            [Required(ErrorMessage = "Email adresinizi giriniz!")]
            [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz!")]
            public string email { get; set; }
        }
    #endregion

    #region Sifre Yenile Sayfa Modeli
    public class ActivationViewModel
        {
            public int UserId { get; set; }
            public string ActivationKey { get; set; }

            [Display(Name = "Parola")]
            [Required(ErrorMessage = "Parolanızı giriniz!")]
            public string Password { get; set; }

            [Display(Name = "Parola Tekrarı")]
            [Required(ErrorMessage = "Parolanızı giriniz!")]
            public string RePassword { get; set; }
        }
#endregion
}