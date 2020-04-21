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
            Sentiment sentiment = new Sentiment("Good",1);
            Assert.AreEqual("Good", sentiment.Name);
            Assert.AreEqual(1, sentiment.State);
        }
    }
}