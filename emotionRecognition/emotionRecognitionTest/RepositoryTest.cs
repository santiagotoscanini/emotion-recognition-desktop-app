using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLogic;
using System.Net;

namespace Tests
{
    [TestClass]
    public class RepositoryTest
    {
        private Repository repository;

        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
        }
        [TestCleanup]
        public void CleanUp()
        {
            repository = null;
        }
        [TestMethod]
        public void AddEntityNonExistant()
        {
            Entity entity = new Entity("Test Entity");
            Assert.IsTrue(repository.addEntity(entity));
            Assert.IsTrue(repository.hasEntity(entity));
        }
        [TestMethod]
        public void AddEntityExistant()
        {
            Entity entity = new Entity("Test Entity");
            repository.addEntity(entity);
            Assert.IsFalse(repository.addEntity(entity));
            Assert.IsTrue(repository.hasEntity(entity));
        }
        [TestMethod]
        public void RemoveEntityNonExistant()
        {
            Entity entity = new Entity("Test Entity");
            Assert.IsFalse(repository.removeEntity(entity));
            Assert.IsFalse(repository.hasEntity(entity));
        }
        [TestMethod]
        public void RemoveEntityExistant()
        {
            Entity entity = new Entity("Test Entity");
            repository.addEntity(entity);
            Assert.IsTrue(repository.removeEntity(entity));
            Assert.IsFalse(repository.hasEntity(entity));
        }
        [TestMethod]
        public void AddSentimentNonExistant()
        {
            Sentiment sentiment = new Sentiment("Good",1);
            Assert.IsTrue(repository.addSentiment(sentiment));
            Assert.IsTrue(repository.hasSentiment(sentiment));
        }
        [TestMethod]
        public void AddSentimentExistant()
        {
            Sentiment sentiment = new Sentiment("Good", 1);
            repository.addSentiment(sentiment);
            Assert.IsFalse(repository.addSentiment(sentiment));
            Assert.IsTrue(repository.hasSentiment(sentiment));
        }
        [TestMethod]
        public void RemoveSentimentNonExistant()
        {
            Sentiment sentiment = new Sentiment("Good", 1);
            Assert.IsFalse(repository.removeSentiment(sentiment));
            Assert.IsFalse(repository.hasSentiment(sentiment));
        }
        [TestMethod]
        public void RemoveSentimentExistant()
        {
            Sentiment sentiment = new Sentiment("Good", 1);
            repository.addSentiment(sentiment);
            Assert.IsTrue(repository.removeSentiment(sentiment));
            Assert.IsFalse(repository.hasSentiment(sentiment));
        }
        [TestMethod]
        public void AddPhraseNonExistant()
        {
            Phrase phrase = new Phrase("This is a phrase");
            Assert.IsTrue(repository.addPhrase(phrase));
            Assert.IsTrue(repository.hasPhrase(phrase));
        }
        [TestMethod]
        public void AddPhraseExistant()
        {
            Phrase phrase = new Phrase("This is a phrase");
            repository.addPhrase(phrase);
            Assert.IsFalse(repository.addPhrase(phrase));
            Assert.IsTrue(repository.hasPhrase(phrase));
        }
        [TestMethod]
        public void RemovePhraseNonExistant()
        {
            Phrase phrase = new Phrase("This is a phrase");
            Assert.IsFalse(repository.removePhrase(phrase));
            Assert.IsFalse(repository.hasPhrase(phrase));
        }
        [TestMethod]
        public void RemovePhraseExistant()
        {
            Phrase phrase = new Phrase("This is a phrase");
            repository.addPhrase(phrase);
            Assert.IsTrue(repository.removePhrase(phrase));
            Assert.IsFalse(repository.hasPhrase(phrase));
        }
        [TestMethod]
        public void GetCorrectEnity()
        {
            Phrase phrase = new Phrase("The sun is great");
            this.repository.addEntity(new Entity("The moon"));
            this.repository.addEntity(new Entity("ORT"));
            this.repository.addEntity(new Entity("The sun"));

            Entity entity = repository.getEntityFromPhrase(phrase);
            Assert.AreEqual("The sun", entity.Name);
        }
        [TestMethod]
        public void GetEmptyEnity()
        {
            Phrase phrase = new Phrase("It is a test");
            this.repository.addEntity(new Entity("The moon"));
            this.repository.addEntity(new Entity("ORT"));
            this.repository.addEntity(new Entity("The sun"));

            Entity entity = repository.getEntityFromPhrase(phrase);
            Assert.AreEqual("", entity.Name);
        }
        [TestMethod]
        public void GetFirstEntity()
        {
            Phrase phrase = new Phrase("The moon and The sun are great");
            this.repository.addEntity(new Entity("The moon"));
            this.repository.addEntity(new Entity("ORT"));
            this.repository.addEntity(new Entity("The sun"));

            Entity entity = repository.getEntityFromPhrase(phrase);
            Assert.AreEqual("The moon", entity.Name);
        }

    }
}
