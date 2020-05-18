using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    class BusinessLogicControllerTest
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
    }
}
