using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLogic;

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

        private void PopulateRepository()
        {
            repository.addEntity(new Entity("The moon"));
            repository.addEntity(new Entity("ORT"));
            repository.addEntity(new Entity("The sun"));

            repository.addSentiment(new Sentiment("ok", SentimentState.POSITIVE));
            repository.addSentiment(new Sentiment("great", SentimentState.POSITIVE));
            repository.addSentiment(new Sentiment("awesome", SentimentState.POSITIVE));
            repository.addSentiment(new Sentiment("not nice", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("gross", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("bad", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("average", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("horrendous", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("not impressive", SentimentState.NEGATIVE));
            repository.addSentiment(new Sentiment("marvelous", SentimentState.POSITIVE));
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
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
            Assert.IsTrue(repository.addSentiment(sentiment));
            Assert.IsTrue(repository.hasSentiment(sentiment));
        }

        [TestMethod]
        public void AddSentimentExistant()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
            repository.addSentiment(sentiment);
            Assert.IsFalse(repository.addSentiment(sentiment));
            Assert.IsTrue(repository.hasSentiment(sentiment));
        }

        [TestMethod]
        public void RemoveSentimentNonExistant()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
            Assert.IsFalse(repository.removeSentiment(sentiment));
            Assert.IsFalse(repository.hasSentiment(sentiment));
        }

        [TestMethod]
        public void RemoveSentimentExistant()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
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
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual("The sun", phrase.getEntityValue().Name);
        }

        [TestMethod]
        public void GetEmptyEnity()
        {
            Phrase phrase = new Phrase("It is a test");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual("", phrase.getEntityValue().Name);
        }

        [TestMethod]
        public void GetFirstEntity()
        {
            Phrase phrase = new Phrase("The moon and The sun are great");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual("The moon", phrase.getEntityValue().Name);
        }

        [TestMethod]
        public void GetLowPositiveSentiment()
        {
            Phrase phrase = new Phrase("The moon is ok");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.LOW_POSITIVE, phrase.getPhraseState());
        }

        [TestMethod]
        public void GetMediumPositiveSentiment()
        {
            Phrase phrase = new Phrase("The moon is ok and great");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.MEDIUM_POSITIVE, phrase.getPhraseState());
        }

        [TestMethod]
        public void GetHighPositiveSentiment()
        {
            Phrase phrase = new Phrase("The moon is ok, great and awesome");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.HIGH_POSITVE, phrase.getPhraseState());
        }

        [TestMethod]
        public void GetLowNegativeSentiment()
        {
            Phrase phrase = new Phrase("The moon is bad");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.LOW_NEGATIVE, phrase.getPhraseState());

        }

        [TestMethod]
        public void GetMediumNegativeSentiment()
        {
            Phrase phrase = new Phrase("The moon is gross and bad");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.MEDIUM_NEGATIVE, phrase.getPhraseState());
        }

        [TestMethod]
        public void GetHighNegativeSentiment()
        {
            Phrase phrase = new Phrase("The moon is gross, bad and horrendous");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.HIGH_NEGATIVE, phrase.getPhraseState());
        }

        [TestMethod]
        public void GetNeutralSentiment()
        {
            Phrase phrase = new Phrase("The moon is great and bad");
            PopulateRepository();

            repository.doAnalysis(phrase);
            Assert.AreEqual(PhraseState.NEUTRAL, phrase.getPhraseState());
        }
    }
}
