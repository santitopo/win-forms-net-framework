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
    }
}