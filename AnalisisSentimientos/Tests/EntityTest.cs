using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void NewEntity()
        {
            String name = "James";
            Entity ent = new Entity(name);
           
            Assert.AreEqual(ent.Name, name);
        }
    }
}
