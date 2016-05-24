using System;
using System.ComponentModel.DataAnnotations;

namespace WsmsQuiz.ViewModels
{
    public class QuestionViewModel
    {
        public long SessionID { get; set; }
        public String SessionName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please selec a type")]
        public int SessionType { get; set; }
        [Required(ErrorMessage = "Select Start Date")]
        public System.DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Select End Date")]
        public System.DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Please Enter question Name")]
        public string QuestionName { get; set; }
        public int QuestionOption { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public int CorrectAnswer { get; set; }
    }
}