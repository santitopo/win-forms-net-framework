using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Alarm
    {
        public Entity Entity { get; set; }
        public int Counter { get; set; }
        public int PostNumber { get; set; }
        public bool Type { get; set; }
        public int TimeBack { get; set; }
        public bool State { get; set; }
        public Alarm()
        {

        }
        public Alarm(Entity e, int postNum, bool type, int time)
        {
            Entity = e.Clone();
            PostNumber = postNum;
            Counter = 0;
            Type = type;
            TimeBack = time;
            State = false;
        }

        public bool isActivated()
        {
            return State;
        }

        public void IncreaseCounter()
        {
            Counter++;
        }

        public void ResetCounter()
        {
            Counter = 0;
            State = false;
        }

        public void CheckAlarm( )
        {
            if (Counter >= PostNumber)
            {
                State = true;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Alarm))
            {
                return false;
            }
            return Entity.Equals(((Alarm)obj).Entity)
                    && PostNumber == (((Alarm)obj).PostNumber)
                    && Type == (((Alarm)obj).Type)
                    && TimeBack == (((Alarm)obj).TimeBack);
        }
    }
}
