using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public class QuizAnswer : BaseEntity
    {
        public Quiz Quiz { get; set; }
        public string User { get; set; }
        public DateTime AnsweredOn { get; set; }
        public int Score { get; set; }
    }
}