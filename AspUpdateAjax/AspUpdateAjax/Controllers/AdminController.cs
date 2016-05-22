using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspUpdateAjax.ViewModels;

namespace AspUpdateAjax.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public String OnBeginRequest()
        {
            Session["QuestionViewModel"] = null;
            return "ok";
        }
        [HttpPost]
        public String RemoveRequest(string text)
        {
            // Session["QuestionViewModel"] = null;
            List<QuestionViewModel> questionViewModels = Session["QuestionViewModel"] as List<QuestionViewModel>;
            if (questionViewModels != null)
            {
               questionViewModels= questionViewModels.Where(x => !x.QuestionName.Contains(text.Trim())).ToList();
               Session["QuestionViewModel"] = questionViewModels;
            }
            return "OK";
        }
        

        [HttpPost]
        public PartialViewResult AddQuestions(QuestionViewModel model)
        {
            List<QuestionViewModel> questionViewModels = Session["QuestionViewModel"] as List<QuestionViewModel>;
            if (questionViewModels == null)
            {
                questionViewModels=new List<QuestionViewModel>();
            }
            else
            {
                questionViewModels = questionViewModels.Where(x => !x.QuestionName.Contains(model.QuestionName.Trim())).ToList();
            }
            questionViewModels.Add(model);
            Session["QuestionViewModel"] = questionViewModels;
            return PartialView("_QuestionPartial", questionViewModels);
        }

        [HttpPost]
        public ActionResult Save()
        {
            var questionViewModels = Session["QuestionViewModel"] as List<QuestionViewModel>;
            if (questionViewModels == null)
            {
                return Redirect("/Admin/Index");
            }
            return View();
        }
    }
}