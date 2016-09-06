using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes
{
    #region Slider View Model
    public class SliderModel
    {
        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Dosya Adı")]
        public string filePath { get; set; }

        [Display(Name = "Resim Açiklama")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1}, en az {2} karakter uzunluğunda olmalıdır!", MinimumLength = 3)]
        public string imageDescription { get; set; }

        [Display(Name = "Resim Durumu")]
        public bool imageStatus { get; set; }


        [Display(Name = "Video Adı")]
        public string VideoUrl { get; set; }
        [Display(Name = "Video Durumu")]
        public bool StatusViedo { get; set; }



       
    }
    #endregion
}