using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class CategoryLang
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        public string Description { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
