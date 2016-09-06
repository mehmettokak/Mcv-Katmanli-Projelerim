using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Models.Classes.Account
{
    public class UserModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Girilmesi Zorunludur.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tarihi")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Adresi Girilmesi Zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]
        public string Email { get; set; }

        [Display(Name = "AktivasyonLink")]
        public string ActivationKey { get; set; }

        [Display(Name = "Aktivasyon Tarihi")]
        public DateTime ActivationDate { get; set; }
    }
}