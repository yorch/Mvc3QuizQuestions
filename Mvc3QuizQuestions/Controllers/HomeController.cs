using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3QuizQuestions.Models;

namespace Mvc3QuizQuestions.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.QuizList = db.Quizs.ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult TopScores()
        {
            int numberOfScores = 10;

            var viewModel = db.AnswerQuizs
                .OrderByDescending(a => a.Score)
                .Take(numberOfScores);

            return View(viewModel);
            /*var viewModel = from a in db.AnswerQuizs
                            orderby a.Score descending
                            select a;*/
            /*return View(viewModel
                .Select(a => a.Questions.Select(q => q.Answer))
                .Take(numberOfScores));*/
        }
    }
}
