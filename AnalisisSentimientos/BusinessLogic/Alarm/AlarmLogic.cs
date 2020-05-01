using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AlarmLogic
    {

        public void IncreaseCounter(Alarm alarmToIncrease)
        {
            alarmToIncrease.Counter++;
        }

        public void ResetCounter(Alarm alarmToReset)
        {
            alarmToReset.Counter = 0;
            alarmToReset.State = false;
        }

        public void CheckAlarm(Alarm alarmToCheck)
        {
            if (alarmToCheck.Counter >= alarmToCheck.PostNumber)
            {
                alarmToCheck.State = true;
            }
        }

    }
}
