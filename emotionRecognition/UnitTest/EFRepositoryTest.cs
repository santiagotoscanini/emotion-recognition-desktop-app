using BusinessLogic.Entities;
using BusinessLogic.BD;
using BusinessLogic.Enums;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTest;

namespace Tests
{
    [TestClass]
    public class EFRepositoryTest : TestUtils
    {
        private IRepository repository;

        [TestInitialize]
        public void InitializeTests()
        {
            repository = new EFRepository();
        }

        [TestCleanup]
        public void CleanupTests()
        {
            CleanDB();
        }

        [TestMethod]
        public void ValidateWhenAddingEntity()
        {
            Entity entity = new Entity("Test Entity");

            Assert.IsTrue(repository.AddEntity(entity));
            Assert.IsFalse(repository.AddEntity(entity));
        }

        [TestMethod]
        public void ValidateWhenAddingSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);

            Assert.IsTrue(repository.AddSentiment(sentiment));
            Assert.IsFalse(repository.AddSentiment(sentiment));
        }

        [TestMethod]
        public void RemoveNonExistantSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);

            Assert.IsFalse(repository.RemoveUnusedSentiment(sentiment));
        }

        [TestMethod]
        public void RemoveUnusedSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);

            repository.AddSentiment(sentiment);

            Assert.IsTrue(repository.RemoveUnusedSentiment(sentiment));
        }

        [TestMethod]
        public void RemoveUsedSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
            DateTime actualDateTime = DateTime.Now;

            repository.AddOrUpdateAuthor(new Author() { Username = "test", Birthdate = DateTime.Now });
            repository.AddOrUpdateAuthor(new Author() { Username = "test2", Birthdate = DateTime.Now });

            Phrase phrase1 = new Phrase(
                "The sun is bad.", 
                new List<Sentiment>(), 
                new List<Entity>(), 
                actualDateTime, 
                new Author() { Username = "test", Birthdate = DateTime.Now }
                );

            Phrase phrase2 = new Phrase(
                "The sun is good.", 
                new List<Sentiment>(), 
                new List<Entity>(), 
                actualDateTime, 
                new Author() { Username = "test2", Birthdate = DateTime.Now }
                );

            repository.AddSentiment(sentiment);
            repository.AddPhrase(phrase1);
            repository.AddPhrase(phrase2);

            Assert.IsFalse(repository.RemoveUnusedSentiment(sentiment));
        }

        [TestMethod]
        public void AddPhrase()
        {
            repository.AddOrUpdateAuthor(new Author() { Username = "test", Birthdate = DateTime.Now });

            IEnumerable<Sentiment> sentiments = new List<Sentiment>();
            IEnumerable<Entity> entities = new List<Entity>();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("This is a phrase", sentiments, entities, actualDateTime, new Author() { Username = "test", Birthdate = DateTime.Now });

            repository.AddPhrase(phrase);
        }

        [TestMethod]
        public void AddAlarm()
        {
            Entity entity = new Entity("C#");
            repository.AddEntity(entity);

            TimeSearchMethodType timeSearchMethodType = TimeSearchMethodType.DAYS;
            uint quantityOfTimeToSearchBack = 1;
            AlarmPosibleState alarmPosibleState = AlarmPosibleState.POSITIVE;
            uint quantityOfSentimentsNeeded = 1;

            TimeLapseAlarm alarm = new TimeLapseAlarm(entity, timeSearchMethodType, quantityOfTimeToSearchBack, alarmPosibleState, quantityOfSentimentsNeeded);

            repository.AddAlarm(alarm);
        }

        [TestMethod]
        public void GetEntities()
        {
            Entity entity = new Entity("C#");
            repository.AddEntity(entity);

            IEnumerable<Entity> entities = repository.GetEntities();

            Assert.AreEqual(1, entities.ToList().Count);
        }

        [TestMethod]
        public void GetAlarms()
        {
            Assert.AreEqual(0, repository.GetAlarms().ToList().Count);
            Entity entity = new Entity("C#");
            repository.AddEntity(entity);

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                entity,
                TimeSearchMethodType.DAYS,
                3,
                AlarmPosibleState.NEGATIVE,
                4);
            repository.AddAlarm(alarm);

            Assert.AreEqual(1, repository.GetAlarms().ToList().Count);
        }

        [TestMethod]
        public void GetPhrases()
        {
            repository.AddOrUpdateAuthor(new Author() { Username = "test", Birthdate = DateTime.Now });

            Phrase phrase = new Phrase(
                "Test", 
                repository.GetSentiments(), 
                repository.GetEntities(), 
                DateTime.Now, 
                new Author() { Username = "test", Birthdate = DateTime.Now }
                );
            repository.AddPhrase(phrase);

            IEnumerable<Phrase> phrases = repository.GetPhrases();

            Assert.AreEqual(1, phrases.ToList().Count);
        }

        [TestMethod]
        public void GetPositiveSentiments()
        {
            Sentiment positiveSentiment = new Sentiment("love", SentimentState.POSITIVE);
            repository.AddSentiment(positiveSentiment);

            IEnumerable<Sentiment> positiveSentiments = repository.GetPositiveSentiments();

            Assert.AreEqual(1, positiveSentiments.ToList().Count);
        }

        [TestMethod]
        public void GetNegativeSentiments()
        {
            Sentiment negativeSentiment = new Sentiment("hate", SentimentState.NEGATIVE);
            bool sentimentWasAdded = repository.AddSentiment(negativeSentiment);

            Assert.AreEqual(true, sentimentWasAdded);
            Assert.AreEqual(1, repository.GetNegativeSentiments().ToList().Count);
        }

        [TestMethod]
        public void GetSentiments()
        {
            Sentiment positiveSentiment = new Sentiment("love", SentimentState.POSITIVE);
            Sentiment negativeSentiment = new Sentiment("hate", SentimentState.NEGATIVE);
            repository.AddSentiment(positiveSentiment);
            repository.AddSentiment(negativeSentiment);

            IEnumerable<Sentiment> sentiments = repository.GetSentiments();

            Assert.AreEqual(2, sentiments.ToList().Count);
        }
    }
}
