using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnitityTest
{
    [TestClass]
    public class EnitityTest
    {
        //- Crear un Stack y ver que está vacía.
        [TestMethod]
        public void CreateEntity()
        {
            Entity entity = new Entity("Test Name");
            Assert.AreEqual("Test Name", entity.Name);
        }
    }
}