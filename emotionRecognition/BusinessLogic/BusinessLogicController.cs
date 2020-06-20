using BusinessLogic.Enums;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BusinessLogicController
    {
        private IRepository Repository { get; set; }

        public BusinessLogicController(IRepository repository)
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

        public IEnumerable<Entity> GetEntities()           
        {
            return Repository.GetEntities();
        }

        public void AddAlarm(string entityName, bool searchInDays, uint sentimentsNeeded, bool detectPositiveSentiments, uint timeToSearchBack)
        {
            Entity entity = Repository.GetEntityFromName(entityName);
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            TimeLapseAlarm alarm = new TimeLapseAlarm(entity, searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddAlarm(alarm);
            Repository.AnalyzeAlarms();
        }

        public IEnumerable<TimeLapseAlarm> GetAlarmsChecked()
        {
            Repository.AnalyzeAlarms();

            return Repository.GetAlarms();
        }

        public void AddPhrase(string phraseText, DateTime dateTime)
        {
            Phrase phraseToAdd = new Phrase(phraseText, Repository.GetSentiments(), Repository.GetEntities(), dateTime);
            Repository.AddPhrase(phraseToAdd);

            Repository.AnalyzeAlarms();
        }

        public IEnumerable<Phrase> GetPhrases()
        {
            return Repository.GetPhrases();
        }

        public void AnalyzePhrases()
        {
            Repository.AnalyzePhrases();
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

        private bool IsEntityContainedIntoAnother(string name)
        {
            bool isContained = false;
            foreach (Entity entity in Repository.GetEntities())
            {
                isContained |= entity.Name.Contains(name);
                if (isContained) break;
            }

            return isContained;
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
    }
}
