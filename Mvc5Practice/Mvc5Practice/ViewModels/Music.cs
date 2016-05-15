using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Practice.ViewModels
{
    public class Music
    {
        [Required]
        public int Music_Id { get; set; }

        [Required]
        public string Song_Name { get; set; }
        [Required]
        public string Music_Director { get; set; }
    }
}