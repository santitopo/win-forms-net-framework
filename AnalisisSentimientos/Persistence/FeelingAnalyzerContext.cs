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
        public DbSet<Feeling> Feelings { get; set; }
        public DbSet<Entity> Entities { get; set; }

        //CASO 2:
        //Tres tablas
        //Se puede hacer tambien mediante DataAnnotations [Table("Teachers")]

        public DbSet<Alarm> Alarms { get; set; }
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //Inheritance
            modelBuilder.Entity<GeneralAlarm>().ToTable("GeneralAlarm");
            modelBuilder.Entity<AuthorAlarm>().ToTable("AuthorAlarm");
        }

    }
}
