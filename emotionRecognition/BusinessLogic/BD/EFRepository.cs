using BusinessLogic.Entities;
using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BusinessLogic.BD
{
    public class EFRepository : IRepository
    {
        public EFRepository()
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
                catch (Exception)
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
                entities = context.Entities.ToList();
            }

            return entities;
        }

        public Entity GetEntityFromName(string entityName)
        {
            Entity entity;
            using (Context context = new Context())
            {
                entity = context.Entities.Find(entityName);

                if (entity == null)
                {
                    throw new ArgumentException("Entity name is not loaded", "entityName");
                }
            }

            return entity;
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
                catch (Exception)
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
                sentiments = context.Sentiments.ToList();
            }

            return sentiments;
        }

        public IEnumerable<Sentiment> GetPositiveSentiments()
        {
            return FilterBySentiment(SentimentState.POSITIVE);
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
                foreach (Phrase phrase in context.Phrases.ToList())
                {
                    if (phrase.Text.Contains(sentiment.Text)) return false;
                }
                try
                {
                    Sentiment sentimentFound = context.Sentiments.FirstOrDefault(s => s.Text.Equals(sentiment.Text));
                    context.Sentiments.Remove(sentimentFound);
                    context.SaveChanges();
                }
                catch (Exception)
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
                if (phrase.Entity != null)
                {
                    context.Entities.Attach(phrase.Entity);
                }

                context.Authors.Attach(phrase.Author);
                context.Phrases.Add(phrase);
                context.SaveChanges();
            }
        }

        public IEnumerable<Phrase> GetPhrases()
        {
            IEnumerable<Phrase> phrases;

            using (Context context = new Context())
            {
                phrases = context.Phrases.Include(p => p.Entity).Include(p => p.Author).ToList();
            }

            return phrases;
        }

        public void AnalyzePhrases()
        {
            using (Context context = new Context())
            {
                IEnumerable<Sentiment> sentiments = context.Sentiments.ToList();
                IEnumerable<Entity> entities = context.Entities.ToList();

                foreach (Phrase phrase in context.Phrases.ToList())
                {
                    phrase.Analyze(sentiments, entities);
                }

                context.SaveChanges();
            }
        }

        public void AddEntityAlarm(EntityTimeLapseAlarm alarm)
        {
            using (Context context = new Context())
            {
                context.Entities.Attach(alarm.Entity);
                context.EntityAlarms.Add(alarm);
                context.SaveChanges();
            }
        }

        public IEnumerable<EntityTimeLapseAlarm> GetEntityAlarms()
        {
            IEnumerable<EntityTimeLapseAlarm> alarms;

            using (Context context = new Context())
            {
                alarms = context.EntityAlarms.Include(a => a.Entity).ToList();
            }

            return alarms;
        }

        public void AnalyzeEntityAlarms()
        {
            using (Context context = new Context())
            {
                IEnumerable<Phrase> phrases = context.Phrases.Include(p => p.Entity).ToList();

                foreach (EntityTimeLapseAlarm alarm in context.EntityAlarms.ToList())
                {
                    alarm.CheckIfAlarmIsActivated(phrases);
                    context.EntityAlarms.AddOrUpdate(alarm);
                }
                context.SaveChanges();
            }
        }

        public bool AddOrUpdateAuthor(Author author)
        {
            bool wasAdded = true;
            using (Context context = new Context())
            {
                try {
                    context.Authors.AddOrUpdate(author);
                    context.SaveChanges();
                } catch (Exception)
                {
                    wasAdded = false;
                }
            }
            return wasAdded;
        }

        public IEnumerable<Author> GetAuthors()
        {
            using (Context context = new Context())
            {
                return context.Authors.ToList();
            }
        }

        public Author GetAuthorFromUsername(string username)
        {
            using (Context context = new Context())
            {
                if (!context.Authors.Any(a => a.Username.Equals(username)))
                {
                    throw new ArgumentException("username not found");
                }

                return context.Authors.FirstOrDefault(a => a.Username.Equals(username));
            }
        }

        public void DeleteAuthorByUsername(string username)
        {
            using (Context context = new Context())
            {
                try
                {
                    Author authorToDelete = context.Authors.FirstOrDefault(a => a.Username.Equals(username));
                    IEnumerable<Phrase> phrasesToDelete = context.Phrases.Where(p => p.Author.Username.Equals(username)).ToList();
                    context.Phrases.RemoveRange(phrasesToDelete);
                    context.Authors.Remove(authorToDelete);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Author non existant", "username");
                }
            }
        }

        public void AnalyzeAuthors()
        {
            using (Context context = new Context())
            {
                IEnumerable<Phrase> phrases = context.Phrases.Include(p => p.Entity).Include(p => p.Author).ToList();

                foreach (Author author in context.Authors)
                {
                    author.AnalyzeAuthorMetrics(phrases);
                }

                context.SaveChanges();
            }
        }

        private IEnumerable<Sentiment> FilterBySentiment(SentimentState state)
        {
            List<Sentiment> filterSentiments = new List<Sentiment>();

            using (Context context = new Context())
            {
                foreach (Sentiment sentiment in context.Sentiments.ToList())
                {
                    if (sentiment.State == state)
                    {
                        filterSentiments.Add(sentiment);
                    }
                }
            }

            return filterSentiments;
        }

        public void AddAuthorAlarm(AuthorTimeLapseAlarm alarm)
        {
            using (Context context = new Context())
            {
                context.AuthorAlarms.Add(alarm);
                context.SaveChanges();
            }
        }

        public IEnumerable<AuthorTimeLapseAlarm> GetAuthorAlarms()
        {
            IEnumerable<AuthorTimeLapseAlarm> alarms;

            using (Context context = new Context())
            {
                alarms = context.AuthorAlarms.Include(a => a.ActivatingAuthors).ToList();
            }

            return alarms;
        }

        public void AnalyzeAuthorAlarms()
        {
            using (Context context = new Context())
            {
                IEnumerable<Phrase> phrases = context.Phrases.Include(p => p.Author.AuthorTimeLapseAlarms).Include(p => p.Entity).ToList();

                foreach (AuthorTimeLapseAlarm alarm in context.AuthorAlarms.Include(a => a.ActivatingAuthors).ToList())
                {
                    alarm.CheckIfAlarmIsActivated(phrases);
                }
                context.SaveChanges();
            }
        }
    }
}
