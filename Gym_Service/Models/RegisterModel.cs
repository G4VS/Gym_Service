using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gym_Service.Models
{
    public class RegisterModel
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string ContactNumber { get; set; }

        public string RegisterError { get; set; }
    }
}