using System.ComponentModel.DataAnnotations;

namespace Mvc5Practice.Models
{
    public class QuizAdminViewModel
    {
        [Key]
        public long ID { get; set; }
        public long QuizAdminID { get; set; }
        public long QuizTypeID { get; set; }
        public string QuizTypeName { get; set; }
        public long QuizSessionID { get; set; }
        public string QuizSessionName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string QuizQuestionName { get; set; }
        public int NoOfAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public bool HasAnswer { get; set; }
        public int CorrectAnswer { get; set; }
    }
}