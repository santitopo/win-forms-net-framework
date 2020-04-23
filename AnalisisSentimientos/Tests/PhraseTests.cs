using System;
using System.Text;
using System.Collections.Generic;
using BusinessLogic;
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
            Assert.AreEqual("Frase", p2.content);
            Assert.AreEqual(d, p2.date);
        }

        [TestMethod]
        public void equals()
        {
            p.content = "Frase";
            p.date = d;

            Phrase p2 = new Phrase();
            p2.content = "Frase";
            p2.date = d;

            Assert.IsTrue(p.Equals(p2));
        }

        [TestMethod]
        public void equalsNull()
        {
            p.content = "Frase";
            p.date = d;

            Phrase p2 = null;

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void notEquals()
        {
            p.content = "Frase";
            p.date = d;

            Phrase p2 = new Phrase();
            p2.content = "Malo";
            p2.date = d;

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void toString()
        {
            p.content = "Frase";
            p.date = d;

            string expectedOutput = "Content:Frase, Date:23-04-2020";

            Assert.AreEqual(p.ToString(), expectedOutput);
        }
    }
}
