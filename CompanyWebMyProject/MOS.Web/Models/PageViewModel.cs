using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class PageViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
    }
}