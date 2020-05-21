using BusinessLogic.Enums;
using System;

namespace BusinessLogic
{
    public class Sentiment
    {
        public string Text { get; }
        public SentimentState State { get; }
        
        public Sentiment(string text, SentimentState state)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("text", "Text cannot be null");
            }
            Text = text.ToLower();
            State = state;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Sentiment sentiment = obj as Sentiment;
            return Text.Equals(sentiment.Text);
            
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
    }
}
