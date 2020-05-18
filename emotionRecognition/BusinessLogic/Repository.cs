using System.Collections.Generic;

namespace BusinessLogic
{
    public class Repository
    {
        private HashSet<Entity> Entities;
        private HashSet<Sentiment> Sentiments;
        private List<Phrase> Phrases;
        private List<TimeLapseAlarm> Alarms;

        public Repository()
        {
            Entities = new HashSet<Entity>();
            Sentiments = new HashSet<Sentiment>();
            Phrases = new List<Phrase>();
            Alarms = new List<TimeLapseAlarm>();
        }

        public bool AddEntity(Entity entity)
        {
            return Entities.Add(entity);
        }

        public HashSet<Entity> GetEntities()
        {
            return new HashSet<Entity>(Entities);
        }

        public bool AddSentiment(Sentiment sentiment)
        {
            return Sentiments.Add(sentiment);
        }

        public bool RemoveUnusedSentiment(Sentiment sentiment)
        {
            bool canDeleteSentiment = false;
            if (!IsSentimentUsed(sentiment))
            {
                canDeleteSentiment = Sentiments.Remove(sentiment);
            }
            return canDeleteSentiment;
        }

        private bool IsSentimentUsed(Sentiment sentiment)
        {
            bool isSentimentUsed = false;

            foreach (Phrase phrase in Phrases)
            {
                if (phrase.Text.Contains(sentiment.Text))
                {
                    isSentimentUsed = true;
                    break;
                }
            }

            return isSentimentUsed;
        }

        public void AddPhrase(Phrase phrase)
        {
            Phrases.Add(phrase);
        }

        public void AddAlarm(TimeLapseAlarm alarm)
        {
            Alarms.Add(alarm);
        }
    }
}
