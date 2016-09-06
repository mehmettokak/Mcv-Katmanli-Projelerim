﻿using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public int? CategoryType { get; set; }
        public int MainId { get; set; }
        public int RowNumber { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int ContentType { get; set; }
        public bool IsActive { get; set; }
        public bool IsMenuActive { get; set; }
        public bool IsMainActive { get; set; }
        public ICollection<CategoryLang> CategoryLang { get; set; }

        public ICollection<ServiceViewModel> Categories { get; set; }
    }
}