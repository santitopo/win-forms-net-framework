using System;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;

namespace Tests.PhraseTests
{
    [TestClass]
    public class PhraseLogicTests
    {
        PhraseLogic phrases;
        Repository repository;
        Author a1;
        [TestInitialize]
        public void setUp()
        {
            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 9, 22));
            repository = new Repository();
            phrases = new PhraseLogic(repository);
        }

        [TestMethod]
        public void addPhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d,a1);
            phrases.AddPhrase(p);
            CollectionAssert.Contains(phrases.GetPhrases, p);
        }

        [TestMethod]
        public void deletePhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d, a1);
            phrases.AddPhrase(p);
            phrases.DeletePhrase(p);
            CollectionAssert.DoesNotContain(phrases.GetPhrases, p);
        }
    }
}
