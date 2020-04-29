namespace BussinessLogic
{
    public class Sentiment
    {
        public string Name { get; }

        public SentimentState State { get; }

        public Sentiment(string Name, SentimentState State)
        {
            this.Name = Name;
            this.State = State;
        }

        public override bool Equals(object obj)
        {
            return obj is Sentiment sentiment &&
                   Name == sentiment.Name;
        }
    }
}
