using Customer.Models.Classes;
using Customer.Models.Classes.About;
using Customer.Models.Classes.Contact;
using Customer.Models.Classes.Footer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Models
{
    public class LayoutViewModel
    {
        public SliderModel SliderModel { get; set; }
        public List<NavigationModel> NavigationListModel { get; set; }
        public List<WorksModel> WorksListModel { get; set; }
        public List<SkillsModel> SkillsListModel { get; set; }
        public List<EmployeesModel> EmployeesListModel { get; set; }
        public ContactModel ContactFooterModel { get; set; }
        public List<SocialModel> SocialListModel { get; set; }
    }
    public class IndexViewModel
    {
        public SliderModel SliderModel { get; set; }
        public List<NewsLetterModel> NewLetterModel { get; set; }
        
    }
    public class AboutViewModel
    {
        public SliderModel AboutSliderModel { get; set; }
        public AboutModel AboutContentModel { get; set; }
    }
    public class ContactViewModel
    {
        public SliderModel ContactSliderModel { get; set; }
        public ContactModel ContactContentModel { get; set; }
        
    }
}