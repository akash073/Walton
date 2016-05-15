using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizQuestion
    {
        public QuizQuestion()
        {
            this.QuizSessionUserAnswers = new HashSet<QuizSessionUserAnswer>();
        }

        public long QuizQuestionID { get; set; }
        public long QuizSessionID { get; set; }
        public string QuizQuestionName { get; set; }
        public int NoOfAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public bool HasAnswer { get; set; }
        public int CorrectAnswer { get; set; }

        public virtual QuizSession QuizSession { get; set; }
        public virtual QuizType QuizType { get; set; }
        public virtual ICollection<QuizSessionUserAnswer> QuizSessionUserAnswers { get; set; }
    }
}