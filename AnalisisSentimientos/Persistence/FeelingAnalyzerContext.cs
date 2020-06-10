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


    }
}
