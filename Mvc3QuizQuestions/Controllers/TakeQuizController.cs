using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3QuizQuestions.Models;

namespace Mvc3QuizQuestions.Controllers
{
    public class TakeQuizController : BaseController
    {
        //
        // GET: /TakeQuiz/1

        public ViewResult Index(int id)
        {
            var viewModel = db.Quizs
                .Where(q => q.Id == id)
                .Include(q => q.Questions
                    .Select(qe => qe.Choices))
                .FirstOrDefault();

            AnswerQuiz answerQuiz = new AnswerQuiz()
            {
                Quiz = viewModel,
                User = User.Identity.Name,
                Questions = new List<AnswerQuestion>()
            };
            foreach (var question in viewModel.Questions)
            {
                answerQuiz.Questions.Add(new AnswerQuestion()
                {
                    Question = question
                });
            }
            return View(answerQuiz);
        }

        [HttpPost]
        public ActionResult Process(AnswerQuiz answerQuiz)
        {
            answerQuiz.AnsweredOn = DateTime.Now;
            answerQuiz.User = User.Identity.Name;
            answerQuiz.Quiz = db.Quizs.Find(answerQuiz.Quiz.Id);
            foreach (var question in answerQuiz.Questions)
            {
                question.Question = db.Questions.Find(question.Question.Id);
                question.Answer = db.QuestionChoices.Find(question.Answer.Id);
            }
            answerQuiz.CalculateScore();

            // Save it to DB
            db.AnswerQuizs.Add(answerQuiz);
            db.SaveChanges();

            return RedirectToAction("Result", new { id = answerQuiz.Id });
        }

        public ViewResult Result(int id)
        {
            var viewModel = db.AnswerQuizs
                .Where(a => a.Id == id)
                .Include(a => a.Questions.Select(q => q.Answer))
                .FirstOrDefault();
            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}