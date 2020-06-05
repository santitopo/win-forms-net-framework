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

        private AlarmPersistence Alarms { get; set; }
        private AnalysisLogic Analysis { get; }

        public AlarmLogic(AnalysisLogic analysis)
        {
            Alarms = new AlarmPersistence();
            Analysis = analysis;
        }


        public void AddAlarm(Alarm anAlarm)
        {
            if (RepeatedAlarm(anAlarm))
            {
                throw new ApplicationException("no es posible agregar exactamente la misma alarma");
            }
            Alarms.Add(anAlarm);
        }

        private bool RepeatedAlarm(Alarm newAlarm)
        {
            foreach (Alarm a in Alarms.Get())
            {
                if (a.Equals(newAlarm))
                    return true;
            }
            return false;
        }

        public void DeleteAlarm(Alarm anAlarm)
        {
            if (Alarms.Get().Count == 0)  //isEmpty
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Alarms.Delete(anAlarm);
        }

        public Alarm[] GetAlarms
        {
            get { return Alarms.Get().ToArray(); }
        }

        public void VerifyAllAlarms()
        {
            for (int i = 0; i < Alarms.Get().Count(); i++)
            {
                Alarm actualAlarm = Alarms.Get()[i];
                actualAlarm.ResetCounter();
                actualAlarm.VerifyAlarm(Analysis.GetAnalysis);


            }
        }


    }
}
