using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class Question
    {

        public int QuestionId { get; set; }
        public string QuestionString { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
        public int SelectedAnswerId { get; set; }
    }
}