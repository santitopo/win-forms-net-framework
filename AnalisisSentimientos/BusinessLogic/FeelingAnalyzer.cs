using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FeelingAnalyzer
    {
        private List<Alarm> alarms;
        private List<Feeling> feelings;
        private List<Phrase> phrases;
        private List<Entity> entities;

        public FeelingAnalyzer()
        {
            alarms = new List<Alarm>();
            feelings = new List<Feeling>();
            phrases = new List<Phrase>();
            entities = new List<Entity>();
        }

        public void AddFeeling(Feeling aFeeling)
        {
            if (RepeatedFeeling(aFeeling.Name))
            {
                throw new ArgumentException("can't add the same feeling or a " +
                    "substring of an feeling that already in the list");
            }
            feelings.Add(aFeeling);
        }

        private bool RepeatedFeeling(string name)
        {
            var nameLower = name.ToLower();
            //Four Cases: 
            //1. The name is excactly the same (lower/upper case also)
            //3. Name is a substring of f.Name
            //4. f.Name is a substring of Name
            foreach (Feeling f in feelings){
                if (f.Name.ToLower().Contains(nameLower) || nameLower.Contains(f.Name.ToLower()))
                    return true;
            }
            return false;
        }

        public Feeling[] GetFeelings
        {
            get { return feelings.ToArray(); }
        }

        public void AddPhrase(Phrase aPhrase)
        {
            phrases.Add(aPhrase);
        }
        public Phrase[] GetPhrases
        {
            get { return phrases.ToArray(); }
        }

        public void AddEntity(Entity anEntity)
        {
            if (RepeatedEntity(anEntity.Name))
            {
                throw new ArgumentException("can't add the same entity or a " +
                    "substring of an entity that already in the list");
            }
            entities.Add(anEntity);
        }
        private bool RepeatedEntity(string name)
        {
            var nameLower = name.ToLower();
            //Four Cases: 
            //1. The name is excactly the same(lower/upper case also)
            //3. Name is a substring of f.Name
            //4. f.Name is a substring of Name
            foreach (Entity e in entities)
            {
                if (e.Name.ToLower().Contains(nameLower) || nameLower.Contains(e.Name.ToLower()))
                    return true;
            }
            return false;
        }
        public Entity[] GetEntitites
        {
            get { return entities.ToArray(); }
        }

        public void DeleteFeeling(Feeling aFeeling)
        {
            if (feelings.Count == 0)  //isEmpty
            {
                throw new InvalidOperationException("can't delete an empty list");
            }
            feelings.Remove(aFeeling);
        }

        public void DeletePhrase(Phrase aPhrase)
        {
            if (phrases.Count == 0)  //isEmpty
            {
                throw new InvalidOperationException("can't delete an empty list");
            }
            phrases.Remove(aPhrase);
        }

        public void DeleteEntity(Entity anEntity)
        {
            if (entities.Count==0)  //isEmpty
            {
                throw new InvalidOperationException("can't delete an empty list");
            }
            entities.Remove(anEntity);
        }

        public void AddAlarm(Alarm anAlarm)
        {
            if (RepeatedAlarm(anAlarm))
            {
                throw new ArgumentException("can't add exactly the same alarm");
            }
            alarms.Add(anAlarm);
        }

        private bool RepeatedAlarm(Alarm newAlarm)
        {
            foreach (Alarm a in alarms)
            {
                if (a.Equals(newAlarm))
                    return true;
            }
            return false;
        }

        public void DeleteAlarm(Alarm anAlarm)
        {
            if (alarms.Count == 0)  //isEmpty
            {
                throw new InvalidOperationException("can't delete an empty list");
            }
            alarms.Remove(anAlarm);
        }

        public Alarm[] GetAlarms
        {
            get { return alarms.ToArray(); }
        }
    }
}
