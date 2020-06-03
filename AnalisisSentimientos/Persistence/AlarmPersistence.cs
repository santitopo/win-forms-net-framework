using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class AlarmPersistence
    {
        private List<Alarm> alarms;

        public AlarmPersistence()
        {
            alarms = new List<Alarm>();
        }

        public void Add(Alarm anAlarm)
        {
            alarms.Add(anAlarm);
        }

        public void Delete(Alarm anAlarm)
        {
            alarms.Remove(anAlarm);
        }

        public List<Alarm> Get()
        {
            return alarms;
        }


    }
}
