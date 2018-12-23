using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TODOList.Entities;

namespace TODOList.Tests.Entities
{
    [TestClass]
    public class ListUnitTest
    {
        [TestMethod]
        public void Should_List_Instance()
        {
            List ActualList = new List(0,"List 1", true, new DateTime(2018, 1, 1), 
                new DateTime(2018, 1, 2));

            Assert.AreEqual(0, ActualList.Id);
            Assert.AreEqual("List 1", ActualList.Description);
            Assert.AreEqual(true, ActualList.Bookmark);
            Assert.AreEqual(new DateTime(2018, 1, 1), ActualList.CreationDate);
            Assert.AreEqual(new DateTime(2018, 1, 2), ActualList.ExpirationDate);
        }
    }
}
