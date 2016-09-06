using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes
{
   
    #region News Letter View Model
    public class NewsLetterModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Adresi Girilmesi Zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]
        public string Email { get; set; }

        [Display(Name = "Tarih")]
        public DateTime CreateTime { get; set; }

  
    }
    #endregion
}