using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public class QuestionChoice : BaseEntity
    {
        public Question Question { get; set; }
        public string Title { get; set; }
        public bool IsCorrect { get; set; }
    }
}