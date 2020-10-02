using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gym_Service.Models
{
    public class LoginDetails
    {
        public int UserID { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}