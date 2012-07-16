using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc3QuizQuestions.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}