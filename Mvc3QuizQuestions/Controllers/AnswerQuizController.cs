using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3QuizQuestions.Models;
using Mvc3QuizQuestions.DataAccess;

namespace Mvc3QuizQuestions.Controllers
{
    public class AnswerQuizController : BaseController
    {
        //
        // GET: /AnswerQuiz/

        public ViewResult Index()
        {
            return View(db.AnswerQuizs.ToList());
        }

        //
        // GET: /AnswerQuiz/Details/5

        public ViewResult Details(int id)
        {
            AnswerQuiz answerquiz = db.AnswerQuizs.Find(id);
            return View(answerquiz);
        }

        //
        // GET: /AnswerQuiz/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AnswerQuiz/Create

        [HttpPost]
        public ActionResult Create(AnswerQuiz answerquiz)
        {
            if (ModelState.IsValid)
            {
                db.AnswerQuizs.Add(answerquiz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answerquiz);
        }

        //
        // GET: /AnswerQuiz/Edit/5

        public ActionResult Edit(int id)
        {
            AnswerQuiz answerquiz = db.AnswerQuizs.Find(id);
            return View(answerquiz);
        }

        //
        // POST: /AnswerQuiz/Edit/5

        [HttpPost]
        public ActionResult Edit(AnswerQuiz answerquiz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answerquiz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(answerquiz);
        }

        //
        // GET: /AnswerQuiz/Delete/5

        public ActionResult Delete(int id)
        {
            AnswerQuiz answerquiz = db.AnswerQuizs.Find(id);
            return View(answerquiz);
        }

        //
        // POST: /AnswerQuiz/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AnswerQuiz answerquiz = db.AnswerQuizs.Find(id);
            db.AnswerQuizs.Remove(answerquiz);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}