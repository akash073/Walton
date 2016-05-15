using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public partial class QuizAdmin
    {
        public QuizAdmin()
        {
            this.QuizSessions = new HashSet<QuizSession>();
        }

        public long QuizAdminID { get; set; }
        public string AdminName { get; set; }
        public string EmpId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int AddedBy { get; set; }
        public System.DateTime AddedDate { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }

        public virtual ICollection<QuizSession> QuizSessions { get; set; }
    }
}