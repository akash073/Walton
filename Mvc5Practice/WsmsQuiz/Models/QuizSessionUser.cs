using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizSessionUser
    {
        public QuizSessionUser()
        {
            this.QuizSessionUserAnswers = new HashSet<QuizSessionUserAnswer>();
        }

        public long QuizSessionUserID { get; set; }
        public long QuizSessionID { get; set; }
        public bool IsMobileCrmUser { get; set; }
        public int UserID { get; set; }
        public string UserFullName { get; set; }
        public int ServicePointID { get; set; }
        public string ServicePointName { get; set; }
        public string EmployeeCode { get; set; }
        public int UserAnswer { get; set; }

        public virtual QuizSession QuizSession { get; set; }
        public virtual ICollection<QuizSessionUserAnswer> QuizSessionUserAnswers { get; set; }
    }
}