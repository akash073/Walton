using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Ajax.Utilities;
using WsmsQuiz.Models;
using WsmsQuiz.ViewModels;

namespace AspUpdateAjax.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Security
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                //int a = 0;
                UserInfo userInfo = UserInfo.GetUserLoginIfInfo(user.UserName, user.Password);
                if (userInfo != null)
                {
                    Session["QuizAdminID"] = userInfo.UserID;
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return Redirect("/Admin/Index");
                }
                else
                {
                    return Redirect("/Admin/Login");
                }

            }
            return View("Index");
        }
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
            else
            {
                int quizAdminID = (int)Session["QuizAdminID"]; 
                String quizName = questionViewModels[0].SessionName;
                Boolean isActive = true;
                DateTime startDateTime = questionViewModels[0].StartDate;
                DateTime endDateTime = questionViewModels[0].EndDate;
                String purpose = "Just test";
                long quizTypeId = questionViewModels[0].SessionType;
                var quizSession = new QuizSession
                {
                    EndDate = endDateTime,
                    IsActive = isActive,
                    Purpose = purpose,
                    QuizAdminID = quizAdminID,
                    StartDate = startDateTime,
                    QuizSessionName = quizName,
                    QuizTypeID = quizTypeId
                };
                using (var db=new WsmsQuizEntities())
                {
                    db.QuizSessions.Add(quizSession);
                    db.SaveChanges();
                    long quizSessionId = quizSession.QuizSessionID;
                    foreach (var question in questionViewModels)
                    {
                        var quizQuestion = new QuizQuestion
                        {
                            QuizSessionID = quizSessionId,
                            QuizQuestionName = question.QuestionName,
                            Answer1 = question.Answer1,
                            Answer2 = question.Answer2,
                            Answer3 = question.Answer3,
                            Answer4 = question.Answer4,
                            Answer5 = question.Answer5,
                            NoOfAnswer = question.QuestionOption,
                            CorrectAnswer = question.CorrectAnswer,
                            HasAnswer = true
                        };
                        db.QuizQuestions.Add(quizQuestion);

                    }
                    db.SaveChanges();

                }
            }
            return View();
        }
    }
}