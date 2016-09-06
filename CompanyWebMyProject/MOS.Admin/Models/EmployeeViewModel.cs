using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(200)]
        public string AvatarURL { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(11)]
        public string MobilePhone { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(240)]
        public string Description { get; set; }
        public string Content { get; set; }

        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
    }
}