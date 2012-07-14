using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public class QuestionAnswer : BaseEntity
    {
        public QuizAnswer QuizAnswer { get; set; }
        public Question Question { get; set; }
        public QuestionChoice Answer { get; set; }
    }
}