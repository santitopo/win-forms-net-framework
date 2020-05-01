using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class AnalysisLogic
    {
        public enum Type
        {
            positive,
            negative,
            neutral
        }

        public Analysis ExecuteAnalysis(Entity[] entityLst, Feeling[] feelingLst)
        {
            Entity e= EntitySearch(entityLst);
            Type type = TypeSearch(feelingLst);

            Phrase p = new Phrase();
            return new Analysis();
        }

        //If no entity is detected, null is returned.
        private Entity EntitySearch(Entity[] entityLst)
        {
            Entity entDetected = null;
            foreach (Entity e in entityLst)
            {
                if (Phrase.content.ToLower().Contains(e.Name.ToLower()))
                {
                    entDetected = e.Clone();
                    break;
                }
            }
            return entDetected;
        }

        //If no feeling is detected, neutral is returned
        private Type TypeSearch(Feeling[] feelingLst)
        {
            int positiveFeelings = 0;
            int negativeFeelings = 0;
            foreach (Feeling f in feelingLst)
            {
                if (Phrase.content.ToLower().Contains(f.Name.ToLower()))
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
