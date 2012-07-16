using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3QuizQuestions.Models;
using Mvc3QuizQuestions.DataAccess;

namespace Mvc3QuizQuestions.Controllers
{
    public abstract class BaseController : Controller
    {
        protected EntityContext db = new EntityContext();
    }
}
