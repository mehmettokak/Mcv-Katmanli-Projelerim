using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class ReferenceViewModel
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string LogoName { get; set; }
        public string Testimonial { get; set; }
        public string WebURL { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsTestimonial { get; set; }
    }
}