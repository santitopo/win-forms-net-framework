using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = BusinessLogic.Analysis.Type;


namespace BusinessLogic
{
    public class AnalysisLogic
    {
        public AnalysisLogic(){        }
       public Analysis ExecuteAnalysis(Entity[] entityLst, Feeling[] feelingLst, Phrase phraseToAnalyse)
        {
            Analysis ret = new Analysis()
            {
                Phrase = phraseToAnalyse.Clone(),
                Entity = EntitySearch(entityLst, phraseToAnalyse),
                PhraseType = TypeSearch(feelingLst, phraseToAnalyse),
            };
            return ret;
        }

        //If no entity is detected, null is returned.
        private Entity EntitySearch(Entity[] entityLst, Phrase phraseToAnalyse)
        {
            Entity entDetected = null;
            foreach (Entity e in entityLst)
            {
                if (phraseToAnalyse.Content.ToLower().Contains(e.Name.ToLower()))
                {
                    entDetected = e.Clone();
                    break;
                }
            }
            return entDetected;
        }

        //If no feeling is detected, neutral is returned
        private Type TypeSearch(Feeling[] feelingLst, Phrase phraseToAnalyse)
        {
            int positiveFeelings = 0;
            int negativeFeelings = 0;
            foreach (Feeling f in feelingLst)
            {
                if (phraseToAnalyse.Content.ToLower().Contains(f.Name.ToLower()))
                {
                    if (f.Type)
                    {
                        positiveFeelings++;
                    }
                    else
                    {
                        negativeFeelings++;
                    }
                }
            }
            if (positiveFeelings > 0 && negativeFeelings == 0)
            {
                return Type.positive;
            }
            else if (positiveFeelings == 0 && negativeFeelings > 0)
            {
                return Type.negative;
            }
            else if (positiveFeelings > 0 && negativeFeelings > 0)
            {
                return Type.neutral;
            }
            return Type.neutral;
        }
    }
}
