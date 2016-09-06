using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}