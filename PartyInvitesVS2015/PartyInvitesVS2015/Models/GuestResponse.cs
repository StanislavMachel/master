using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitesVS2015.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please insert your name")] // show that this property must be set
        public string Name { get; set; }
        [Required(ErrorMessage = "Please insert your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please insert your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please select one answer from the choices provided")]
        public bool? WillAttend { get; set; }

    }
}