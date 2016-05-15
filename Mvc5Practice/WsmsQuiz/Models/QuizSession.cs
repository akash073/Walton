using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizSession
    {
        public QuizSession()
        {
            this.QuizQuestions = new HashSet<QuizQuestion>();
            this.QuizSessionUsers = new HashSet<QuizSessionUser>();
        }

        public long QuizSessionID { get; set; }
        public long QuizAdminID { get; set; }
        public string QuizSessionName { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Purpose { get; set; }
        public long QuizTypeID { get; set; }

        public virtual QuizAdmin QuizAdmin { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual QuizType QuizType { get; set; }
        public virtual ICollection<QuizSessionUser> QuizSessionUsers { get; set; }
    }
}