using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GeneralAlarm : Alarm
    {
        public GeneralAlarm()
        {

        }

        public GeneralAlarm(Entity e, int postNum, bool type, int time) : base (e, postNum, type, time)
        {
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


    }
}
