using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class SliderViewModel
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        
    }
}