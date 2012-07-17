using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3QuizQuestions.Models
{
    public class Quiz : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}