using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WsmsQuiz.Models;
using WsmsQuiz.ViewModels;

namespace WsmsQuiz.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int userId = 100;
            Boolean isMobileCrmUser =true;


            List<QuestionAnswerViewModel> answersList = new List<QuestionAnswerViewModel>();
            using (var db = new WsmsQuizEntities())
            {
                var quizActiveSession = db.QuizSessions.Where(x => x.IsActive).ToList();
                foreach (var session in quizActiveSession)
                {
                    var questionAnswer = new QuestionAnswerViewModel();
                    questionAnswer.QuizSessionID = session.QuizSessionID;
                    questionAnswer.QuizSessionName = session.QuizSessionName;
                    questionAnswer.QuizTypeID = session.QuizTypeID;
                    questionAnswer.QuizTypeName = GetQuizNameByQuizTypeId(session.QuizTypeID);
                    var sessionQuestion = session.QuizQuestions.ToList();


                    answersList.Add(questionAnswer);
                }
            }

            var sp = UserInfo.GetUserInfo(1, true);
            var spp = UserInfo.GetUserInfo(537, false);

            if (sp == spp)
            {
                int a = 0;
            }


            return View(answersList);
        }

        public static string GetQuizNameByQuizTypeId(long quizTypeID)
        {
            String quizName = String.Empty;
            using (var db = new WsmsQuizEntities())
            {
                quizName =
                    db.QuizTypes.Where(x => x.QuizTypeID == quizTypeID).Select(x => x.QuizTypeName).FirstOrDefault();
            }
            return quizName;
        }
    }
}