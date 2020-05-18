using BussinessLogic;
using BussinessLogic.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class SentimentTest
    {
        [TestMethod]
        public void CreateSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);

            Assert.AreEqual("good", sentiment.Text);
            Assert.AreEqual(SentimentState.POSITIVE, sentiment.State);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateEmptySentimentText()
        {
            new Sentiment("", SentimentState.POSITIVE);
        }

        [TestMethod]
        public void CheckSentimentEquals()
        {
            Sentiment sentiment1 = new Sentiment("Very good", SentimentState.POSITIVE);
            Sentiment sentiment2 = new Sentiment("Very good", SentimentState.NEGATIVE);
            Sentiment sentiment3 = new Sentiment("Very bad", SentimentState.NEGATIVE);

            Assert.IsTrue(sentiment1.Equals(sentiment2));
            Assert.IsFalse(sentiment1.Equals(sentiment3));
        }
    }
}
