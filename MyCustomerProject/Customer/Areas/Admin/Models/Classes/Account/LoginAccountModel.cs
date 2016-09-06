using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Models.Classes.Account
{
    public class LoginAccountModel
    {

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Adresi Girilmesi Zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]
        public string EMail { get; set; }

        [Display(Name = "Şifrenizi Giriniz?")]
        [Required(ErrorMessage = "Sifre Girilmesi Zorunludur?")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool BeniHatirla { get; set; } 
    }
}