using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Niagara_Hospice.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "a First Name is required")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "a Last Name is required")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "a Phone Number is required")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "an Address is required")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "a City is required")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string City { get; set; }

        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string Status { get; set; }
    }
}