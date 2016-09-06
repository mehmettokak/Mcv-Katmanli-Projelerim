using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes.Footer
{
    public class SocialModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Sosyal İletişim Adresi")]
        public string SocialUrl { get; set; }

        [Display(Name = "Sosyal İletişim Adı")]
        public string SocialName { get; set; }

        [Display(Name = "Sıralama")]
        public string Order { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }
    }
}