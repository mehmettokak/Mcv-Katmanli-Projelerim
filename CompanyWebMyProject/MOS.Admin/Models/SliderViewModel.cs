using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Admin.Models
{
    public class SliderViewModel
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Title { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        public int RowNumber { get; set; }
        public bool IsActive { get; set; }
    }
}