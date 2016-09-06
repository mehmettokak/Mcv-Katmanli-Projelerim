using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class Language
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string IconURL { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<EmployeeLang> EmployeeLangs { get; set; }
        public virtual ICollection<CategoryLang> CategoryLangs { get; set; }
        public virtual ICollection<SliderLang> SliderLangs { get; set; }
        public virtual ICollection<ReferenceLang> ReferenceLangs { get; set; }
        public virtual ICollection<CompanyLang> CompanyLangs { get; set; }
        public virtual ICollection<PageLang> PageLangs { get; set; }
      
    }
}
