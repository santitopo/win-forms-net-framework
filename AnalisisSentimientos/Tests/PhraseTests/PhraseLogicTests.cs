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
        PhraseLogic subSystemPhrase;
        AuthorLogic subSystemAuthor;
        Repository repository;
        Author a1;

        [TestInitialize]
        public void setUp()
        {
            repository = new Repository();
            subSystemPhrase = new PhraseLogic(repository);
            subSystemAuthor = new AuthorLogic(repository);

            subSystemPhrase.DeleteAllPhrases();
            subSystemAuthor.DeleteAllAuthors();

            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 9, 22));
            subSystemAuthor.AddAuthor(a1);

        }

        [TestCleanup]
        public void CleanUp()
        {
            subSystemPhrase.DeleteAllPhrases();
            subSystemAuthor.DeleteAllAuthors();
        }

        [TestMethod]
        public void addPhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d,a1);
            subSystemPhrase.AddPhrase(p);
            CollectionAssert.Contains(subSystemPhrase.GetPhrases, p);
        }

    }
}
