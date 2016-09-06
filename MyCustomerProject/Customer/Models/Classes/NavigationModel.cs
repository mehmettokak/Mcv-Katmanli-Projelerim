using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes
{
    #region Navigation View Model
    public class NavigationModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Doldurulması Zorunlu Alandır.")]
        public string Name { get; set; }

        [Display(Name = "Order")]
        public string Order { get; set; }
        [Display(Name = "Url")]
        public string Url { get; set; }
    }
    #endregion
} 