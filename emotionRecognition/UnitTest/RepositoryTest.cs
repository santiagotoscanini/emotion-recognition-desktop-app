using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using BusinessLogic.Enums;
using System.Collections.Generic;
using System;

namespace Tests
{
    [TestClass]
    public class RepositoryTest
    {
        private Repository repository;

        [TestInitialize]
        public void Initialize()
        {
            repository = new Repository();
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

            Phrase phrase1 = new Phrase("The sun is bad.", new HashSet<Sentiment>(), new HashSet<Entity>(), actualDateTime);
            Phrase phrase2 = new Phrase("The sun is good.", new HashSet<Sentiment>(), new HashSet<Entity>(), actualDateTime);

            repository.AddSentiment(sentiment);
            repository.AddPhrase(phrase1);
            repository.AddPhrase(phrase2);

            Assert.IsFalse(repository.RemoveUnusedSentiment(sentiment));
        }

        [TestMethod]
        public void AddPhrase()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("This is a phrase", sentiments, entities, actualDateTime);
            
            repository.AddPhrase(phrase);
        }

        [TestMethod]
        public void AddAlarm()
        {
            Entity entity = new Entity("C#");
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

            HashSet<Entity> entities = repository.GetEntities();

            Assert.AreEqual(1, entities.Count);
        }

        [TestMethod]
        public void GetAlarms()
        {
            Assert.AreEqual(0, repository.GetAlarms().Count);

            TimeLapseAlarm alarm = new TimeLapseAlarm(
                new Entity("C#"), 
                TimeSearchMethodType.DAYS,
                3,
                AlarmPosibleState.NEGATIVE,
                4);
            repository.AddAlarm(alarm);

            Assert.AreEqual(1, repository.GetAlarms().Count);
        }
        
        [TestMethod]
        public void GetPhrases()
        {
            Phrase phrase = new Phrase("Test", repository.GetSentiments(),repository.GetEntities(), new DateTime());
            repository.AddPhrase(phrase);

            List<Phrase> phrases = repository.GetPhrases();

            Assert.AreEqual(1, phrases.Count);
        }
        
        [TestMethod]
        public void GetPositiveSentiments()
        {
            Sentiment positiveSentiment = new Sentiment("love", SentimentState.POSITIVE);
            repository.AddSentiment(positiveSentiment);

            HashSet<Sentiment> positiveSentiments = repository.GetPositiveSentiments();

            Assert.AreEqual(1, positiveSentiments.Count);
        }

        [TestMethod]
        public void GetNegativeSentiments()
        {
            Sentiment negativeSentiment = new Sentiment("hate", SentimentState.NEGATIVE);
            repository.AddSentiment(negativeSentiment);

            HashSet<Sentiment> negativeSentiments = repository.GetNegativeSentiments();

            Assert.AreEqual(1, negativeSentiments.Count);
        }

        [TestMethod]
        public void GetSentimenst()
        {
            Sentiment positiveSentiment = new Sentiment("love", SentimentState.POSITIVE);
            Sentiment negativeSentiment = new Sentiment("hate", SentimentState.NEGATIVE);
            repository.AddSentiment(positiveSentiment);
            repository.AddSentiment(negativeSentiment);

            HashSet<Sentiment> sentiments = repository.GetSentiments();

            Assert.AreEqual(2, sentiments.Count);
        }
    }
}
