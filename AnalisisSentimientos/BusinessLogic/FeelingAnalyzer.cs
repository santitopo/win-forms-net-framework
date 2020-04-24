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
        //private List<Alarm> alarms;
        private List<Feeling> feelings;
        private List<Phrase> phrases;
        private List<Entity> entities;

        public FeelingAnalyzer()
        {
            feelings = new List<Feeling>();
            phrases = new List<Phrase>();
            entities = new List<Entity>();
        }

        public void addFeeling(Feeling aFeeling)
        {
            feelings.Add(aFeeling);
        }

        public Feeling[] getFeelings
        {
            get { return feelings.ToArray(); }
        }

        public void addPhrase(Phrase aPhrase)
        {
            phrases.Add(aPhrase);
        }
        public Phrase[] getPhrases
        {
            get { return phrases.ToArray(); }
        }

        public void addEntity(Entity anEntity)
        {
            entities.Add(anEntity);
        }

        public Entity[] getEntitites
        {
            get { return entities.ToArray(); }
        }

        public void deleteFeeling(Feeling aFeeling)
        {
            feelings.Remove(aFeeling);
        }

        public void deletePhrase(Phrase aPhrase)
        {
            phrases.Remove(aPhrase);
        }

        public void deleteEntity(Entity anEntity)
        {
            entities.Remove(anEntity);
        }
    }
}
