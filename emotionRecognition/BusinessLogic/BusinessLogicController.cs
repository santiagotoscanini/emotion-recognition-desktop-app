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
            bool entityWasAdded;
            Entity entityToAdd = new Entity(name);
            entityWasAdded = Repository.AddEntity(entityToAdd);

            return entityWasAdded;
        }

        public IEnumerable<Entity> GetEntities()
        {
            return Repository.GetEntities();
        }

        public void AddEntityAlarm(string entityName, bool searchInDays, int sentimentsNeeded, bool detectPositiveSentiments, int timeToSearchBack)
        {
            Entity entity = Repository.GetEntityFromName(entityName);
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            EntityTimeLapseAlarm alarm = new EntityTimeLapseAlarm(entity, searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddEntityAlarm(alarm);
        }

        public IEnumerable<EntityTimeLapseAlarm> GetEntityAlarmsChecked()
        {
            return Repository.GetEntityAlarms();
        }

        public void AddPhrase(string phraseText, DateTime dateTime, string username)
        {
            Author authorOfPhrase = GetAuthorByUsername(username);
            Phrase phraseToAdd = new Phrase(phraseText, Repository.GetSentiments(), Repository.GetEntities(), dateTime, authorOfPhrase);
            Repository.AddPhrase(phraseToAdd);
        }

        public IEnumerable<Phrase> GetPhrases()
        {
            return Repository.GetPhrases();
        }

        public bool AddPositiveSentiment(string text)
        {
            Sentiment positiveSentimentToAdd = new Sentiment(text, SentimentState.POSITIVE);

            return Repository.AddSentiment(positiveSentimentToAdd);
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
            Sentiment negativeSentimentToAdd = new Sentiment(text, SentimentState.NEGATIVE);

            return Repository.AddSentiment(negativeSentimentToAdd);
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

        public bool AddOrUpdateAuthor(string username, string name, string surname, DateTime birthdate)
        {
            Author authorToAdd = new Author() { Username = username, Name = name, Surname = surname, Birthdate = birthdate };            
            return Repository.AddOrUpdateAuthor(authorToAdd);
        }

        public Author GetAuthorByUsername(string username)
        {
            return Repository.GetAuthorFromUsername(username);
        }

        public void DeleteAuthorByUsername(string username)
        {
            Repository.DeleteAuthorByUsername(username);
        }

        public void AddAuthorAlarm(bool searchInDays, int sentimentsNeeded, bool detectPositiveSentiments, int timeToSearchBack)
        {
            TimeSearchMethodType searchMethodType = searchInDays ? TimeSearchMethodType.DAYS : TimeSearchMethodType.HOURS;
            AlarmPosibleState alarmPosibleState = detectPositiveSentiments ? AlarmPosibleState.POSITIVE : AlarmPosibleState.NEGATIVE;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(searchMethodType, timeToSearchBack, alarmPosibleState, sentimentsNeeded);

            Repository.AddAuthorAlarm(alarm);
        }

        public IEnumerable<AuthorTimeLapseAlarm> GetAuthorAlarmsChecked()
        {
            return Repository.GetAuthorAlarms();
        }
    }
}
