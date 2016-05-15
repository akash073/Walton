using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc5Practice.ViewModels.QuestionAnswer
{
    public class SubjectVM
    {
        public int? ID { get; set; }
        [DisplayFormat(NullDisplayText = "General")]
        public string Name { get; set; }
        public List<QuestionVM> Questions { get; set; }
    }
}