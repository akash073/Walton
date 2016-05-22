using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspUpdateAjax.Models
{
    public class QuestionViewModel
    {
        public long SessionID { get; set; }
        public String SessionName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int SessionType { get; set; }
        [Required(ErrorMessage = "Please Enter question Name")]
        public string QuestionName { get; set; }
        public int QuestionOption { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public int CorrectAnswer { get; set; }
    }
}