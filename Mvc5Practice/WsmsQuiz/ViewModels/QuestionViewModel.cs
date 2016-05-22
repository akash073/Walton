using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class QuestionViewModel
    {
        public string QuestionName { get; set; }
        public List<int> QuestionOption { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public int CorrectAnswer { get; set; }
    }
}