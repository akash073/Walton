using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class QuestionAnswerVm
    {
        //[Required(ErrorMessage = "Are you really trying to login without entering username?")]
        [DisplayName("QuestionName")]
        public string QuestionName { get; set; }


        [Required(ErrorMessage = "Please enter one Answer:)")]
        [DisplayName("Answer")]
        public string Answer { get; set; }


        //[DisplayName("Stay logged in when browser is closed")]
        //public bool RememberMe { get; set; }
    }
}