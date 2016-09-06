using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes.About
{
    public class AboutModel
    {

        [Display(Name = "Id")]
       
        public int Id { get; set; }

        [Display(Name = "Slayt Resmi")]
        public string FilePath { get; set; }

        [Display(Name = "Slayt Başlığı")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Display(Name = "Acıklama")]

        public string Description { get; set; }
        [Display(Name = "Durum")]
        public bool Status { get; set; }
        [Display(Name = "Video Adı")]
        public string VideoUrl { get; set; }
        [Display(Name = "Video Durumu")]
        public bool StatusViedo { get; set; }

       
    }
}