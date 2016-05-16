using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class Question
    {

        public long QuizQuestionID { get; set; }
        public string QuizQuestionName { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}