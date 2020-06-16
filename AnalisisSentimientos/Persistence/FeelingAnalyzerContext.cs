using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class FeelingAnalyzerContext : DbContext
    {
        public FeelingAnalyzerContext()
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Feeling> Feelings { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Analysis> Analysis { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<Alarm> Alarms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Inheritance
            modelBuilder.Entity<GeneralAlarm>().ToTable("GeneralAlarm");
            modelBuilder.Entity<AuthorAlarm>().ToTable("AuthorAlarm");

            //Relations
            modelBuilder.Entity<Analysis>()
                .HasOptional(e => e.Entity)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Analysis>()
                .HasRequired(p => p.Phrase)
                .WithOptional()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phrase>()
                .HasOptional(a => a.Author)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Author>()
            .HasMany<Entity>(e => e.MentionedEntities)
            .WithOptional()
            .WillCascadeOnDelete(false);

            //---------------------- NO SE SI ESTA BIEN -----------
            modelBuilder.Entity<AuthorAlarm>()
            .HasMany<Author>(e => e.associatedAuthors)
            .WithOptional()
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<GeneralAlarm>()
            .HasRequired(e => e.Entity)
            .WithOptional()
            .WillCascadeOnDelete(false);
        }
    }
}

