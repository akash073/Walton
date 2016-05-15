using System.Collections.Generic;

namespace Mvc5Practice.ViewModels.QuestionAnswer
{
    public class StudentVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        // plus any other properties of student that you want to display in the view
        public List<SubjectVM> Subjects { get; set; }
    }
}