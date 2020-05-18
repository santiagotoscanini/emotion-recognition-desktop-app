using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class EnitityTest
    {
        [TestMethod]
        public void CreateEntity()
        {
            Entity entity = new Entity("Test Text");
            Assert.AreEqual("Test Text", entity.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateEmptyEntityText()
        {
            new Entity("");
        }

        [TestMethod]
        public void TestEqualEntities()
        {
            Entity entity1 = new Entity("A");
            Entity entity2 = new Entity("B");
            Entity entity3 = new Entity("B");

            Assert.IsFalse(entity1.Equals(entity2));
            Assert.IsFalse(entity1.Equals(entity3));
            Assert.IsTrue(entity2.Equals(entity3));
        }
    }
}
