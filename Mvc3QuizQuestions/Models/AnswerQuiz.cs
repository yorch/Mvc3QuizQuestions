using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc3QuizQuestions.Models
{
    public class AnswerQuiz : BaseEntity
    {
        [Required]
        public virtual Quiz Quiz { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public DateTime AnsweredOn { get; set; }

        [Required]
        public int Score { get; set; }

        public virtual ICollection<AnswerQuestion> Questions { get; set; }


        public void CalculateScore()
        {
            int score = 0;
            foreach (var answerQuestion in Questions)
            {
                if (answerQuestion.Answer.IsCorrect)
                {
                    score++;
                }
            }
            Score = score;
        }

        public IList<Question> IncorrectQuestions
        {
            get
            {
                IList<Question> res = new List<Question>();
                foreach (var question in Questions.ToList())
                {
                    if (!question.AnswerIsCorrect)
                    {
                        res.Add(question.Question);
                    }
                }
                return res;
            }
        }
    }
}