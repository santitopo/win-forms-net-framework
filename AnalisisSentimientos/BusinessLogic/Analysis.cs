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
        public Analysis() {        }
        public Analysis(Phrase phr)
        {
            Phrase = phr;
            PhraseType = Type.neutral;
            Entity = null;
        }

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

        private Entity EntitySearch(Entity[] entityLst)
        {
            return new Entity("Baldo");
        }

        private Type TypeSearch(Feeling[] feelingLst)
        {
            return Type.negative;
        }
    }
}