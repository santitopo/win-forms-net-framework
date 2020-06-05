using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Domain.Analysis.Type;


namespace Logic
{
    public class AlarmLogic
    {

        private Repository Repository { get; }
        private AnalysisLogic Analysis { get; }

        public AlarmLogic(AnalysisLogic analysis, Repository repo)
        {
            Repository = repo;
            Analysis = analysis;
        }


        public void AddAlarm(Alarm anAlarm)
        {
            if (RepeatedAlarm(anAlarm))
            {
                throw new ApplicationException("no es posible agregar exactamente la misma alarma");
            }
            Repository.AddAlarm(anAlarm);
        }

        private bool RepeatedAlarm(Alarm newAlarm)
        {
            foreach (Alarm a in Repository.GetAlarms())
            {
                if (a.Equals(newAlarm))
                    return true;
            }
            return false;
        }

        public void DeleteAlarm(Alarm anAlarm)
        {
            if (Repository.GetAlarms().Count == 0)  //isEmpty
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Repository.DeleteAlarm(anAlarm);
        }

        public Alarm[] GetAlarms
        {
            get { return Repository.GetAlarms().ToArray(); }
        }

        public void VerifyAlarms()
        {
            for (int i = 0; i < Repository.GetAlarms().Count(); i++)
            {
                Alarm actualAlarm = Repository.GetAlarms()[i];
                actualAlarm.ResetCounter();

                for (int j = 0; j < Analysis.GetAnalysis.Count(); j++)
                {
                    Analysis actualAnalysis = Analysis.GetAnalysis[j];
                    DateTime phraseEntryDate = actualAnalysis.Phrase.Date;

                    if (ValidDateRange(phraseEntryDate, actualAlarm.TimeBack) && Match(actualAnalysis, actualAlarm))
                    {
                        actualAlarm.IncreaseCounter();
                        actualAlarm.CheckAlarm();
                    }
                }
            }
        }

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
            if (phraseType == Type.neutral || anAnalysis.Entity == null)
            {
                return false;
            }
            else
            {
                //We have to refactor the Enum into a bool to compare
                bool phraseFeeling = phraseType == Type.positive ? true : false;
                return anAnalysis.Entity.Equals(anAlarm.Entity) && phraseFeeling.Equals(anAlarm.Type);
            }

        }
    }
}
