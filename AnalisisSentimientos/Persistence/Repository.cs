using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Repository
    {
        private List<Alarm> alarms;
        private List<Author> authors;
        private List<Analysis> analysis;
        private List<Entity> entities;
        private List<Feeling> feelings;
        private List<Phrase> phrases;

        public Repository()
        {
            alarms = new List<Alarm>();
            analysis = new List<Analysis>();
            authors = new List<Author>();
            entities = new List<Entity>();
            feelings = new List<Feeling>();
            phrases = new List<Phrase>();
        }

        public void AddAlarm(Alarm anAlarm)
        {
            using (FeelingAnalyzerContext ctx = new FeelingAnalyzerContext())
            {
                try
                {
                    //attach 
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

        //Pre-condition ~ Must exist in authors
        public Author getAuthorByUsername(string username)
        {
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
                    ctx.Alarms.Remove(anAlarm);
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
                    ctx.Analysis.Remove(anAnalysis);
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
                    ctx.Authors.Remove(anAuthor);
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
                    ctx.Entities.Remove(aEntity);
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
                    ctx.Feelings.Remove(aFeeling);
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
                    ctx.Phrases.Remove(aPhrase);
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
                    return ctx.Alarms.ToList();
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
                    return ctx.Analysis.Include("Entity").Include("Phrase").ToList();
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
