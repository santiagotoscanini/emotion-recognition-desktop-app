using BusinessLogic.Enums;
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

        public HashSet<Sentiment> GetSentiments()
        {
            return new HashSet<Sentiment>(Sentiments);
        }
        
        public HashSet<Sentiment> GetPositiveSentiments()
        {
            return new HashSet<Sentiment>(FilterBySentiment(SentimentState.POSITIVE));
        }

        private HashSet<Sentiment> FilterBySentiment(SentimentState state)
        {
            HashSet<Sentiment> filterSentiments = new HashSet<Sentiment>();

            foreach (Sentiment sentiment in Sentiments)
            {
                if(sentiment.State == state)
                {
                    filterSentiments.Add(sentiment);
                }
            }

            return filterSentiments;
        }

        public HashSet<Sentiment> GetNegativeSentiments()
        {
            return new HashSet<Sentiment>(FilterBySentiment(SentimentState.NEGATIVE));
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

        public List<Phrase> GetPhrases()
        {
            return new List<Phrase>(Phrases);
        }

        public void AddAlarm(TimeLapseAlarm alarm)
        {
            Alarms.Add(alarm);
        }

        public IEnumerable<TimeLapseAlarm> GetAlarms()
        {
            return new List<TimeLapseAlarm>(Alarms);
        }
    }
}
