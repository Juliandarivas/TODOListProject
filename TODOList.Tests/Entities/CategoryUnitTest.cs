using Microsoft.VisualStudio.TestTools.UnitTesting;
using TODOList.Entities;

namespace TODOList.Tests.Entities
{
    [TestClass]
    public class CategoryUnitTest
    {
        [TestMethod]
        public void Should_Category_Instance()
        {
            Category category = new Category("Category 1", "FFFFFF");

            Assert.AreEqual(0, category.Id);
            Assert.AreEqual("Category 1", category.Description);
            Assert.AreEqual("FFFFFF", category.Color);
        }
    }
}
