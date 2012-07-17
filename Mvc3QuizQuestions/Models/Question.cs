using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3QuizQuestions.Models
{
    public class Question : BaseEntity
    {
        [Required]
        public virtual Quiz Quiz { get; set; }

        [Required]
        public string Title { get; set; }

        public string HelpText { get; set; }

        public int Order { get; set; }

        public virtual ICollection<QuestionChoice> Choices { get; set; }
    }
}