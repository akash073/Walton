using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class Question
    {

        public long QuizQuestionID { get; set; }
        public string QuizQuestionName { get; set; }
        public List<Answer> Answers { get; set; }
        [Required(ErrorMessage = "Select All the answers ")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int UserSelectedAnswer { get; set; }
    }
}