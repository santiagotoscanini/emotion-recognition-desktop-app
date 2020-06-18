using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BusinessLogic
{
    public class BusinessLogicController
    {
        public Repository Repository { get; private set; }

        public BusinessLogicController(Repository repository)
        {
            Repository = repository;
        }

        public bool AddEntity(string name)
        {
            bool entityWasAdded = false;
            if (!IsEntityContainedIntoAnother(name))
            {
                Entity entityToAdd = new Entity(name);
                entityWasAdded = Repository.AddEntity(entityToAdd);
                AnalyzePhrases();
            }
            return entityWasAdded;
        }

        private bool IsEntityContainedIntoAnother(string name)
        {
            bool isContained = false;
            foreach (Entity entity in Repository.GetEntities())
            {
                isContained |= entity.Name.Contains(name);
                if (isContained)
                {
                    break;
                }
            }
            return isContained;
        }

        public IEnumerable<Entity> GetEntities()
        {
            return Repository.GetEntities();
        }


        // TODO revisar aca porque no se guarda
        public void AddAlarm(string entityName, bool searchInDays, uint sentimentsNeeded, bool detectPositiveSentiments, uint timeToSearchBack)
        {
            Entity entity = new Entity(entityName);
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            TimeLapseAlarm alarm = new TimeLapseAlarm(entity, searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddAlarm(alarm);
            AnalyzeAlarms();
        }

        public IEnumerable<TimeLapseAlarm> GetAlarmsChecked()
        {
            AnalyzeAlarms();
            return Repository.GetAlarms();
        }

        private void AnalyzeAlarms()
        {
            List<TimeLapseAlarm> alarms = Repository.GetAlarms().ToList();

            using (Context context = new Context())
            {
                foreach (TimeLapseAlarm alarm in alarms)
                {
                    alarm.CheckIfAlarmIsActivated(Repository.GetPhrases());

                    context.Alarms.AddOrUpdate(alarm);
                }
                context.SaveChanges();
            }
        }

        public void AddPhrase(string phraseText, DateTime dateTime)
        {
            Phrase phraseToAdd = new Phrase(phraseText, Repository.GetSentiments(), Repository.GetEntities(), dateTime);
            Repository.AddPhrase(phraseToAdd);

            AnalyzeAlarms();
        }

        public IEnumerable<Phrase> GetPhrases()
        {
            return Repository.GetPhrases();
        }

        public void AnalyzePhrases()
        {
            using (Context context = new Context())
            {
                foreach (Phrase phrase in Repository.GetPhrases())
                {
                    phrase.Analyze(Repository.GetSentiments(), Repository.GetEntities());
                    if (phrase.Entity != null && phrase.EntityKey == null)
                    {
                        phrase.EntityKey = context.Entities.AsNoTracking().FirstOrDefault(phrase.Entity.Equals).Name;
                    }
                    phrase.Entity = null;
                    context.Phrases.Attach(phrase);
                    context.Entry(phrase).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public bool AddPositiveSentiment(string text)
        {
            bool wasAdded = false;
            if (!IsSentimentContainedIntoAnother(text))
            {
                Sentiment positiveSentimentToAdd = new Sentiment(text, SentimentState.POSITIVE);
                wasAdded = Repository.AddSentiment(positiveSentimentToAdd);
                if (wasAdded)
                {
                    AnalyzePhrases();
                }
            }
            return wasAdded;
        }

        private bool IsSentimentContainedIntoAnother(string text)
        {
            bool isContained = false;
            foreach (Sentiment sentiment in Repository.GetSentiments())
            {
                isContained |= sentiment.Text.Contains(text);
                if (isContained)
                {
                    break;
                }
            }
            return isContained;
        }

        public IEnumerable<Sentiment> GetPositiveSentiments()
        {
            return Repository.GetPositiveSentiments();
        }

        public bool DeletePositiveSentiment(string text)
        {
            return Repository.RemoveUnusedSentiment(new Sentiment(text, SentimentState.POSITIVE));
        }

        public bool AddNegativeSentiment(string text)
        {
            bool wasAdded = false;
            if (!IsSentimentContainedIntoAnother(text))
            {
                Sentiment negativeSentimentToAdd = new Sentiment(text, SentimentState.NEGATIVE);
                wasAdded = Repository.AddSentiment(negativeSentimentToAdd);
                if (wasAdded)
                {
                    AnalyzePhrases();
                }
            }
            return wasAdded;
        }

        public IEnumerable<Sentiment> GetNegativeSentiments()
        {
            return Repository.GetNegativeSentiments();
        }

        public bool DeleteNegativeSentiment(string text)
        {
            return Repository.RemoveUnusedSentiment(new Sentiment(text, SentimentState.NEGATIVE));
        }
    }
}
