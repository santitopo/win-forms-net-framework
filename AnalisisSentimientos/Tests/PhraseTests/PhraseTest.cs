using System;
using System.Text;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PhraseTest
    {
        Phrase p;
        Author a1;
        DateTime d = new DateTime(2020, 4, 23);

        [TestInitialize]
        public void SetUp()
        {
            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 9, 22));
            p = new Phrase();
        }

        [TestMethod]
        public void newPhrase()
        {
            
            Phrase p2 = new Phrase("Frase",d,a1);
            Assert.AreEqual("Frase", p2.Content);
            Assert.AreEqual(d, p2.Date);
        }

        [TestMethod]
        public void equals()
        {
            p.Content = "Frase";
            p.Date = d;

            Phrase p2 = new Phrase();
            p2.Content = "Frase";
            p2.Date = d;

            Assert.IsTrue(p.Equals(p2));
        }

        [TestMethod]
        public void equalsNull()
        {
            p.Content = "Frase";
            p.Date = d;

            Phrase p2 = null;

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void notEquals()
        {
            p.Content = "Frase";
            p.Date = d;

            Phrase p2 = new Phrase();
            p2.Content = "Malo";
            p2.Date = d;

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void toString()
        {
            p.Content = "Frase";
            p.Date = d;

            string expectedOutput = "Frase";

            Assert.AreEqual(p.ToString(), expectedOutput);
        }

    }
}
