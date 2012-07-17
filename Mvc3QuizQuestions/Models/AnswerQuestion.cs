using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3QuizQuestions.Models
{
    public class AnswerQuestion : BaseEntity
    {
        [Required]
        public virtual AnswerQuiz QuizAnswer { get; set; }

        public virtual Question Question { get; set; }

        public virtual QuestionChoice Answer { get; set; }


        public bool AnswerIsCorrect
        {
            get
            {
                return Answer.IsCorrect;
            }
        }
    }
}