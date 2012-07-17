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
    public class QuestionChoiceController : Controller
    {
        private EntityContext db = new EntityContext();

        //
        // GET: /Choice/

        public ViewResult Index()
        {
            return View(db.QuestionChoices.ToList());
        }

        //
        // GET: /Choice/Details/5

        public ViewResult Details(int id)
        {
            QuestionChoice questionchoice = db.QuestionChoices.Find(id);
            return View(questionchoice);
        }

        //
        // GET: /Choice/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Choice/Create

        [HttpPost]
        public ActionResult Create(QuestionChoice questionchoice)
        {
            if (ModelState.IsValid)
            {
                db.QuestionChoices.Add(questionchoice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionchoice);
        }

        //
        // GET: /Choice/Edit/5

        public ActionResult Edit(int id)
        {
            QuestionChoice questionchoice = db.QuestionChoices.Find(id);
            return View(questionchoice);
        }

        //
        // POST: /Choice/Edit/5

        [HttpPost]
        public ActionResult Edit(QuestionChoice questionchoice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionchoice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionchoice);
        }

        //
        // GET: /Choice/Delete/5

        public ActionResult Delete(int id)
        {
            QuestionChoice questionchoice = db.QuestionChoices.Find(id);
            return View(questionchoice);
        }

        //
        // POST: /Choice/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionChoice questionchoice = db.QuestionChoices.Find(id);
            db.QuestionChoices.Remove(questionchoice);
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