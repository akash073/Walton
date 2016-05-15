using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizType
    {
        public QuizType()
        {
            this.QuizSessions = new HashSet<QuizSession>();
        }

        public long QuizTypeID { get; set; }
        public string QuizTypeName { get; set; }

        public virtual ICollection<QuizSession> QuizSessions { get; set; }
    }
}