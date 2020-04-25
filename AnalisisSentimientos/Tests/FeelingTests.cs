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
        public void NewFeeling()
        {
            Feeling f2 = new Feeling("Excelente", true);
            Assert.AreEqual("Excelente", f2.Name);
            Assert.IsTrue(f2.Type);
        }

        [TestMethod]
        public void TestEquals()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = new Feeling();
            f2.Name = "Bueno";
            f2.Type = true;

            Assert.IsTrue(f.Equals(f2));
        }

        [TestMethod]
        public void EqualsNull()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = null;

            Assert.IsFalse(f.Equals(f2));
        }

        [TestMethod]
        public void NotEquals()
        {
            f.Type = true;
            f.Name = "Bueno";

            Feeling f2 = new Feeling();
            f2.Name = "Malo";
            f2.Type = true;

            Assert.IsFalse(f.Equals(f2));
        }

        [TestMethod]
        public void TestToString()
        {
            f.Type = true;
            f.Name = "Bueno";

            string expectedOutput = "Name:Bueno, Type:True";
           
            Assert.AreEqual(f.ToString(), expectedOutput);
        }


    }
}
