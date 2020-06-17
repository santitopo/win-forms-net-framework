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
                .WithMany();

            modelBuilder.Entity<Analysis>()
                .HasOptional(p => p.Phrase)
                .WithMany();

            modelBuilder.Entity<Phrase>()
                .HasOptional(a => a.Author)
                .WithMany();

            modelBuilder.Entity<Author>()
            .HasMany<Entity>(e => e.MentionedEntities)
            .WithMany();

            modelBuilder.Entity<AuthorAlarm>()
            .HasMany<Author>(e => e.AssociatedAuthors)
            .WithMany();

            modelBuilder.Entity<GeneralAlarm>()
            .HasRequired(e => e.Entity)
            .WithMany();
        }
    }
}

