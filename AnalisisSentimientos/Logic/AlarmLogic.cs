using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logic
{
    public class AlarmLogic
    {
        private Repository Repository { get; }
        private AnalysisLogic Analysis { get; }
        private AuthorLogic Authors { get; }

        public AlarmLogic(AnalysisLogic analysis, AuthorLogic authors, Repository repo)
        {
            Repository = repo;
            Authors = authors;
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

        public Alarm[] GetGeneralAlarms()
        {
            Alarm[] alarms = GetAlarms;
            List<GeneralAlarm> generalAlarms = new List<GeneralAlarm>();

            foreach (Alarm a in alarms)
            {
                if (a.GetType() == typeof(GeneralAlarm))
                {
                    generalAlarms.Add((GeneralAlarm)a);
                }
            }

            return generalAlarms.ToArray();
        }

        public Alarm[] GetAuthorAlarms()
        {
            Alarm[] alarms = GetAlarms;
            List<AuthorAlarm> authorAlarms = new List<AuthorAlarm>();

            foreach (Alarm a in alarms)
            {
                if (a.GetType() == typeof(AuthorAlarm))
                {
                    authorAlarms.Add((AuthorAlarm)a);
                }
            }
            return authorAlarms.ToArray();
        }



        public void VerifyAllAlarms()
        {
            for (int i = 0; i < Repository.GetAlarms().Count(); i++)
            {
                Alarm actualAlarm = Repository.GetAlarms()[i];
                actualAlarm.ResetCounter();
                actualAlarm.VerifyAlarm(Analysis.GetAnalysis, Authors.GetAuthors);
            }
        }


    }
}
