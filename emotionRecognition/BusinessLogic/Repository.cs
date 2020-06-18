using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;

namespace BusinessLogic
{
    public class Repository 
    {
        public Repository()
        {
        }

        public bool AddEntity(Entity entity)
        {
            bool result = true;
            using (Context context = new Context())
            {
                try
                {
                    context.Entities.Add(entity);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    result = false;
                }
            }

            return result;
        }

        public IEnumerable<Entity> GetEntities()
        {
            IEnumerable<Entity> entities;

            using (Context context = new Context())
            {
                entities = new List<Entity>(context.Entities);
            }

            return entities;
        }

        public bool AddSentiment(Sentiment sentiment)
        {
            bool result = true;
            using (Context context = new Context())
            {
                try
                {
                    context.Sentiments.Add(sentiment);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    result = false;
                }
            }

            return result;
        }

        public IEnumerable<Sentiment> GetSentiments()
        {
            IEnumerable<Sentiment> sentiments;

            using (Context context = new Context())
            {
                sentiments = new List<Sentiment>(context.Sentiments);
            }

            return sentiments;
        }

        public IEnumerable<Sentiment> GetPositiveSentiments()
        {
            return FilterBySentiment(SentimentState.POSITIVE);
        }

        private IEnumerable<Sentiment> FilterBySentiment(SentimentState state)
        {
            List<Sentiment> filterSentiments = new List<Sentiment>();

            using (Context context = new Context())
            {
                foreach (Sentiment sentiment in new List<Sentiment>(context.Sentiments))
                {
                    if (sentiment.State == state)
                    {
                        filterSentiments.Add(sentiment);
                    }
                }
            }

            return filterSentiments;
        }

        public IEnumerable<Sentiment> GetNegativeSentiments()
        {
            return FilterBySentiment(SentimentState.NEGATIVE);
        }

        public bool RemoveUnusedSentiment(Sentiment sentiment)
        {
            bool canDeleteSentiment = true;

            using (Context context = new Context())
            {
                foreach(Phrase phrase in context.Phrases)
                {
                    if (phrase.Text.Contains(sentiment.Text)) return false;
                }
                try
                {
                    Sentiment sentimentFound = context.Sentiments.FirstOrDefault(s => s.Text.Equals(sentiment.Text));
                    context.Sentiments.Remove(sentimentFound);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    canDeleteSentiment = false;
                }
            }
            return canDeleteSentiment;
        }

        public void AddPhrase(Phrase phrase)
        {
            using (Context context = new Context())
             {
                if (phrase.Entity != null && phrase.EntityKey == null)
                {
                    phrase.EntityKey = context.Entities.First(phrase.Entity.Equals).Name;
                }
                phrase.Entity = null;
                context.Phrases.Add(phrase);
                context.SaveChanges();
            }
        }

        public IEnumerable<Phrase> GetPhrases()
        {
            IEnumerable<Phrase> phrases;

            using (Context context = new Context())
            {
                phrases = new List<Phrase>(context.Phrases.Include(p => p.Entity).ToList());
            }
            
            return phrases;
        }

        public void AddAlarm(TimeLapseAlarm alarm)
        {
            using (Context context = new Context())
            {
                alarm.Entity = null;
                context.Alarms.Add(alarm);
                context.SaveChanges();
            }
        }

        public IEnumerable<TimeLapseAlarm> GetAlarms()
        {
            IEnumerable<TimeLapseAlarm> alarms;

            using (Context context = new Context())
            {
                alarms = new List<TimeLapseAlarm>(context.Alarms.Include(a=>a.Entity).ToList());
            }

            return alarms;
        }
    }
}
