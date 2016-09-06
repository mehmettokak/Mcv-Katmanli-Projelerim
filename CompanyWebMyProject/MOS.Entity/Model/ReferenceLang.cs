using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
    public class ReferenceLang
    {
        public int Id { get; set; }
        public int ReferenceId { get; set; }
        [StringLength(50)]
        public string LogoName { get; set; }

        [StringLength(600)]
        public string Testimonial { get; set; }
        public int LanguageId { get; set; }
        public virtual Reference Reference { get; set; }
        public virtual Language Language { get; set; }
    }
}
