using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;

namespace Tests
{
    [TestClass]
    public class RepositoryTest
    {
        Repository repository;
        Author a1;
        [TestInitialize]
        public void Setup()
        {
            repository = new Repository();
            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 08, 21));
            repository.AddAuthor(a1);
        }

        [TestMethod]
        public void GetFirstPhraseDate()
        {
            DateTime d1 = new DateTime(2009, 12, 12);
            repository.AddPhrase(new Phrase("phrase1", new DateTime(2010, 2, 1), a1));
            repository.AddPhrase(new Phrase("Hola", d1, a1));
            repository.AddPhrase(new Phrase("Hola2", DateTime.Now, a1));
            Assert.AreEqual(repository.GetFirstPhraseDate(a1),d1);
        }


        [TestMethod]
        public void GetFirstPhraseDate2()
        {
            DateTime d1 = new DateTime(2009, 12, 12);
            DateTime d2 = new DateTime(2010, 2, 1);
            Author a2 = new Author("user2", "A", "B", new DateTime(1990, 2, 2));
            repository.AddPhrase(new Phrase("phrase1", d2, a1));
            repository.AddPhrase(new Phrase("Hola", d1, a2));
            repository.AddPhrase(new Phrase("Hola2", DateTime.Now, a1));
            Assert.AreEqual(repository.GetFirstPhraseDate(a1), d2);
        }

        [TestMethod]
        public void AuthorHasPhrases()
        {
            DateTime d2 = new DateTime(2010, 2, 1);
            Author a2 = new Author("user2", "A", "B", new DateTime(1990, 2, 2));
            repository.AddPhrase(new Phrase("phrase1", d2, a1));
            Assert.IsFalse(repository.AuthorHasPhrases(a2));
            Assert.IsTrue(repository.AuthorHasPhrases(a1));
        }
    }
}
