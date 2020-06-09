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
            alarms.Add(anAlarm);
        }
        public void AddAnalysis(Analysis anAnalysis)
        {
            analysis.Add(anAnalysis);
        }
        public void AddAuthor(Author anAuthor)
        {
            authors.Add(anAuthor);
        }
        public void AddEntity(Entity aEntity)
        {
            entities.Add(aEntity);
        }
        public void AddFeeling(Feeling aFeeling)
        {
            feelings.Add(aFeeling);
        }
        public void AddPhrase(Phrase aPhrase)
        {
            phrases.Add(aPhrase);
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
            alarms.Remove(anAlarm);
        }
        public void DeleteAnalysis(Analysis anAnalysis)
        {
            analysis.Remove(anAnalysis);
        }
        public void DeleteAuthor(Author anAuthor)
        {
            authors.Remove(anAuthor);
        }
        public void DeleteEntity(Entity aEntity)
        {
            entities.Remove(aEntity);
        }
        public void DeleteFeeling(Feeling aFeeling)
        {
            feelings.Remove(aFeeling);
        }
        public void DeletePhrase(Phrase aPhrase)
        {
            phrases.Remove(aPhrase);
        }
        public List<Alarm> GetAlarms()
        {
            return alarms;
        }
        public List<Analysis> GetAnalysis()
        {
            return analysis;
        }
        public List<Author> GetAuthors()
        {
            return authors;
        }
        public List<Entity> GetEntities()
        {
            return entities;
        }
        public List<Feeling> GetFeelings()
        {
            return feelings;
        }
        public List<Phrase> GetPhrases()
        {
            return phrases;
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
