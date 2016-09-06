using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes
{
    #region Employees View Model
    public class EmployeesModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1}, en az {2} karakter uzunluğunda olmalıdır!", MinimumLength = 3)]

        public string Name{ get; set; }

        [Display(Name = "Soyİsim")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1}, en az {2} karakter uzunluğunda olmalıdır!", MinimumLength = 3)]

        public string SurName { get; set; }

        [Display(Name = "Telefon")]
        [StringLength(11, ErrorMessage = "{0} alanı en fazla {1}, en az {2} karakter uzunluğunda olmalıdır!", MinimumLength = 10)]

        public string Telephone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Doldurulması Zorunlu Alandır.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz?")]
        public string Email { get; set; }

        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Display(Name = "Başlık")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Sıralama")]
        public string Order { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

        [Display(Name = "Facebook")]
        public string Facebook { get; set; }

        [Display(Name = "Twitter")]
        public string Twitter { get; set; }

    }
    #endregion
}