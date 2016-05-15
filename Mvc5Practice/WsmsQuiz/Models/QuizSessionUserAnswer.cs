using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizSessionUserAnswer
    {
        public long QuizSessionUserAnswerID { get; set; }
        public long QuizSessionID { get; set; }
        public long QuizQuestionID { get; set; }
        public long QuizSessionUserID { get; set; }
        public Nullable<int> UserAnswer { get; set; }

        public virtual QuizQuestion QuizQuestion { get; set; }
        public virtual QuizSessionUser QuizSessionUser { get; set; }
    }
}