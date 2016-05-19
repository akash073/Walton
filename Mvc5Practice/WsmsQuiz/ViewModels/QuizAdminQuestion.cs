using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class QuizAdminQuestion
    {
        public long QuizAdminQuestionID { get; set; }
        public string QuizQuestionName { get; set; }
        public int NoOfAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public bool HasAnswer { get; set; }
        public int CorrectAnswer { get; set; }
        public Boolean IsActive { get; set; }
    }
}