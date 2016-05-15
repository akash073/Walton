using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public class WsmsQuizDbContext :DbContext
    {
        public WsmsQuizDbContext()
            : base("WsmsQuizDbContext")
        {
        }
        
        public virtual DbSet<QuizAdmin> QuizAdmins { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
       // public virtual DbSet<QuizSecurityQuestion> QuizSecurityQuestions { get; set; }
        public virtual DbSet<QuizSession> QuizSessions { get; set; }
        public virtual DbSet<QuizSessionUser> QuizSessionUsers { get; set; }
        public virtual DbSet<QuizSessionUserAnswer> QuizSessionUserAnswers { get; set; }
        public virtual DbSet<QuizType> QuizTypes { get; set; }
    }
}