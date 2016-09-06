
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Entity.Model
{
    public class Category
    {
        public int Id { get; set; }
       public int MainId { get; set; }
        public int? CategoryType { get; set; }
        public int RowNumber { get; set; }

        [StringLength(200)]
        public string IconUrl { get; set; }

        public bool IsActive { get; set; }
        public bool IsMenuActive { get; set; }
        public bool IsMainActive { get; set; }
        public int  ContentType { get; set; }
        public virtual ICollection<CategoryLang> CategoryLangs { get; set; }

        public  Category MainCategory { get; set; }
        public virtual ICollection<Category> Categories { get; set; }


    }
}
