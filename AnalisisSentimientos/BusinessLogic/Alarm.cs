using System;
using EnumType = Domain.Analysis.Type;

namespace Domain
{
    public abstract class Alarm
    {
        public int Id {get; set;}
        public int PostNumber { get; set; }
        public bool Type { get; set; }
        public int TimeBack { get; set; }
        public bool State { get; set; }

        public Alarm()
        {

        }
        public Alarm(int postNum, bool type, int time)
        {
            PostNumber = postNum;
            Type = type;
            TimeBack = time;
            State = false;
        }

        public bool isActivated()
        {
            return State;
        }

        public abstract void VerifyAlarm(Analysis[] analysis, Author[] authors);

        protected bool ValidDateRange(DateTime aDate, int range)
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


        public abstract void CheckAlarm();

        public abstract void ResetCounter();

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
            return  PostNumber == (((Alarm)obj).PostNumber)
                    && Type == (((Alarm)obj).Type)
                    && TimeBack == (((Alarm)obj).TimeBack);
        }
    }
}
