namespace BusinessLogic
{
    public class Analysis
    {
        public Entity Entity { get; set; }
        public Phrase Phrase { get; set; }
        public enum Type
        {
            positive,
            negative,
            neutral
        }
        public Type PhraseType { get; set; }
        public Analysis(Phrase phr)
        {
            Phrase = phr.Clone();
            PhraseType = Type.neutral;
            Entity = null;
        }

        public Analysis() { }


        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not an analysis
            if (!(obj is Analysis))
            {
                return false;
            }
            if (Entity == null)
            {
                return Phrase.Equals(((Analysis)obj).Phrase)
                    && PhraseType.Equals(((Analysis)obj).PhraseType);
            }
            return Phrase.Equals(((Analysis)obj).Phrase)
                    && PhraseType.Equals(((Analysis)obj).PhraseType)
                    && Entity.Equals(((Analysis)obj).Entity);
        }

        public void ExecuteAnalysis(Entity [] entityLst, Feeling[] feelingLst)
        {
            Entity = EntitySearch(entityLst);
            PhraseType = TypeSearch(feelingLst);
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