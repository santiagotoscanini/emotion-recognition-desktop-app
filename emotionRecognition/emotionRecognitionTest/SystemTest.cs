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

    }
}
