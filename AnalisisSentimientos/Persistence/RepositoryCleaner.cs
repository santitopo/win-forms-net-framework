using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class RepositoryCleaner
    {
        public RepositoryCleaner()
        {
        }

        public void CleanRepository()
        {
            DeleteAllAlarms();
            DeleteAllAnalysis();
            DeleteAllAuthors();
            DeleteAllEntities();
            DeleteAllFeelings();
            DeleteAllPhrases();
        }

        public void DeleteAllAuthors()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Authors.RemoveRange(ctx.Authors);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los autores", ex);
            }
        }

        public void DeleteAllAlarms()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Alarms.RemoveRange(ctx.Alarms);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos las alarmas", ex);
            }
        }

        public void DeleteAllFeelings()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Feelings.RemoveRange(ctx.Feelings);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los sentimientos", ex);
            }
        }

        public void DeleteAllEntities()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Entities.RemoveRange(ctx.Entities);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todas las entidades", ex);
            }
        }

        public void DeleteAllAnalysis()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Analysis.RemoveRange(ctx.Analysis);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todos los analisis", ex);
            }
        }

        public void DeleteAllPhrases()
        {
            try
            {
                using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
                {
                    ctx.Phrases.RemoveRange(ctx.Phrases);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar todas las frases", ex);
            }
        }
    }
}
