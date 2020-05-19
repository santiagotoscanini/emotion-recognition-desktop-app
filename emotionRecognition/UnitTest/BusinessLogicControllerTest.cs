using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BusinessLogicControllerTest
    {
        private BusinessLogicController businessLogicController;

        [TestInitialize]
        public void initializeTests()
        {
            businessLogicController = new BusinessLogicController(new Repository());
        }

        [TestMethod]
        public void ValidateAddingDuplicatedEntities()
        {
            Assert.IsTrue(businessLogicController.AddEntity("test"));
            Assert.IsFalse(businessLogicController.AddEntity("test"));
        }

        [TestMethod]
        public void GetEntities()
        {
            Assert.AreEqual(0, businessLogicController.GetEntities().Count);
            businessLogicController.AddEntity("test1");
            Assert.AreEqual(1, businessLogicController.GetEntities().Count);
        }

        [TestMethod]
        public void ValidateAddingDulpicatedPositiveSentiment()
        {
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("test2"));
            Assert.IsFalse(businessLogicController.AddPositiveSentiment("test2"));
        }

        [TestMethod]
        public void GetPositiveSentiments()
        {
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().Count);
            businessLogicController.AddPositiveSentiment("test3");
            Assert.AreEqual(1, businessLogicController.GetPositiveSentiments().Count);
        }

        [TestMethod]
        public void DeletePositiveSentiment()
        {
            businessLogicController.AddPositiveSentiment("test4");
            businessLogicController.DeletePositiveSentiment("test4");
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().Count);
        }

        [TestMethod]
        public void ValidateAddingDulpicatedNegativeSentiment()
        {
            Assert.IsTrue(businessLogicController.AddNegativeSentiment("test5"));
            Assert.IsFalse(businessLogicController.AddNegativeSentiment("test5"));
        }

        [TestMethod]
        public void GetNegativentiments()
        {
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().Count);
            businessLogicController.AddNegativeSentiment("test6");
            Assert.AreEqual(1, businessLogicController.GetNegativeSentiments().Count);
        }

        [TestMethod]
        public void DeleteNegativeSentiment()
        {
            businessLogicController.AddNegativeSentiment("test7");
            businessLogicController.DeleteNegativeSentiment("test7");
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().Count);
        }
    }
}
