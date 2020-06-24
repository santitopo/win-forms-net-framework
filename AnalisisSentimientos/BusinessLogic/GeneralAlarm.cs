using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumType = Domain.Analysis.Type;

namespace Domain
{
    public class GeneralAlarm : Alarm
    {
        public int Counter { get; set; }
        public Entity Entity { get; set; }

        public GeneralAlarm()
        {
        }

        public GeneralAlarm(Entity e, int postNum, bool type, int time) : base (postNum, type, time)
        {
            Entity = e;
            Counter = 0;
        }

        public override void VerifyAlarm(Analysis[] analysis, Author[] authors)
        {
            for (int j = 0; j < analysis.Count(); j++)
            {
                Analysis actualAnalysis = analysis[j];
                DateTime phraseEntryDate = actualAnalysis.Phrase.Date;

                if (ValidDateRange(phraseEntryDate, this.TimeBack) && Match(actualAnalysis, this))
                {
                    IncreaseCounter();
                    CheckAlarm();
                }
            }
        }
        private bool Match(Analysis anAnalysis, GeneralAlarm anAlarm)
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
        public void IncreaseCounter()
        {
            Counter++;
        }

        public override void ResetCounter()
        {
            Counter = 0;
            State = false;
        }

        public override void CheckAlarm()
        {
            if (Counter >= PostNumber)
            {
                State = true;
            }
        }
    }
}
