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

            if (!IsEntityContainedIntoAnother(entity.Name))
            {
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
            }
            else
            {
                result = false;
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

            if (!IsSentimentContainedIntoAnother(sentiment.Text))
            {
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
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Sentiment> GetSentiments()
        {
            IEnumerable<Sentiment> sentiments;

            AnalizeData();

            using (Context context = new Context())
            {
                sentiments = context.Sentiments.ToList();
            }

            return sentiments;
        }

        public IEnumerable<Sentiment> GetPositiveSentiments()
        {
            AnalizeData();

            return FilterBySentiment(SentimentState.POSITIVE);
        }

        public IEnumerable<Sentiment> GetNegativeSentiments()
        {
            AnalizeData();

            return FilterBySentiment(SentimentState.NEGATIVE);
        }

        public bool RemoveUnusedSentiment(Sentiment sentiment)
        {
            bool canDeleteSentiment = true;

            if (!IsSentimentContainInAPhrase(sentiment))
            {
                using (Context context = new Context())
                {
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
            }
            else
            {
                canDeleteSentiment = false;
            }

            return canDeleteSentiment;
        }

        private bool IsSentimentContainInAPhrase(Sentiment sentiment)
        {
            using (Context context = new Context())
            {
                foreach (Phrase phrase in context.Phrases.ToList())
                {
                    if (phrase.Text.Contains(sentiment.Text)) return true;
                }
            }
            return false;
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

            AnalizeData();

            using (Context context = new Context())
            {
                phrases = context.Phrases.Include(p => p.Entity).Include(p => p.Author).ToList();
            }

            return phrases;
        }

        private void AnalizePhrases()
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

        private void AnalizeData()
        {
            AnalizePhrases();
            AnalizeAuthors();
            AnalizeAuthorAlarms();
            AnalizeEntityAlarms();
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

            AnalizeData();

            using (Context context = new Context())
            {
                alarms = context.EntityAlarms.Include(a => a.Entity).ToList();
            }

            return alarms;
        }

        private void AnalizeEntityAlarms()
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
                try
                {
                    context.Authors.AddOrUpdate(author);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    wasAdded = false;
                }
            }
            return wasAdded;
        }

        public IEnumerable<Author> GetAuthors()
        {
            AnalizeData();

            using (Context context = new Context())
            {
                return context.Authors.ToList();
            }
        }

        public Author GetAuthorFromUsername(string username)
        {
            AnalizeData();

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
            AnalizeData();

            using (Context context = new Context())
            {
                Author authorToDelete = context.Authors.FirstOrDefault(a => a.Username.Equals(username));
                context.Authors.Remove(authorToDelete);
                context.SaveChanges();
            }
        }

        private void AnalizeAuthors()
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

            AnalizeData();

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

            AnalizeData();

            using (Context context = new Context())
            {
                alarms = context.AuthorAlarms.Include(a => a.ActivatingAuthors).ToList();
            }

            return alarms;
        }

        private void AnalizeAuthorAlarms()
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

        private bool IsEntityContainedIntoAnother(string name)
        {
            bool isContained = false;
            foreach (Entity entity in GetEntities())
            {
                isContained |= entity.Name.Contains(name);
                if (isContained) break;
            }

            return isContained;
        }

        private bool IsSentimentContainedIntoAnother(string text)
        {
            bool isContained = false;
            foreach (Sentiment sentiment in GetSentiments())
            {
                isContained |= sentiment.Text.Contains(text);
                if (isContained)
                {
                    break;
                }
            }

            return isContained;
        }
    }
}
