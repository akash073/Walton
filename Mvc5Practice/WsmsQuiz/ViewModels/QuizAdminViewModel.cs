using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class QuizAdminViewModel
    {
        public long QuizAdminID { get; set; }
        public long QuizTypeID { get; set; }
        public string QuizTypeName { get; set; }
        public long QuizSessionID { get; set; }
        public string QuizSessionName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public List<QuizAdminQuestion> QuizAdminQuestions { get; set; } 
    }
}