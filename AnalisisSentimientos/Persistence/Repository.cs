using Domain;
using System;
using System.Collections.Generic;
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

    }
}
