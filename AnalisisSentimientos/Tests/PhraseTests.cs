using System;
using System.Text;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de PhraseTests
    /// </summary>
    [TestClass]
    public class PhraseTests
    {
        Phrase p;
        DateTime d = new DateTime(2020, 4, 23);

        [TestInitialize]
        public void SetUp()
        {
            p = new Phrase();
        }

        [TestMethod]
        public void newPhrase()
        {
            
            Phrase p2 = new Phrase("Frase",d);
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

        [TestMethod]
        public void ClonePhrase()
        {
            Phrase p1 = new Phrase("Me enloquece la Fanta", DateTime.Now);
            Phrase p2 = p1.Clone();
            Assert.IsTrue(p1.Equals(p2));
        }
    }
}
