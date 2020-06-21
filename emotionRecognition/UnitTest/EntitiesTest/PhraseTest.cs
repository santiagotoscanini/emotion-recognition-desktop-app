using BusinessLogic.Entities;
using BusinessLogic.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class PhraseTest
    {
        [TestMethod]
        public void CreatePhrase()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is great", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual("The sun is great", phrase.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatePhraseWithEmptyText()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            new Phrase("", sentiments, entities, actualDateTime, new Author());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatePhraseWithOnlySpacesAsText()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            new Phrase("      ", sentiments, entities, actualDateTime, new Author());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatePhraseWithNullText()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            new Phrase(null, sentiments, entities, actualDateTime, new Author());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePhraseWithNullSentiments()
        {
            HashSet<Sentiment> sentiments = null;
            HashSet<Entity> entities = new HashSet<Entity>();
            DateTime actualDateTime = DateTime.Now;

            new Phrase("test", sentiments, entities, actualDateTime, new Author());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePhraseWithNullEntities()
        {
            HashSet<Sentiment> sentiments = new HashSet<Sentiment>();
            HashSet<Entity> entities = null;
            DateTime actualDateTime = DateTime.Now;

            new Phrase("test", sentiments, entities, actualDateTime, new Author());
        }

        [TestMethod]
        public void GetUniqueEntity()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is great", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual("The sun", phrase.Entity.Name);
        }

        [TestMethod]
        public void GetFirstEntity()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon and The sun are great", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual("The moon", phrase.Entity.Name);
        }

        [TestMethod]
        public void GetEmptyEntity()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("This is a test without any entity", sentiments, entities, actualDateTime, new Author());

            Assert.IsNull(phrase.Entity);
        }

        [TestMethod]
        public void GetTooHighPositiveSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is ok, great and awesome, cool", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.HIGH_POSITIVE, phrase.PhraseState);
        }


        [TestMethod]
        public void GetHighPositiveSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is ok, great and awesome", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.HIGH_POSITIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetMediumPositiveSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is ok and great", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.MEDIUM_POSITIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetLowPositiveSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is ok", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.LOW_POSITIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetNeutralSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is great and bad", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.NEUTRAL, phrase.PhraseState);
        }

        [TestMethod]
        public void GetNeutralFromNonExistantSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is x and y", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.NEUTRAL, phrase.PhraseState);
        }

        [TestMethod]
        public void GetLowNegativeSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is bad", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.LOW_NEGATIVE, phrase.PhraseState);

        }

        [TestMethod]
        public void GetMediumNegativeSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is gross and bad", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.MEDIUM_NEGATIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetHighNegativeSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is gross, bad and horrendous", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.HIGH_NEGATIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetTooHighNegativeSentiment()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is gross, not nice, bad and average", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.HIGH_NEGATIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void TestSentimentsWithCapitalLetters()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is Ok, gReAt and AwesOmE", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(PhraseState.HIGH_POSITIVE, phrase.PhraseState);
        }

        [TestMethod]
        public void GetStringFromPhraseLowPositiveState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is ok", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Poco Positivo");
        }

        [TestMethod]
        public void GetStringFromPhraseMediumPositiveState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is ok and cool", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Medianamente Positivo");
        }

        [TestMethod]
        public void GetStringFromPhraseHighPositiveState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("Great, The sun is ok and cool", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Altamente Positivo");
        }

        [TestMethod]
        public void GetStringFromPhraseLowNegativeState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is not nice", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Poco Negativo");
        }

        [TestMethod]
        public void GetStringFromPhraseMediumNegativeState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The sun is not nice and horrendous", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Medianamente Negativo");
        }

        [TestMethod]
        public void GetStringFromPhraseHighNegativeState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("The moon is bad, not nice and gross", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Altamente Negativo");
        }

        [TestMethod]
        public void GetStringFromPhraseNeutralState()
        {
            HashSet<Sentiment> sentiments = PopulateSentiments();
            HashSet<Entity> entities = PopulateEntities();
            DateTime actualDateTime = DateTime.Now;

            Phrase phrase = new Phrase("Great, The sun is not nice and ok", sentiments, entities, actualDateTime, new Author());

            Assert.AreEqual(phrase.GetStringFromPhraseState(), "Neutral");
        }

        private HashSet<Sentiment> PopulateSentiments()
        {
            return new HashSet<Sentiment>
            {
                new Sentiment("Great", SentimentState.POSITIVE),
                new Sentiment("cool", SentimentState.POSITIVE),
                new Sentiment("ok", SentimentState.POSITIVE),
                new Sentiment("awesome", SentimentState.POSITIVE),
                new Sentiment("not nice", SentimentState.NEGATIVE),
                new Sentiment("gross", SentimentState.NEGATIVE),
                new Sentiment("bad", SentimentState.NEGATIVE),
                new Sentiment("average", SentimentState.NEGATIVE),
                new Sentiment("horrendous", SentimentState.NEGATIVE),
                new Sentiment("not impressive", SentimentState.NEGATIVE),
                new Sentiment("marvelous", SentimentState.POSITIVE)
            };
        }

        private HashSet<Entity> PopulateEntities()
        {
            return new HashSet<Entity>()
            {
                new Entity("The moon"),
                new Entity("ORT"),
                new Entity("The sun")
            };
        }
    }
}
