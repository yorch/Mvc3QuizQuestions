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
    }
}
