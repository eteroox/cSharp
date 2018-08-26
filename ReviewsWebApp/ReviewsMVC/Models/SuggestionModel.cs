using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewsMVC.Models
{
    public class SuggestionModel
    {
        [Required]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Name of kickstarter campaign you suported")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Order date")]
        public string OrderDate { get; set; }
    }
}