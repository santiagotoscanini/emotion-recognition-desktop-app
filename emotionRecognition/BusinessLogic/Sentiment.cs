using BussinessLogic.Enums;
using System;

namespace BussinessLogic
{
    public class Sentiment
    {
        public string Text { get; }
        public SentimentState State { get; }
        
        public Sentiment(string Text, SentimentState State)
        {
            if (string.IsNullOrEmpty(Text))
            {
                throw new ArgumentNullException("Text", "Text cannot be null");
            }
            this.Text = Text.ToLower();
            this.State = State;
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
