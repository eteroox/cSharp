using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewsMVC.Models
{
    public class ContactClass
    {
        [Required(ErrorMessage = "Field is required")]
        [StringLength(255, ErrorMessage = "Maximum number of characters is 255.")]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(50, ErrorMessage = "Maximum number of characters is 50.")]
        [Display(Name = "Your Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Minimum number of characters is 10")]
        [Display(Name = "Your issue or suggestion")]
        public string Issue { get; set; }
    }
}