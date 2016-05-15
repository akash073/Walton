using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc5Practice.ViewModels.QuestionAnswer
{
    public class QuestionVM
    {
        public int ID { get; set; } // for binding
        public string Text { get; set; }
        [Required]
        public int? SelectedAnswer { get; set; } // for binding
        public IEnumerable<AnswerVM> PossibleAnswers { get; set; }
    }
}