using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc5Practice.Models;

namespace Mvc5Practice.Controllers
{
    public class CrudController : Controller
    {
        private StudentDbContext db = new StudentDbContext();

        // GET: Crud
        public ActionResult Index()
        {
            return View(db.QuizAdminViewModels.ToList());
        }

        // GET: Crud/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizAdminViewModel quizAdminViewModel = db.QuizAdminViewModels.Find(id);
            if (quizAdminViewModel == null)
            {
                return HttpNotFound();
            }
            return View(quizAdminViewModel);
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,QuizAdminID,QuizTypeID,QuizTypeName,QuizSessionID,QuizSessionName,StartDate,EndDate,QuizQuestionName,NoOfAnswer,Answer1,Answer2,Answer3,Answer4,Answer5,HasAnswer,CorrectAnswer")] QuizAdminViewModel quizAdminViewModel)
        {
            if (ModelState.IsValid)
            {
                db.QuizAdminViewModels.Add(quizAdminViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quizAdminViewModel);
        }

        // GET: Crud/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizAdminViewModel quizAdminViewModel = db.QuizAdminViewModels.Find(id);
            if (quizAdminViewModel == null)
            {
                return HttpNotFound();
            }
            return View(quizAdminViewModel);
        }

        // POST: Crud/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,QuizAdminID,QuizTypeID,QuizTypeName,QuizSessionID,QuizSessionName,StartDate,EndDate,QuizQuestionName,NoOfAnswer,Answer1,Answer2,Answer3,Answer4,Answer5,HasAnswer,CorrectAnswer")] QuizAdminViewModel quizAdminViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quizAdminViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quizAdminViewModel);
        }

        // GET: Crud/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizAdminViewModel quizAdminViewModel = db.QuizAdminViewModels.Find(id);
            if (quizAdminViewModel == null)
            {
                return HttpNotFound();
            }
            return View(quizAdminViewModel);
        }

        // POST: Crud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            QuizAdminViewModel quizAdminViewModel = db.QuizAdminViewModels.Find(id);
            db.QuizAdminViewModels.Remove(quizAdminViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
