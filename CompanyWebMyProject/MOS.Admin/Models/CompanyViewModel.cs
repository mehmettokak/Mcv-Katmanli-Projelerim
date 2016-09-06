using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Adress { get; set; }

        [StringLength(60)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string Copyright { get; set; }

        [StringLength(11)]
        public string Phone1 { get; set; }

        [StringLength(11)]
        public string Phone2 { get; set; }

        [StringLength(11)]
        public string Phone3 { get; set; }

        [StringLength(200)]
        public string FacebookUrl { get; set; }

        [StringLength(200)]
        public string TwitterUrl { get; set; }

        [StringLength(200)]
        public string LinkedinUrl { get; set; }
    }
}