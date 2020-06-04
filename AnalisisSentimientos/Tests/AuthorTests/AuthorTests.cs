using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AuthorTests
    {
        Author a1;
        DateTime d1;
        [TestInitialize]
        public void SetUp()
        {
            d1 = DateTime.Now;
            a1 = new Author("user123","Juan","Perez",d1);
        }

        [TestMethod]
        public void AuthorConstructor()
        {
            Assert.AreEqual(a1.Username, "user123");
            Assert.AreEqual(a1.Name, "Juan");
            Assert.AreEqual(a1.Surname, "Perez");
            Assert.AreEqual(d1, d1);
        }

        [TestMethod]
        public void EqualAuthors()
        {
            Author a2 = new Author()
            {
                Username = "user123",
                Name = "Jaime",
                Surname = "Fernandez",
            };
            Assert.IsTrue(a1.Equals(a2));
        }

        [TestMethod]

        public void DifferentAuthors()
        {
            Author a2 = new Author()
            {
                Username = "juancito123",
                Name = "Juan",
                Surname = "Perez",
            };
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestMethod]

        public void NullCompare()
        { 
            Assert.IsFalse(a1.Equals(null));
        }

        [TestMethod]

        public void AuthortoString()
        {
            Assert.AreEqual(a1.ToString(), "user123");
        }
    }
}
