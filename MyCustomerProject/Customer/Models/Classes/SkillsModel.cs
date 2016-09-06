using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes
{
    #region Skills View Model
    public class SkillsModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Başlık")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1}, en az {2} karakter uzunluğunda olmalıdır!", MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Açiklama")]
        public string Description { get; set; }

        [Display(Name = "İkon")]
        public string IconName { get; set; }

        [Display(Name = "Sıralama")]
        public string Order { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

    }
    #endregion
}