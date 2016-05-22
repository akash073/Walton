using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspUpdateAjax.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "UserName")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        [MaxLength(50)]
        public string Password { get; set; }
    } 
}