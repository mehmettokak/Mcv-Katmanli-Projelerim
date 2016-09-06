using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class SliderLang
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Title { get; set; }
        public int SliderId { get; set; }
        public virtual Slider Slider { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}