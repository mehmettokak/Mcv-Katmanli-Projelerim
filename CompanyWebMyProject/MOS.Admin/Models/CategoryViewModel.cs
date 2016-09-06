using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public string Name { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        [StringLength(200)]
        public string IconUrl { get; set; }

        public string Description { get; set; }

        public int LanguageId { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsMenuActive { get; set; }
        public bool IsMainActive { get; set; }
    }
}