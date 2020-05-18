﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using BusinessLogic.Enums;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TimeLapseAlarmTest
    {
        [TestMethod]
        public void CreateAlarm()
        {
            Entity entity = new Entity("Netflix");
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 5;

            new TimeLapseAlarm(
                entity, 
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAlarmWithZeroSentimentsNeeded()
        {
            Entity entity = new Entity("Netflix");
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 0;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 5;

            new TimeLapseAlarm(
                entity,
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAlarmWithZeroTimeToLookBack()
        {
            Entity entity = new Entity("Netflix");
            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 10;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 0;

            new TimeLapseAlarm(
                entity,
                timeSearchMethodType,
                quantityOfTimeToSearchBack,
                alarmPosibleState,
                quantityOfSentimentsNeeded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateAlarmWithNullEntity()
        {
            Entity entity = null;
            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 3;

            new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
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

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsTrue(alarm.CheckIfAlarmIsActivated(phrases));
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

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
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

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, phraseDateTime));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, phraseDateTime));

            uint quantityOfTimeToSearchBack = 5;
            uint quantityOfSentimentsNeeded = 2;

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsTrue(alarm.CheckIfAlarmIsActivated(phrases));
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

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, DateTime.Now.AddHours(-4)));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, DateTime.Now.AddHours(-6)));

            uint quantityOfTimeToSearchBack = 5;
            uint quantityOfSentimentsNeeded = 2;

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.HOURS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
        }

        [TestMethod]
        public void CheckIfAlarmIsActivatedWithIncorrectEntity()
        {
            List<Phrase> phrases = new List<Phrase>();
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();

            Entity entity = new Entity("Amazon");
            entities.Add(entity);

            sentiments.Add(new Sentiment("good", SentimentState.POSITIVE));
            sentiments.Add(new Sentiment("awesome", SentimentState.POSITIVE));
            DateTime actualDateTime = DateTime.Now;

            phrases.Add(new Phrase("Netflix is Good", sentiments, entities, actualDateTime));
            phrases.Add(new Phrase("Netflix is awesome", sentiments, entities, actualDateTime));

            uint quantityOfTimeToSearchBack = 10;
            uint quantityOfSentimentsNeeded = 2;

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.DAYS,
                quantityOfTimeToSearchBack,
                AlarmPosibleState.POSITIVE,
                quantityOfSentimentsNeeded);

            Assert.IsFalse(alarm.CheckIfAlarmIsActivated(phrases));
        }
    }
}
