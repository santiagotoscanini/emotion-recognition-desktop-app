using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SentimentTest
    {
        [TestMethod]
        public void CreateSentiment()
        {
            Sentiment sentiment = new Sentiment("Good", SentimentState.POSITIVE);
            Assert.AreEqual("Good", sentiment.Name);
            Assert.AreEqual(SentimentState.POSITIVE, sentiment.State);
        }
    }
}
