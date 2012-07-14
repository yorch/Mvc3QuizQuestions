using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public class Quiz : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}