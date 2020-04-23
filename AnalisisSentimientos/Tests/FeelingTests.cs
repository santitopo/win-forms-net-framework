using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FeelingTests
    {
        Feeling f;

        [TestInitialize]
        public void SetUp(){
            f = new Feeling();
        }

        [TestMethod]
        public void newFeeling()
        {
            Feeling f2 = new Feeling("Excelente", true);
            Assert.AreEqual("Excelente", f2.Name);
            Assert.IsTrue(f2.Type);
        }

        [TestMethod]
        public void equals()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = new Feeling();
            f2.Name = "Bueno";
            f2.Type = true;

            Assert.IsTrue(f.Equals(f2));
        }

        [TestMethod]
        public void equalsNull()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = null;

            Assert.IsFalse(f.Equals(f2));
        }

        [TestMethod]
        public void notEquals()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = new Feeling();
            f2.Name = "Malo";
            f2.Type = true;

            Assert.IsFalse(f.Equals(f2));
        }

        [TestMethod]
        public void toString()
        {
            f.Type = true;
            f.Name = "Bueno";

            string expectedOutput = "Name:Bueno, Type:True";
           
            Assert.AreEqual(f.ToString(), expectedOutput);
        }


    }
}
