using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3QuizQuestions.Models;
using Mvc3QuizQuestions.ViewModels;

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
            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}