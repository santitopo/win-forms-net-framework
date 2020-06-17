using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Domain.Analysis.Type;

namespace Persistence
{
    public class Repository
    {
        public Repository(){ }

        public void DeleteAllAuthors()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                        ctx.Authors.RemoveRange(ctx.Authors);
                        ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting teachers", ex);
                }
            }
        }

        public void DeleteAllAlarms()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                        ctx.Alarms.RemoveRange(ctx.Alarms);
                        ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting alarms", ex);
                }
            }
        }

        public void DeleteAllFeelings()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.RemoveRange(ctx.Feelings);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting feelings", ex);
                }
            }
        }

        public void DeleteAllEntities()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities
.RemoveRange(ctx.Entities);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }
        }

        public void DeleteAllAnalysis()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Analysis.RemoveRange(ctx.Analysis);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting analysis", ex);
                }
            }
        }

        public void DeleteAllPhrases()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Phrases.RemoveRange(ctx.Phrases);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting phrases", ex);
                }
            }
        }

        public void UpdateAuthorBD(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.Attach(anAuthor);
                    List<Entity> entityList = anAuthor.MentionedEntities;
                    foreach (Entity e in entityList)
                    {
                        ctx.Entities.Attach(e);
                    }

                    ctx.Entry(anAuthor).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error modified anAnalysis", ex);
                }
            }
        }

        public void UpdateAlarmBD(Alarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Alarms.Attach(anAlarm);
                    if (anAlarm.GetType() == typeof(GeneralAlarm))
                    {
                        GeneralAlarm generalAlarm = anAlarm as GeneralAlarm;
                        ctx.Entities.Attach(generalAlarm.Entity);

                        ctx.Entry(generalAlarm.Entity).State = EntityState.Modified;
                        ctx.Entry(generalAlarm).State = EntityState.Modified;
                    }
                    else if (anAlarm.GetType() == typeof(AuthorAlarm))
                    {
                        AuthorAlarm authorAlarm = anAlarm as AuthorAlarm;
                        int size = authorAlarm.AssociatedAuthors.Count();

                        for (int i = 0; i < size; i++)
                        {
                            ctx.Authors.Attach(authorAlarm.AssociatedAuthors[i]);
                            ctx.Entry(authorAlarm.AssociatedAuthors[i]).State = EntityState.Modified;
                        }
                        ctx.Entry(authorAlarm).State = EntityState.Modified;
                    }

                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error modified Alarm", ex);
                }
            }
        }

        public void AddGeneralAlarm(GeneralAlarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities.Attach(anAlarm.Entity);
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new alarm", ex);
                }
            }
        }

        public void AddAuthorAlarm(AuthorAlarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    //attach?
                    ctx.Alarms.Add(anAlarm);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new alarm", ex);
                }
            }
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    if (anAnalysis.Entity != null)
                    {
                        ctx.Entities.Attach(anAnalysis.Entity);
                    }
                    ctx.Phrases.Attach(anAnalysis.Phrase);
                    ctx.Authors.Attach(anAnalysis.Phrase.Author); //No se propaga
                    ctx.Analysis.Add(anAnalysis);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new analysis", ex);
                }
            }

            //analysis.Add(anAnalysis);
        }
        public void AddAuthor(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.Add(anAuthor);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new author", ex);
                }
            }
            //authors.Add(anAuthor);
        }
        public void AddEntity(Entity aEntity)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities.Add(aEntity);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new entity", ex);
                }
            }

            //entities.Add(aEntity);
        }
        public void AddFeeling(Feeling aFeeling)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.Add(aFeeling);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new feeling", ex);
                }
            }

            //feelings.Add(aFeeling);
        }
        public void AddPhrase(Phrase aPhrase)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.Attach(aPhrase.Author);
                    ctx.Phrases.Add(aPhrase);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error adding new phrase", ex);
                }
            }
        }

        //Pre-condition ~ Must exist in entities
        public Entity GetEntityByName(string name)
        {
            List<Entity> entities = GetEntities();
            foreach (Entity e in entities)
            {
                if (e.Name.Equals(name))
                {
                    return e;
                }
            }
            return null;
        }

        //Pre-condition ~ Must exist in authors
        public Author getAuthorByUsername(string username)
        {
            List<Author> authors = GetAuthors();
            foreach (Author a in authors)
            {
                if (a.Username.Equals(username))
                {
                    return a;
                }
            }
            return null;
        }

        public void DeleteAlarm(Alarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Alarms.Remove(ctx.Alarms.Single(a => a.AlarmId == anAlarm.AlarmId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay autores en el sistema", ex);
                }
            }
        }
        public void DeleteAnalysis(Analysis anAnalysis)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Analysis.Remove(ctx.Analysis.Single(a => a.AnalysisId == anAnalysis.AnalysisId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay analisis en el sistema", ex);
                }
            }
        }
        public void DeleteAuthor(Author anAuthor)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Authors.Remove(ctx.Authors.Single(a => a.AuthorId == anAuthor.AuthorId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay analisis en el sistema", ex);
                }
            }
        }
        public void DeleteEntity(Entity aEntity)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Entities.Remove(ctx.Entities.Single(e => e.EntityId == aEntity.EntityId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay entidades en el sistema", ex);
                }
            }
        }
        public void DeleteFeeling(Feeling aFeeling)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Feelings.Remove(ctx.Feelings.Single(f => f.FeelingId == aFeeling.FeelingId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay sentimientos en el sistema", ex);
                }
            }
        }
        public void DeletePhrase(Phrase aPhrase)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    ctx.Phrases.Remove(ctx.Phrases.Single(p => p.PhraseId == aPhrase.PhraseId));
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("No hay frases en el sistema", ex);
                }
            }
        }
        public List<Alarm> GetAlarms()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    List<GeneralAlarm> l1 = ctx.Alarms.OfType<GeneralAlarm>().
                        Include("Entity").ToList();
                    List<AuthorAlarm> l2 = ctx.Alarms.OfType<AuthorAlarm>().
                        Include("AssociatedAuthors").ToList();
                    List<Alarm> ret = new List<Alarm>();

                    for (int i = 0; i < l1.Count; i++)
                    {
                        ret.Add(l1[i]);
                    }
                    for (int i = 0; i < l2.Count; i++)
                    {
                        ret.Add(l2[i]);
                    }

                    return ret;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting alarms", ex);
                }
            }
        }
        public List<Analysis> GetAnalysis()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Analysis.Include("Entity").Include("Phrase.Author").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting analysis", ex);
                }
            }
        }
        public List<Author> GetAuthors()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Authors.Include("MentionedEntities").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting authors", ex);
                }
            }
        }
        public List<Entity> GetEntities()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Entities.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting entities", ex);
                }
            }

            //return entities;
        }
        public List<Feeling> GetFeelings()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Feelings.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting feelings", ex);
                }
            }

            //return feelings;
        }
        public List<Phrase> GetPhrases()
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    return ctx.Phrases.Include("Author").ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error getting phrases", ex);
                }
            }
        }

        public bool AuthorHasPhrases(Author anAuthor)
        {
            List<Phrase> phrases= GetPhrases();
            foreach (Phrase p in phrases)
            {
                if (p.Author.Equals(anAuthor)){
                    return true;
                }
            }
            return false;
        }

        //Pre: Author has phrases in System
        public DateTime GetFirstPhraseDate(Author anAuthor)
        {
            List<Phrase> phrases = GetPhrases();
            //returns Now if no phrases
            DateTime first = DateTime.Now;
            foreach (Phrase p in phrases)
            {
                
                if (p.Author.Equals(anAuthor))
                {
                   if (p.Date < first)
                   {
                        first = p.Date;
                   }     
                } 
            }
            return first;
        }


        public DataTable DTEntityNumberDesc()
        {
            DataTable customDT = new DataTable();
            DataColumn[] columns = {new DataColumn("Usuario"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Entidades", System.Type.GetType("System.Int32")) };
            customDT.Columns.AddRange(columns);
            List<Author> lst = ListByEntityNumberDesc();
            foreach (Author a in lst)
            {
                DataRow row = customDT.NewRow();
                row[0] = a.Username;
                row[1] = a.Name;
                row[2] = a.Surname;
                row[3] = a.MentionedEntities.Count;
                customDT.Rows.Add(row);
            }
            return customDT;
        }

        public List<Author> ListByEntityNumberDesc()
        {
            List<Author> authList = GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.MentionedEntities.Count() > y.MentionedEntities.Count()) return -1;
                else if (x.MentionedEntities.Count() < y.MentionedEntities.Count()) return 1;
                return 0;
            });
            return authList;
        }

        public List<Author> ListByPhraseAverageDesc()
        {
            List<Author> authList = GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (!AuthorHasPhrases(x)) return 1;
                if (!AuthorHasPhrases(y)) return -1;
                int activeDaysX = (DateTime.Now - GetFirstPhraseDate(x)).Days;
                double averageX = (activeDaysX == 0) ? 0 : (double)x.TotalPosts / activeDaysX;

                int activeDaysY = (DateTime.Now - GetFirstPhraseDate(y)).Days;
                double averageY = (activeDaysY == 0) ? 0 : (double)y.TotalPosts / activeDaysY;

                if (averageX > averageY) return -1;
                else if (averageX < averageY) return 1;
                return 0;
            });
            return authList;
        }

        public List<Author> ListByPositiveRatioDesc()
        {
            List<Author> authList = GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.PositiveRatio() > y.PositiveRatio()) return -1;
                else if (x.PositiveRatio() < y.PositiveRatio()) return 1;
                return 0;
            });
            return authList;

        }

        public List<Author> ListByNegativeRatioDesc()
        {
            List<Author> authList = GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.NegativeRatio() > y.NegativeRatio()) return -1;
                else if (x.NegativeRatio() < y.NegativeRatio()) return 1;
                return 0;
            });
            return authList;

        }

    }
}
