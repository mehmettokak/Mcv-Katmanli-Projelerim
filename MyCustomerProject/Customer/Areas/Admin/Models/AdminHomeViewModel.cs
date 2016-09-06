using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Customer.Models.Classes;
using Customer.Models.Classes.About;
using Customer.Models.Classes.Footer;
namespace Customer.Areas.Admin.Models
{
    public class AdminHomeViewModel
    {
       
        public SliderModel adminSliderModel { get; set; }
        public List<WorksModel> adminWorksListModel { get; set; }
        public WorksModel adminWorkModel { get; set; }
        public EmployeesModel adminEmployeesModel { get; set; }
        public SkillsModel adminSkillsModel { get; set; }
        public AboutModel adminAboutModel { get; set; }
        public SocialModel adminSocialModel { get; set; }
    }
}