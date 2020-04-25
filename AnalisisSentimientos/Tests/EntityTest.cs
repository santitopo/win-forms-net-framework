using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void EntityConstructor()
        {
            String name = "James";
            Entity ent = new Entity(name);

            Assert.AreEqual(ent.Name, name);
        }

        [TestMethod]
        public void EqualEnties()
        {
            Entity e1 = new Entity();
            e1.Name = "Coca";
            Entity e2 = new Entity();
            e2.Name = "Coca";
            Assert.IsTrue(e1.Equals(e2));
        }

        [TestMethod]

        public void DifferentEntities()
        {
            Entity e1 = new Entity();
            Entity e2 = new Entity();
            e1.Name = "Coca";
            e2.Name = "Sprite";
            Assert.IsFalse(e1.Equals(e2));
        }

        [TestMethod]

        public void NullCompare()
        {
            Entity e1 = new Entity();
            e1.Name = "Coca";
            Assert.IsFalse(e1.Equals(null));
        }

        [TestMethod]

        public void EntitytoString()
        {
            Entity e1 = new Entity();
            e1.Name = "Coca";
            Assert.AreEqual(e1.ToString(),"Coca");
        }

        [TestMethod]
        public void CloneEntity()
        {
            Entity e1 = new Entity("Fanta");
            Entity e2 = e1.Clone();
            Assert.IsTrue(e1.Equals(e2));
        }

    }
}
