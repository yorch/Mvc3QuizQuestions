using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mvc3QuizQuestions.Models;

namespace Mvc3QuizQuestions.DataAccess
{
    public class EntityBaseData : DropCreateDatabaseAlways<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            Quiz quiz1 = new Quiz
            {
                Name = "Quiz 1",
                Description = "This is the first Quiz.",
                Questions = new Question[4] {
                    new Question {
                        Title = "Question 1",
                        HelpText = "This is question 1",
                        Order = 1,
                        Choices = new QuestionChoice[3]
                            {
                                new QuestionChoice {
                                    Title = "Choice 1.1",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 1.2",
                                    IsCorrect = true
                                },
                                new QuestionChoice {
                                    Title = "Choice 1.3",
                                    IsCorrect = false
                                }
                            }
                    },
                    new Question {
                        Title = "Question 2",
                        HelpText = "This is question 2",
                        Order = 1,
                        Choices = new QuestionChoice[3]
                            {
                                new QuestionChoice {
                                    Title = "Choice 2.1",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 2.2",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 2.3",
                                    IsCorrect = true
                                }
                            }
                    },
                    new Question {
                        Title = "Question 3",
                        HelpText = "This is question 3",
                        Order = 1,
                        Choices = new QuestionChoice[3]
                            {
                                new QuestionChoice {
                                    Title = "Choice 3.1",
                                    IsCorrect = true
                                },
                                new QuestionChoice {
                                    Title = "Choice 3.2",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 3.3",
                                    IsCorrect = false
                                }
                            }
                    },
                    new Question {
                        Title = "Question 4",
                        HelpText = "This is question 4",
                        Order = 1,
                        Choices = new QuestionChoice[4]
                            {
                                new QuestionChoice {
                                    Title = "Choice 4.1",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 4.2",
                                    IsCorrect = false
                                },
                                new QuestionChoice {
                                    Title = "Choice 4.3",
                                    IsCorrect = false
                                }
                                ,
                                new QuestionChoice {
                                    Title = "Choice 4.4",
                                    IsCorrect = true
                                }
                            }
                    }
                }
            };

            context.Quizs.Add(quiz1);
        }
    }
}