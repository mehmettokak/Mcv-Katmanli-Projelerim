using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class ServiceModel
    {
        public ServiceViewModel ServisModel { get; set; }
        public List<ServiceViewModel> CategoryListModel { get; set; }
        public List<ServiceViewModel> SubCategoryListModel { get; set; }
    }
}