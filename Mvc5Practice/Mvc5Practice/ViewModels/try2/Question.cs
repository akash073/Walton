using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Practice.ViewModels.try2
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionString { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
        public int SelectedAnswerId { get; set; }
    }
}