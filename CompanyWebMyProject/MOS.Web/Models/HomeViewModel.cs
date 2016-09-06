using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class HomeViewModel
    {
        public List<SliderViewModel> SliderListModel { get; set; }
        public List<ReferenceViewModel> ReferenceListModel { get; set; }
        public PageViewModel AboutModel { get; set; }
        public Contact ContactModel { get; set; }
        public CompanyViewModel CompanyModel { get; set; }
        public List<ServiceViewModel> ServiceListModel { get; set; }
        public List<EmployeeViewModel> EmployeeListModel { get; set; }
        public List<BlogViewModel> BlogListModel { get; set; }
    }
}