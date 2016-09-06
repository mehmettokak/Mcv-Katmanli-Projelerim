using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes.Contact
{
    public class ContactModel
    {
        #region About View Model
      
            [Display(Name = "Id")]
            public int Id { get; set; }

            [Display(Name = "Harita Resmi")]
            public string MapImage { get; set; }
            [Display(Name = "Logo Resmi")]
            public string LogoImage { get; set; }

            [Display(Name = "Harita Başlik")]
            [MaxLength(50)]
            public string MapTitle { get; set; }

            [Display(Name = "Mail Adress")]
            [Required(ErrorMessage = "Doldurulması Zorunlu Alandır.")]
            [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]
            [MaxLength(50)]
            public string MailAdress { get; set; }

            [Display(Name = "Adres")]
            public string Adress { get; set; }

            [Display(Name = "Telefon1")]
            [MaxLength(11)]
            public string Telephone1 { get; set; }

            [Display(Name = "Telefon2")]
            [MaxLength(11)]
            public string Telephone2 { get; set; }

            [Display(Name = "Telefon3")]
            [MaxLength(11)]
            public string Telephone3 { get; set; }

            [Display(Name = "Durum")]
            public bool Status { get; set; }



       
        #endregion
    }
}