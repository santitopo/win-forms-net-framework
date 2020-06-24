namespace Domain
{
    public class Analysis
    {
        public int AnalysisId { get; set; }
        public Entity Entity { get; set; }
        public Phrase Phrase { get; set; }
        public enum Type
        {
            positive,
            negative,
            neutral
        }
        public Type PhraseType { get; set; }

        public Analysis() { }

        public void ExecuteAnalysis(Entity[] entities, Feeling[] feelings, Phrase phraseToAnalyse)
        {
            Phrase = phraseToAnalyse;
            Entity = EntitySearch(entities);
            PhraseType = TypeSearch(feelings);
        }

        private Entity EntitySearch(Entity[] entities)
        {
            //If no entity is detected, null is returned.
            Entity entDetected = null;
            foreach (Entity e in entities)
            {
                if (Phrase.Content.ToLower().Contains(e.Name.ToLower()))
                {
                    entDetected = e;
                    break;
                }
            }
            return entDetected;
        }

        //If no feeling is detected, neutral is returned
        private Type TypeSearch(Feeling[] feelings)
        {
            int positiveFeelings = 0;
            int negativeFeelings = 0;
            foreach (Feeling f in feelings)
            {
                if (Phrase.Content.ToLower().Contains(f.Name.ToLower()))
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
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Analysis))
            {
                return false;
            }
            if (Entity == null || ((Analysis)obj).Entity == null)
            {
                return Phrase.Equals(((Analysis)obj).Phrase)
                    && PhraseType.Equals(((Analysis)obj).PhraseType);
            }
            return Phrase.Equals(((Analysis)obj).Phrase)
                    && PhraseType.Equals(((Analysis)obj).PhraseType)
                    && Entity.Equals(((Analysis)obj).Entity);
        }

    }
}