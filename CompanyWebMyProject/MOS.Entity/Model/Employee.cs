using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class Employee
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

        public int RowNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<EmployeeLang> EmployeeLangs { get; set; }
        public virtual ICollection<SocialLink> SocialLinks { get; set; }

    }
}
