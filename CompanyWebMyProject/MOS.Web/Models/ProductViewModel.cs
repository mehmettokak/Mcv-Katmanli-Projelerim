using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ContentType { get; set; }
        public DateTime? DateTime { get; set; }

     



    }
}