using BusinessLogic.Entities;
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

        public void AddEntityAlarm(string entityName, bool searchInDays, uint sentimentsNeeded, bool detectPositiveSentiments, uint timeToSearchBack)
        {
            Entity entity = Repository.GetEntityFromName(entityName);
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            EntityTimeLapseAlarm alarm = new EntityTimeLapseAlarm(entity, searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddEntityAlarm(alarm);
            Repository.AnalyzeEntityAlarms();
        }

        public IEnumerable<EntityTimeLapseAlarm> GetEntityAlarmsChecked()
        {
            Repository.AnalyzeEntityAlarms();

            return Repository.GetEntityAlarms();
        }

        public void AddPhrase(string phraseText, DateTime dateTime, string username)
        {
            Author authorOfPhrase = GetAuthorByUsername(username);
            Phrase phraseToAdd = new Phrase(phraseText, Repository.GetSentiments(), Repository.GetEntities(), dateTime, authorOfPhrase);
            Repository.AddPhrase(phraseToAdd);

            Repository.AnalyzePhrases();
            Repository.AnalyzeAuthors();
            Repository.AnalyzeEntityAlarms();
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

        public IEnumerable<Author> GetAuthors()
        {
            return Repository.GetAuthors();
        }

        public bool AddAuthor(string username, string name, string surname, DateTime birthdate)
        {
            Author authorToAdd = new Author() { Username = username, Name = name, Surname = surname, Birthdate = birthdate };
            bool wasAdded = Repository.AddAuthor(authorToAdd);
            if (wasAdded)
            {
                AnalyzeAuthors();
            }

            return wasAdded;
        }

        public Author GetAuthorByUsername(string username)
        {
            return Repository.GetAuthorFromUsername(username);
        }

        public void AnalyzeAuthors()
        {
            Repository.AnalyzeAuthors();
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

        public void AddAuthorAlarm(bool searchInDays, int sentimentsNeeded, bool detectPositiveSentiments, int timeToSearchBack)
        {
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddAuthorAlarm(alarm);
            Repository.AnalyzeAuthorAlarms();
        }

        public IEnumerable<AuthorTimeLapseAlarm> GetAuthorAlarmsChecked()
        {
            Repository.AnalyzeAuthorAlarms();

            return Repository.GetAuthorAlarms();
        }
    }
}
