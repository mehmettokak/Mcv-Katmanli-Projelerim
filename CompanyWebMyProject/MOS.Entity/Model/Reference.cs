using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
    public class Reference
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string ImageURL { get; set; }

        [StringLength(200)]
        public string WebURL { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsTestimonial { get; set; }
        public virtual ICollection<ReferenceLang> ReferenceLangs { get; set; }
    }
}
