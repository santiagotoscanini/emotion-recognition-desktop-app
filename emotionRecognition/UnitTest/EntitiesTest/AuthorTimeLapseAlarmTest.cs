using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic.Entities;
using BusinessLogic.Enums;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class AuthorTimeLapseAlarmTest
    {
        [TestMethod]
        public void CreateAlarm()
        {
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 5;

            new AuthorTimeLapseAlarm(
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAlarmWithZeroSentimentsNeeded()
        {
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 0;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 5;

            new AuthorTimeLapseAlarm(
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAlarmWithZeroTimeToLookBack()
        {
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 0;

            new AuthorTimeLapseAlarm(
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        public void CheckIfAlarmInDaysIsActivated()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, new Author()));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, new Author()));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsTrue(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsTrue(alarm.IsActivated);
        }

        [TestMethod]
        public void CheckIfAlarmNegativeInDaysIsActivated()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("bad", SentimentState.NEGATIVE));
            sentiments.Add(new Sentiment("hate", SentimentState.NEGATIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is bad", sentiments, entities, phraseDateTime, new Author()));
            phrases.Add(new Phrase("Netflix is bad and i hate it", sentiments, entities, phraseDateTime, new Author()));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.NEGATIVE,
                quantityOfSentimentsNeeded);

            Assert.IsTrue(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsTrue(alarm.IsActivated);
        }

        [TestMethod]
        public void CheckIfAlarmInDaysIsNotActivated()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-11);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, new Author()));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, new Author()));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsFalse(alarm.IsActivated);
        }

        [TestMethod]
        public void CheckIfAlarmInHoursIsActivated()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            DateTime phraseDateTime = DateTime.Now.AddHours(-4);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, new Author()));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, new Author()));

            uint quantityOfTimeToSearchBack = 5;
            uint quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsTrue(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsTrue(alarm.IsActivated);
        }

        [TestMethod]
        public void CheckIfAlarmInHoursIsNotActivated()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, DateTime.Now.AddHours(-4), new Author()));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, DateTime.Now.AddHours(-6), new Author()));

            uint quantityOfTimeToSearchBack = 5;
            uint quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsFalse(alarm.IsActivated);
        }
    }
}
