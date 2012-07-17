using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3QuizQuestions.Models
{
    public class QuestionChoice : BaseEntity
    {
        [Required]
        public virtual Question Question { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
    }
}