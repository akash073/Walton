using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ClientModel
    {
        [Range(1, Int32.MaxValue)]
        public int NumberofClient { get; set; }
    }
}