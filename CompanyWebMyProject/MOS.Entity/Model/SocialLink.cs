using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class SocialLink
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(400)]
        public string IconURL { get; set; }

        [StringLength(400)]
        public string LinkURL { get; set; }

        public int RowNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
