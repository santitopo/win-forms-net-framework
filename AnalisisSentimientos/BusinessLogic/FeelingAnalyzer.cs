using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FeelingAnalyzer
    {
        private List<Alarm> alarms;
        private List<Phrase> phrases;
        private List<Entity> entities;
        private List<Analysis> analysis;

        public FeelingAnalyzer()
        {
            alarms = new List<Alarm>();
            phrases = new List<Phrase>();
            entities = new List<Entity>();
            analysis = new List<Analysis>();
            //analysisLogic = new AnalysisLogic();
            //alarmLogic = new AlarmLogic();
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
                throw new ApplicationException("no es posible agregar la misma entidad " +
                "o una subsecuencia de una entidad que ya se encuentra en la lista");
            }
            entities.Add(anEntity);
        }
        private bool RepeatedEntity(string name)
        {
            var nameLower = name.ToLower();
            //Three Cases: 
            //1. The name is excactly the same(lower/upper case also)
            //2. Name is a substring of f.Name
            //3. f.Name is a substring of Name
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


        public void DeletePhrase(Phrase aPhrase)
        {
            if (phrases.Count == 0) 
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            phrases.Remove(aPhrase);
        }

        public void DeleteEntity(Entity anEntity)
        {
            if (entities.Count==0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            entities.Remove(anEntity);
        }

        public void AddAlarm(Alarm anAlarm)
        {
            if (RepeatedAlarm(anAlarm))
            {
                throw new ApplicationException("no es posible agregar exactamente la misma alarma");
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
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            alarms.Remove(anAlarm);
        }

        public Alarm[] GetAlarms
        {
            get { return alarms.ToArray(); }
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            analysis.Add(anAnalysis);
        }

        public Analysis[] GetAnalysis
        {
            get { return analysis.ToArray(); }
        }

        //public Analysis ExecuteAnalysis(Phrase aPhrase)
        //{
        //    Analysis newAnalysis = analysisLogic.ExecuteAnalysis(GetEntitites, GetFeelings, aPhrase);
        //    return newAnalysis;
        //}
    
        //public void VerifyAlarms()
        //{
        //    for(int i=0; i<alarms.Count(); i++)
        //    {
        //        Alarm actualAlarm = alarms[i];
        //        alarmLogic.ResetCounter(actualAlarm);

        //        for (int j = 0; j < analysis.Count(); j++)
        //        {
        //            Analysis actualAnalysis = analysis[j];
        //            DateTime phraseEntryDate  = actualAnalysis.Phrase.Date;

        //            if (ValidDateRange(phraseEntryDate,actualAlarm.TimeBack) && Match(actualAnalysis,actualAlarm))
        //            {
        //                alarmLogic.IncreaseCounter(actualAlarm);
        //                alarmLogic.CheckAlarm(actualAlarm);
        //            }
        //        }
        //    }        
        //}

        private bool ValidDateRange(DateTime aDate, int range)
        {
            //Range is in hours
            int days = range / 24;
            int hours = range % 24;

            DateTime actualDate = DateTime.Now;
            if ((actualDate.Date - aDate.Date).Days < days)
            {
                return true;
            }
            else if ((actualDate.Date - aDate.Date).Days > days)
            {
                return false;
            }
            else //(actualDate.Date - aDate.Date).Days == days
            {
                return actualDate.Hour <= aDate.Hour;
            }
        }

        private bool Match(Analysis anAnalysis, Alarm anAlarm)
        {
            var phraseType = anAnalysis.PhraseType;
            if (phraseType == Analysis.Type.neutral || anAnalysis.Entity == null)
            {
                return false;
            }else
            {
                //We have to refactor the Enum into a bool to compare
                bool phraseFeeling = phraseType == Analysis.Type.positive ? true : false;
                return anAnalysis.Entity.Equals(anAlarm.Entity) && phraseFeeling.Equals(anAlarm.Type);
            }
            
        }
        
    }
}
