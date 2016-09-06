using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
   public class CompanyLang
    {
        
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [StringLength(100)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Copyright { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public virtual Company Company { get; set; }
    }
}
