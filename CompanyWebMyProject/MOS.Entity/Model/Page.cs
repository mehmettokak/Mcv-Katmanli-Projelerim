using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
    public class Page
    {
        public int Id { get; set; }
        public bool Isactive { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        public virtual ICollection< PageLang> PageLangs { get; set; }
    }
}
