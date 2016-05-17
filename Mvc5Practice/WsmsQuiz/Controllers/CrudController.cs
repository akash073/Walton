using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WsmsQuiz.Models;
using WsmsQuiz.ViewModels;

namespace WsmsQuiz.Controllers
{
    public class CrudController : Controller
    {
        private WsmsQuizEntities db = new WsmsQuizEntities();
        // GET: Crud
        public ActionResult Index()
        {
            var quiz=new QuizAdminViewModel();
            var session = db.QuizSessions.Where(x => x.IsActive).FirstOrDefault();
            quiz.QuizAdminID = 1;
            quiz.StartDate = session.StartDate;
            quiz.EndDate = session.EndDate;
            quiz.QuizTypeID = session.QuizTypeID;
            quiz.QuizTypeName = session.QuizType.QuizTypeName;
            quiz.QuizSessionID = session.QuizSessionID;
            quiz.QuizSessionName = session.QuizSessionName;

            var questions = db.QuizQuestions.Where(x => x.QuizSessionID == quiz.QuizSessionID).Select(x=> new QuizAdminQuestion
            {
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4,
                Answer5 = x.Answer5,
                CorrectAnswer = x.CorrectAnswer,
                HasAnswer = x.HasAnswer,
                NoOfAnswer = x.NoOfAnswer,
                QuizAdminQuestionID = x.QuizQuestionID,
                QuizQuestionName = x.QuizQuestionName
            }).ToList();
            quiz.QuizAdminQuestions = questions;



            return View(quiz);
        }
        [HttpPost]
        public ActionResult Edit(QuizAdminViewModel model)
        {
            return null;
        }
    }
}