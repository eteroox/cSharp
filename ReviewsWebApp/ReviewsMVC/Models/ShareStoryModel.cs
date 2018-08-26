using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewsMVC.Models
{
    public class ShareStoryModel
    {
        [Required(ErrorMessage = "Field is required")]
        [StringLength(30, ErrorMessage="Maximum number of characters is 30.")]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(100, ErrorMessage = "Maximum number of characters is 100.")]
        [Display(Name = "Name of kickstarter campaign you suported")]
        public string KickStarterCampaign { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(30, ErrorMessage = "Maximum number of characters is 30.")]
        [Display(Name = "Order date")]
        public string OrderDate { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Maximum number of characters is 20.")]
        [Display(Name = "Pledged amount")]
        public string PledgedAmount { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Maximum number of characters is 20.")]
        [Display(Name = "Order number (If it is visible else write none)")]
        public string OrderNumber { get; set; }

        [Required]
        [Display(Name = "Order Screenshot from kickstarter (jpg, jpeg or png format), max. size 5MB ")]
        public HttpPostedFileBase Images { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Field is required!")]
        [Display(Name = "Tell us your Story")]
        public string YourStory { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Maximum number of characters is 20.")]
        [Display(Name = "Backer Number")]
        public string BackedNumber { get; set; }
    }
}