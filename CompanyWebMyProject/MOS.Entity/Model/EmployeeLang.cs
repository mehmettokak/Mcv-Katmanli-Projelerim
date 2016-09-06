using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
  public  class EmployeeLang
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(240)]
        public string Description { get; set; }
        public string Content { get; set; }
        public int LanguageId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Language Language { get; set; }
    }
}
