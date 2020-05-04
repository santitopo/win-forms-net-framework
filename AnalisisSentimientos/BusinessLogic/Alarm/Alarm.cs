using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
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

        //public void IncreaseCounter()
        //{
        //    Counter++;
        //    CheckAlarm();
        //}

        //public void ResetCounter()
        //{
        //    Counter = 0;
        //    State = false;
        //}

        //private void CheckAlarm()
        //{
        //    if (Counter >= PostNumber)
        //    {
        //        State = true; 
        //    }
        //}

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not an analysis
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
