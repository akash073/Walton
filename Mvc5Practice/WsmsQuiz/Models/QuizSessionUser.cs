//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WsmsQuiz.Models
{
    using System;
    using System.Collections.Generic;
    
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
