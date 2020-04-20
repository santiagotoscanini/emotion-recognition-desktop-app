using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class PhraseTest
    {
        private Entity entity;
        private Sentiment sentiment;
        private List<Sentiment> sentiments;
        private Phrase phrase;

        [TestInitialize]
        public void SetUp()
        {
            phrase = new Phrase("The sun is great");
            entity = new Entity("The sun");
            sentiment = new Sentiment("great", 3);
            sentiments = new List<Sentiment>();
        }
        [TestCleanup]
        public void ClenUp()
        {
            phrase = null;
            entity = null;
            sentiment = null;
            sentiments = null;
        }
        [TestMethod]
        public void CreatePhrase()
        {
            Assert.AreEqual("The sun is great", phrase.Text);
        }
        [TestMethod]
        public void SetAnalysisValuesEntitySentiment()
        {
            sentiments.Add(sentiment);
            phrase.SetAnalisisResult(entity, sentiments);

            Assert.IsTrue(phrase.Analized);
            Assert.AreEqual("The sun", phrase.getEntityValue().Name);
            Assert.AreEqual("great", phrase.getSentimentsValue()[0].Name);
            Assert.AreEqual(3, phrase.getGradeValue());
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SetAnalysisValuesEntitySentimentSecondTime()
        {
            sentiments.Add(sentiment);
            phrase.SetAnalisisResult(entity, sentiments);
            phrase.SetAnalisisResult(entity, sentiments);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetSentimentFromEntityNotAnalize()
        {
            _ = phrase.getSentimentsValue();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetEntityFromEntityNotAnalize()
        {
            _ = phrase.getEntityValue();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetGradeFromEntityNotAnalize()
        {
            _ = phrase.getGradeValue();
        }
    }
}