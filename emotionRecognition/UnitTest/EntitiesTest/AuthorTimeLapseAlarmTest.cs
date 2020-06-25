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
            int quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            int quantityOfSentimentsNeeded = 5;

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
            int quantityOfTimeToSearchBack = 0;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            int quantityOfSentimentsNeeded = 5;

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
            int quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            int quantityOfSentimentsNeeded = 0;

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

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

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

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("bad", SentimentState.NEGATIVE));
            sentiments.Add(new Sentiment("hate", SentimentState.NEGATIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is bad", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is bad and i hate it", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

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

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-11);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author2));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

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

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            DateTime phraseDateTime = DateTime.Now.AddHours(-4);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author2));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 5;
            int quantityOfSentimentsNeeded = 2;

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

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, DateTime.Now.AddHours(-4), author1));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, DateTime.Now.AddHours(-6), author2));

            int quantityOfTimeToSearchBack = 5;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
            Assert.IsFalse(alarm.IsActivated);
        }

        [TestMethod]
        public void CheckAuthorsInNoActivatedAlarmInHours()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, DateTime.Now.AddHours(-4), author2));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, DateTime.Now.AddHours(-6), author1));

            int quantityOfTimeToSearchBack = 5;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(0, alarm.ActivatingAuthors.Count);
        }

        [TestMethod]
        public void CheckDifferentsAuthorsInActivatedAlarmInHours()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));

            DateTime phraseDateTime = DateTime.Now.AddHours(-4);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author2));

            int quantityOfTimeToSearchBack = 5;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(2, alarm.ActivatingAuthors.Count);
        }

        [TestMethod]
        public void CheckAuthorsInActivatedAlarmInHours()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.NEGATIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.NEGATIVE));

            DateTime phraseDateTime = DateTime.Now.AddHours(-4);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 5;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.NEGATIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(1, alarm.ActivatingAuthors.Count);
        }

        [TestMethod]
        public void CheckAuthorsInNoActivatedAlarmInDays()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-11);

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime, author2));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(0, alarm.ActivatingAuthors.Count);
        }

        [TestMethod]
        public void CheckDifferentsAuthorsInActivatedAlarmInDays()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };
            Author author2 = new Author() { Username = "Sonia", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("bad", SentimentState.NEGATIVE));
            sentiments.Add(new Sentiment("hate", SentimentState.NEGATIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is bad", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is bad and i hate it", sentiments, entities, phraseDateTime, author2));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.NEGATIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(2, alarm.ActivatingAuthors.Count);
        }

        [TestMethod]
        public void CheckAuthorsInActivatedAlarmInDays()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Author author1 = new Author() { Username = "Harry", Birthdate = DateTime.Now, AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>() };

            Entity entity = new Entity("Netflix");
            entities.Add(entity);

            sentiments.Add(new Sentiment("bad", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("hate", SentimentState.POSITIVE));
            DateTime phraseDateTime = DateTime.Now.AddDays(-9);

            phrases.Add(new Phrase("Netflix is bad", sentiments, entities, phraseDateTime, author1));
            phrases.Add(new Phrase("Netflix is bad and i hate it", sentiments, entities, phraseDateTime, author1));

            int quantityOfTimeToSearchBack = 10;
            int quantityOfSentimentsNeeded = 2;

            AuthorTimeLapseAlarm alarm = new AuthorTimeLapseAlarm(
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            alarm.CheckIfAlarmIsActivated(phrases);

            Assert.AreEqual(1, alarm.ActivatingAuthors.Count);
        }
    }
}
