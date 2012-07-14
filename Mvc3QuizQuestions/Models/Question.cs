using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public class Question : BaseEntity
    {
        public Quiz Quiz { get; set; }
        public string Title { get; set; }
        public string HelpText { get; set; }
        public int Order { get; set; }
        public ICollection<QuestionChoice> Choices { get; set; }
    }
}