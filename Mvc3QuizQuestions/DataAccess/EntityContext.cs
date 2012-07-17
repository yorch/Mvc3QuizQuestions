using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using Mvc3QuizQuestions.Models;

namespace Mvc3QuizQuestions.DataAccess
{
    public class EntityContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Mvc3QuizQuestions.Models.Mvc3QuizQuestionsContext>());

        public DbSet<Quiz> Quizs { get; set; }
        //public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionChoice> QuestionChoices { get; set; }
        public DbSet<AnswerQuiz> AnswerQuizs { get; set; }
        public DbSet<AnswerQuestion> AnswerQuestions { get; set; }

        public override int SaveChanges()
        {
            DateTime now = DateTime.Now;
            foreach (var entity in ChangeTracker.Entries<BaseEntity>()
                                                .Where(e => e.State == EntityState.Added)
                                                .Select(e => e.Entity))
            {
                entity.CreatedOn = now;
            }

            foreach (var entity in ChangeTracker.Entries<BaseEntity>()
                                                .Where(e => e.State == EntityState.Modified)
                                                .Select(e => e.Entity))
            {
                entity.UpdatedOn = now;
            }

            return base.SaveChanges();
        }
    }
}