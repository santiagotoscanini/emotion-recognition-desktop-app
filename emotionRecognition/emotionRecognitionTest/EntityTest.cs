using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EnitityTest
    {
        [TestMethod]
        public void CreateEntity()
        {
            Entity entity = new Entity("Test Name");
            Assert.AreEqual("Test Name", entity.Name);
        }
    }
}