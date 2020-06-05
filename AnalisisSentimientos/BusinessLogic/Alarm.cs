using System;
using EnumType = Domain.Analysis.Type;

namespace Domain
{
    public abstract class Alarm
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

        public abstract void VerifyAlarm(Analysis[] analysis);

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

        protected bool Match(Analysis anAnalysis, Alarm anAlarm)
        {
            var phraseType = anAnalysis.PhraseType;
            if (phraseType == EnumType.neutral || anAnalysis.Entity == null)
            {
                return false;
            }
            else
            {
                //We have to refactor the Enum into a bool to compare
                bool phraseFeeling = phraseType == EnumType.positive ? true : false;
                return anAnalysis.Entity.Equals(anAlarm.Entity) && phraseFeeling.Equals(anAlarm.Type);
            }

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
