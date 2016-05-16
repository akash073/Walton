using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WsmsQuiz.Models;

namespace WsmsQuiz.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public long QuizSessionID { get; set; }
        public string QuizSessionName { get; set; }
      //  public long QuizQuestionID { get; set; }
       // public string QuizQuestionName { get; set; }
        public long QuizTypeID { get; set; }
        public string QuizTypeName { get; set; }
        public int UserID { get; set; }
        public Boolean IsMobileCrmUser { get; set; }
        public List<Question> GeneralQuestions { get; set; }

    }
}