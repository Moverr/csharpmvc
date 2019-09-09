using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace partyInvites.Models
{
    public class GuestResponse
    {
        [Display(Name = "Your Name:")]
        public string Name { get; set; }

        [Display(Name = "Your Email:")]
        public string Email { get; set; }

        [Display(Name = "Your Phone:")]
        public string Phone { get; set; }

        [Display(Name = "Will You Attend ? :")]
        public bool? willAtted { get; set; }
    }
}