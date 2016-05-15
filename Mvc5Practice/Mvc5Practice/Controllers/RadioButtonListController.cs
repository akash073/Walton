using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5Practice.ViewModels;
using Mvc5Practice.ViewModels.QuestionAnswer;

namespace Mvc5Practice.Controllers
{
    public class RadioButtonListController : Controller
    {
        // GET: RadioButtonList
        public ActionResult Index()
        {
            var vm = new CheckOutViewModel();
            vm.SelectedPaymentType = "test";
            var selectItemses=new List<SelectItems>();
            selectItemses.Add(new SelectItems
            {
                option1 = "a",
                option2 = "b",
                totalOption = 2
            });
            
            vm.PaymentTypes = selectItemses; //gets a list of SelectItems
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(CheckOutViewModel model)
        {
            //check the value of model.SelectedPaymentType
            int a =0;
            return View();
        }

        public ActionResult Question()
        {
            StudentVM model = new StudentVM();
model.ID = 1;
model.Name = "bambiinela";
model.Subjects = new List<SubjectVM>()
{
  new SubjectVM()
  {
    Questions = new List<QuestionVM>()
    {
      new QuestionVM()
      {
        ID = 1,
        Text = "Question 1",
       // SelectedAnswer = 1, // set this if you want to preselect an option
        PossibleAnswers = new List<AnswerVM>()
        {
          new AnswerVM()
          {
            ID = 1,
            Text = "Answer A"
          },
          new AnswerVM()
          {
            ID = 1,
            Text = "Answer B"
          }
        }
      },
      new QuestionVM()
      {
        ID = 2,
        Text = "Question 2",
        PossibleAnswers = new List<AnswerVM>()
        {
          // similar to above
          new AnswerVM()
          {
            ID = 1,
            Text = "Answer c"
          },
          new AnswerVM()
          {
            ID = 1,
            Text = "Answer d"
          }
        }
      }
    }
  },
  new SubjectVM()
  {
    ID = 1,
    Name = "Math",
    Questions = new List<QuestionVM>()
    {
      //// similar to above
      //new QuestionVM
      //{
      
      //}
    }
  }
};
            return View();
        }

        
    }
}