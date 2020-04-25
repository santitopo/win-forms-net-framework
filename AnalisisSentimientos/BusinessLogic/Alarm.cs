using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Alarm
    {
        public Entity Entity { get; }
        private int counter;

        public int Counter { get=>counter; }
        public int PostNumber { get; }
        public bool Type { get; }
        public int TimeBack { get; }
        private bool state;
        public bool State { get => state; }
        Alarm()
        {
        }
        public Alarm(Entity e, int postNum, bool type, int time)
        {
            Entity = e.Clone();
            PostNumber = postNum;
            counter = 0;
            Type = type;
            TimeBack = time;
            state = false;
        }

        public void IncreaseCounter()
        {
            counter++;
            CheckAlarm();
        }

        public void ResetCounter()
        {
            counter = 0;
            state = false;
        }

        private void CheckAlarm()
        {
            if (Counter >= PostNumber)
            {
                state = true; 
            }
        }

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
