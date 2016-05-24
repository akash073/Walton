using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WSMSCRM.Login;
using WsmsQuiz.Models;
using WsmsQuiz.ViewModels;

namespace WsmsQuiz.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            int userId = 100;
            Boolean isMobileCrmUser = true;
            try
            {
                var value = HttpContext.Request.Params.Get("userName");
                userId = Convert.ToInt32(value);
                if (userId == 0)
                {
                    RedirectToAction("Login", "Admin");
                }
                else if (userId < 10000)
                {
                    isMobileCrmUser = true;
                }
                else
                {
                    isMobileCrmUser = false;
                }
                //  value = "ajaj";
            }
            catch (Exception e)
            {
                
                
            }
            List<QuestionAnswerViewModel> answersList = new List<QuestionAnswerViewModel>();
            using (var db = new WsmsQuizEntities())
            {
                //var quizActiveSession = db.QuizSessions.Where(x => x.IsActive).ToList();
                var query = String.Format(@"select * 
from QuizSession qs
where IsActive=1

and Exists (select 1 from QuizQuestion where QuizSessionID=qs.QuizSessionID)
and qs.QuizSessionID not in (

select QuizSessionID from QuizSessionUser where UserID={0}
)
", userId);
                var quizActiveSession = db.Database.SqlQuery<QuizSession>(query).ToList();

                foreach (var session in quizActiveSession)
                {
                    var sessionQuestion = db.QuizQuestions.Where(x=>x.QuizSessionID==session.QuizSessionID).ToList();
                    if (sessionQuestion.Any())
                    {
                        var questionAnswer = new QuestionAnswerViewModel();
                        questionAnswer.QuizSessionID = session.QuizSessionID;
                        questionAnswer.QuizSessionName = session.QuizSessionName;
                        questionAnswer.QuizTypeID = session.QuizTypeID;
                        questionAnswer.QuizTypeName = GetQuizTypeByQuizTypeId(session.QuizTypeID);
                        questionAnswer.UserID = userId;
                        questionAnswer.IsMobileCrmUser = isMobileCrmUser;
                        var questions = new List<Question>();
                        foreach (var q in sessionQuestion)
                        {
                            Question question = new Question();

                            question.QuizQuestionID = q.QuizQuestionID;
                            question.QuizQuestionName = q.QuizQuestionName;

                            var possible = new List<Answer>();
                            int noOfAnswer = q.NoOfAnswer;
                            for (int count = 1; count <= noOfAnswer; count++)
                            {
                                var answer = new Answer();
                                if (count == 1)
                                {
                                    answer.Id = count;
                                    answer.AnswerName = q.Answer1;

                                }
                                else if (count == 2)
                                {
                                    answer.Id = count;
                                    answer.AnswerName = q.Answer2;
                                }
                                else if (count == 3)
                                {
                                    answer.Id = count;
                                    answer.AnswerName = q.Answer3;
                                }
                                else if (count == 4)
                                {
                                    answer.Id = count;
                                    answer.AnswerName = q.Answer4;
                                }
                                else if (count == 5)
                                {
                                    answer.Id = count;
                                    answer.AnswerName = q.Answer5;
                                }
                                possible.Add(answer);
                            }
                            question.Answers = possible;
                            questions.Add(question);
                        }
                        questionAnswer.Questions = questions;

                        answersList.Add(questionAnswer);
                    }
                }
            }
            return View(answersList);
        }

        [HttpPost]
        public void Index(List<QuestionAnswerViewModel> model)
        {
            int userId = model[0].UserID;
            bool isMobileCrm = model[0].IsMobileCrmUser;

            var userInfo = UserInfo.GetUserInfo(userId, isMobileCrm);
            var servicePointName = ServicePoint.GetServicePointName(userInfo.ServicePointID,isMobileCrm);
            /*
             SELECT TOP 1000 [QuizSessionUserID]
      ,[QuizSessionID]
      ,[IsMobileCrmUser]
      ,[UserID]
      ,[UserFullName]
      ,[ServicePointID]
      ,[ServicePointName]
      ,[EmployeeCode]
      ,[UserAnswer]
  FROM [WsmsQuiz].[dbo].[QuizSessionUser]
             */
            using (var db = new WsmsQuizEntities())
            {
                foreach (var answerViewModel in model)
                {
                    long quizSessionId = answerViewModel.QuizSessionID;
                    var quizSessionUser = new QuizSessionUser
                    {
                        QuizSessionID = quizSessionId,
                        IsMobileCrmUser = isMobileCrm,
                        UserID = userId,
                        UserFullName = userInfo.UserFullName,
                       ServicePointID = userInfo.ServicePointID,
                       ServicePointName = servicePointName,
                        EmployeeCode = userInfo.EmployeeCode
                     
                         
                    };
                    db.QuizSessionUsers.Add(quizSessionUser);
                    db.SaveChanges();
                    long quizSessionUserID = quizSessionUser.QuizSessionUserID;

                    foreach (var question in answerViewModel.Questions)
                    {
                        /*
                         
                         SELECT TOP 1000 [QuizSessionUserAnswerID]
      ,[QuizSessionID]
      ,[QuizQuestionID]
      ,[QuizSessionUserID]
      ,[UserAnswer]
  FROM [WsmsQuiz].[dbo].[QuizSessionUserAnswer]
                         
                         */
                        var quizSessionUserAnswer = new QuizSessionUserAnswer
                        {
                            QuizSessionID = quizSessionId,
                            QuizQuestionID = question.QuizQuestionID,
                            QuizSessionUserID = quizSessionUserID,
                            UserAnswer = question.UserSelectedAnswer
                        };
                        db.QuizSessionUserAnswers.Add(quizSessionUserAnswer);
                    }
                //    db.SaveChanges();

                }
            }
            FormRedirection formRedirection = new FormRedirection();
            var userRedirectInfo = UserInfo.GetUserInfo(userId, isMobileCrm);


            formRedirection.Post("http://localhost:2456/Login/Login.aspx", userRedirectInfo.UserName, userRedirectInfo.Password);
           // return RedirectToAction("RedirectToCrm",new {userName="akash",password="akash"});
        }
        public static string GetQuizTypeByQuizTypeId(long quizTypeID)
        {
            String quizName;
            using (var db = new WsmsQuizEntities())
            {
                quizName =
                    db.QuizTypes.Where(x => x.QuizTypeID == quizTypeID).Select(x => x.QuizTypeName).FirstOrDefault();
            }
            return quizName;
        }
    }
}