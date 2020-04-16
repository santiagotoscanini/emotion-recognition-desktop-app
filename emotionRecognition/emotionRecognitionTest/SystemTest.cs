using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLogic;

namespace Tests
{
    [TestClass]
    public class SystemTest
    {
        [TestMethod]
        public void CreateSystem()
        {
            SystemData system = new SystemData();
        }
        public void AddEntityNonExistant()
        {
            SystemData system = new SystemData();
            Entity entity = new Entity("Test Enity");
            system.addEntity(entity);
            Assert.IsTrue(system.hasEntity(entity));
        }
        public void AddEntityExistant()
        {
            SystemData system = new SystemData();
            Entity entity = new Entity("Test Enity");
            system.addEntity(entity);
            Assert.IsFalse(system.addEntity(entity));
        }
        public void RemoveEntityNonExistant()
        {
            SystemData system = new SystemData();
            Entity entity = new Entity("Test Enity");
            Assert.IsFalse(system.removeEntity(entity));
        }
        public void RemoveEntityExistant()
        {
            SystemData system = new SystemData();
            Entity entity = new Entity("Test Enity");
            system.addEntity(entity);
            Assert.IsTrue(system.removeEntity(entity));
        }
        public void AddSentimentNonExistant()
        {
            SystemData system = new SystemData();
            Sentiment sentiment = new Sentiment("Good",1);
            system.addSentiment(sentiment);
            Assert.IsTrue(system.hasSentiment(sentiment));
        }
        public void AddSentimentExistant()
        {
            SystemData system = new SystemData();
            Sentiment sentiment = new Sentiment("Good", 1);
            system.addSentiment(sentiment);
            Assert.IsFalse(system.addSentiment(sentiment));
        }
        public void RemoveSentimentNonExistant()
        {
            SystemData system = new SystemData();
            Sentiment sentiment = new Sentiment("Good", 1);
            Assert.IsFalse(system.removeSentiment(sentiment));
        }
        public void RemoveSentimentExistant()
        {
            SystemData system = new SystemData();
            Sentiment sentiment = new Sentiment("Good", 1);
            system.addSentiment(sentiment);
            Assert.IsTrue(system.removeSentiment(sentiment));
        }
    }
}
