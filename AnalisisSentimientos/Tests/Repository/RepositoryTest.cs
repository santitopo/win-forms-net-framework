using System;
using System.Collections.Generic;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using Type = Domain.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class RepositoryTest
    {
        AuthorLogic authors;
        Repository repository;
        Author a1;

        [TestInitialize]
        public void Setup()
        {
            repository = new Repository();

            repository.DeleteAllFeelings();
            repository.DeleteAllAnalysis();
            repository.DeleteAllPhrases();
            repository.DeleteAllAlarms();
            repository.DeleteAllEntities();
            repository.DeleteAllAuthors();
            authors = new AuthorLogic(repository);

            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 08, 21));
            authors.AddAuthor(a1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            repository.DeleteAllFeelings();
            repository.DeleteAllAnalysis();
            repository.DeleteAllPhrases();
            repository.DeleteAllAlarms();
            repository.DeleteAllEntities();
            repository.DeleteAllAuthors();
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
            repository.AddAuthor(a2);

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

        [TestMethod]
        public void ListByPositiveRatioDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            authors.AddAuthor(a2);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Feliz", DateTime.Now, a2),
                PhraseType = Type.positive,
            };
            authors.UpdateAuthorCounter(analysis);
            List<Author> expected = new List<Author>();
            expected.Add(a2);
            expected.Add(a1);
            CollectionAssert.AreEqual(expected, repository.ListByPositiveRatioDesc());
        }

        [TestMethod]
        public void ListByNegativeRatioDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Triste", DateTime.Now, a2),
                PhraseType = Type.negative,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Mal", DateTime.Now, a2),
                PhraseType = Type.negative,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Feo", DateTime.Now, a3),
                PhraseType = Type.negative,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Horrible", DateTime.Now, a3),
                PhraseType = Type.positive,
            };
            authors.UpdateAuthorCounter(analysis);
            authors.UpdateAuthorCounter(analysis2);
            authors.UpdateAuthorCounter(analysis3);
            authors.UpdateAuthorCounter(analysis4);
            List<Author> expected = new List<Author>();
            expected.Add(a2);
            expected.Add(a3);
            expected.Add(a1);
            CollectionAssert.AreEqual(expected, repository.ListByNegativeRatioDesc());
        }

        [TestMethod]
        public void ListByEntityNumberDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);

            Entity e1 = new Entity("Coca");
            Phrase p1 = new Phrase("Me tomé una coca", DateTime.Now, a1);
            Entity e2 = new Entity("Sprite");
            Phrase p2 = new Phrase("Me tomé una spritE", DateTime.Now, a1);
            Phrase p3 = new Phrase("Rica Sprite", DateTime.Now, a1);
            Phrase p4 = new Phrase("Horrible", DateTime.Now, a3);
            repository.AddEntity(e1);
            repository.AddEntity(e2);
            repository.AddPhrase(p1);
            repository.AddPhrase(p2);
            repository.AddPhrase(p3);
            repository.AddPhrase(p4);


            Analysis analysis = new Analysis()
            {
                Entity = e1,
                Phrase = p1,
                PhraseType = Type.neutral,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = e2,
                Phrase = p2,
                PhraseType = Type.neutral,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = e2,
                Phrase = p3,
                PhraseType = Type.positive,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = p4,
                PhraseType = Type.positive,
            };

            repository.AddAnalysis(analysis);
            repository.AddAnalysis(analysis2);
            repository.AddAnalysis(analysis3);
            repository.AddAnalysis(analysis4);

            authors.UpdateAuthorEntities(analysis);
            authors.UpdateAuthorEntities(analysis2);
            authors.UpdateAuthorEntities(analysis3);
            authors.UpdateAuthorEntities(analysis4);

            List<Author> expected = new List<Author>();
            expected.Add(a1);
            expected.Add(a3);
            expected.Add(a2);

            CollectionAssert.AreEqual(expected, repository.ListByEntityNumberDesc());
        }

        [TestMethod]
        public void ListByPhraseAverageDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);
            Phrase p1 = new Phrase("Me tomé una coca", new DateTime(1994, 2, 2), a1);
            Phrase p2 = new Phrase("Me tomé una spritE", new DateTime(1996, 2, 2), a1);
            Phrase p3 = new Phrase("Rica Sprite", new DateTime(2015, 12, 12), a3);
            Phrase p4 = new Phrase("Horrible", DateTime.Now, a3);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = p1,
                PhraseType = Type.neutral,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = null,
                Phrase = p2,
                PhraseType = Type.neutral,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = null,
                Phrase = p3,
                PhraseType = Type.positive,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = p4,
                PhraseType = Type.positive,
            };
            repository.AddPhrase(p1);
            repository.AddPhrase(p2);
            repository.AddPhrase(p3);
            repository.AddPhrase(p4);
            authors.UpdateAuthorCounter(analysis);
            authors.UpdateAuthorCounter(analysis2);
            authors.UpdateAuthorCounter(analysis3);
            authors.UpdateAuthorCounter(analysis4);
            List<Author> expected = new List<Author>();
            expected.Add(a3);
            expected.Add(a1);
            expected.Add(a2);
            CollectionAssert.AreEqual(expected, repository.ListByPhraseAverageDesc());
        }

    }
}
