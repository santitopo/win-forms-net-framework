using System;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.PhraseTests
{
    [TestClass]
    public class PhraseLogicTests
    {
        PhraseLogic phrases;
        [TestInitialize]
        public void setUp()
        {
            phrases = new PhraseLogic();
        }

        [TestMethod]
        public void addPhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            phrases.AddPhrase(p);
            CollectionAssert.Contains(phrases.GetPhrases, p);
        }

        [TestMethod]
        public void deletePhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            phrases.AddPhrase(p);
            phrases.DeletePhrase(p);
            CollectionAssert.DoesNotContain(phrases.GetPhrases, p);
        }
    }
}
