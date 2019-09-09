using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace partyInvites.Models
{

    //We use annotations on the Models to help with binding the Razor at the front of tha pplication 
    public class GuestResponse
    {
        [Display(Name = "Your Name:") ]
        [Required(ErrorMessage = "Your Name is Mandatory")]
        public string Name { get; set; }

        [Display(Name = "Your Email:")]
        [Required(ErrorMessage = "Your Email address  is Mandatory")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Your Phone:")]
        [RegularExpression("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}", ErrorMessage ="Invalid Phone Number ")]
        [Required(ErrorMessage = "Your Phone Number   is Mandatory")]
        public string Phone { get; set; }

        [Display(Name = "Will You Attend ? :")]
        [Required(ErrorMessage = "Kindly Choose a selection")]
        public bool? willAtted { get; set; }
    }
}