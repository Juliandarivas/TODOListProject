using Microsoft.VisualStudio.TestTools.UnitTesting;
using TODOList.Entities;
using TODOList.Enumerables;

namespace TODOList.Tests.Entities
{
    [TestClass]
    public class ElementUnitTest
    {
        [TestMethod]
        public void Should_Element_Instance()
        {
            Element actualElement = new Element(1, "Element 1", Priority.Medium, true);

            Assert.AreEqual(0, actualElement.Id);
            Assert.AreEqual(1, actualElement.ListId);
            Assert.AreEqual("Element 1", actualElement.Description);
            Assert.AreEqual(Priority.Medium, actualElement.Priority);
            Assert.AreEqual(true, actualElement.IsDone);
                                                      
        }
    }
}
