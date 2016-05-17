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
            const int userId = 100;
            Boolean isMobileCrmUser = true;


            List<QuestionAnswerViewModel> answersList = new List<QuestionAnswerViewModel>();
            using (var db = new WsmsQuizEntities())
            {
                var quizActiveSession = db.QuizSessions.Where(x => x.IsActive).ToList();
                foreach (var session in quizActiveSession)
                {
                    var sessionQuestion = session.QuizQuestions.ToList();
                    if (sessionQuestion.Any())
                    {
                        var questionAnswer = new QuestionAnswerViewModel();
                        questionAnswer.QuizSessionID = session.QuizSessionID;
                        questionAnswer.QuizSessionName = session.QuizSessionName;
                        questionAnswer.QuizTypeID = session.QuizTypeID;
                        questionAnswer.QuizTypeName = GetQuizTypeByQuizTypeId(session.QuizTypeID);
                        questionAnswer.UserID = userId;
                        questionAnswer.IsMobileCrmUser = true;
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
        public ActionResult Index(IEnumerable<QuestionAnswerViewModel> model)
        {
            return null;
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


        //public ActionResult LoginPage()
        //{
        //    //...code to login user to application...
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult LoginPage(LoginPageVM model)
        //{
        //    //...code to login user to application...
        //    return View(model);
        //}
    }
}