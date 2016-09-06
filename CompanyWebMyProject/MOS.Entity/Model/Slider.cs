using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<SliderLang> SliderLangs { get; set; }
    }
}