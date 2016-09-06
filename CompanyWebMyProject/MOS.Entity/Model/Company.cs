using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Entity.Model
{
  public  class Company
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string EMail { get; set; }

        [StringLength(11)]
        public string Phone1 { get; set; }

        [StringLength(11)]
        public string Phone2 { get; set; }


        [StringLength(11)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string FacebookUrl { get; set; }

        [StringLength(200)]
        public string TwitterUrl { get; set; }

        [StringLength(200)]
        public string LinkedinUrl { get; set; }
        public virtual ICollection< CompanyLang> CompanyLangs { get; set; }
    }
}
