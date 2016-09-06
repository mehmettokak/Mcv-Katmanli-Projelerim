using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin.Models
{
    public class ReferenceViewModel
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string LogoName { get; set; }
        [StringLength(600)]
        public string Testimonial { get; set; }
        [StringLength(200)]
        public string ImageURL { get; set; }
        [StringLength(200)]
        public string WebURL { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsTestimonial { get; set; }
    }
}