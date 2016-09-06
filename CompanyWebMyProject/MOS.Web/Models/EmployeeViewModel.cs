using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Web.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SocialLink> SocialLinks { get; set; }
        public IQueryable <Employee> Employees { get; set; }
    }
}