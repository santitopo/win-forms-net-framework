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


    }
}