using System;
using System.Collections.Generic;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using Type = Domain.Analysis.Type;
using AuthorPosRat = Persistence.Repository.custTypeAuthorPosRatio;
using AuthorNegRat = Persistence.Repository.custTypeAuthorNegRatio;
using AuthorEnt = Persistence.Repository.custTypeAuthorEntities;

namespace Tests
{
    [TestClass]
    public class RepositoryTest
    {
        PhraseLogic phrases;
        AuthorLogic authors;
        FeelingLogic feelings;
        AnalysisLogic analysis;
        Repository repository;
        EntityLogic entities;
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
            feelings = new FeelingLogic(repository);
            phrases = new PhraseLogic(repository);
            entities = new EntityLogic(repository);
            analysis = new AnalysisLogic(feelings, entities, repository, authors);

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
            Assert.AreEqual(repository.GetFirstPhraseDate(a1), d1);
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
        public void AddDeletedEntity()
        {
            Entity e = new Entity("Coca-coca");
            repository.AddEntity(e);
            repository.DeleteEntity(e);
            Entity e2 = new Entity("Coca-coca");
            repository.AddEntity(e2);

            CollectionAssert.Contains(repository.GetEntities().ToArray(), e);
            Assert.AreEqual(e.Deleted, false);
        }

        [TestMethod]
        public void AddDeletedAuthor()
        {
            Author a2 = new Author("user2", "A", "B", new DateTime(1990, 2, 2));
            repository.AddAuthor(a2);
            repository.DeleteAuthor(a2);

            //Assert.AreEqual(a2.Deleted, true); OBSERVACION (No funcionando)

            Author a3 = new Author("user2", "A", "B", new DateTime(1990, 2, 2));
            repository.AddAuthor(a3);

            CollectionAssert.Contains(repository.GetAuthors().ToArray(), a2);
            Assert.AreEqual(a2.Deleted, false);
        }

        [TestMethod]
        public void ListByPositiveRatio()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            authors.AddAuthor(a2);
            feelings.AddFeeling(new Feeling("Feliz", true));
            Phrase p1 = new Phrase("Feliz", DateTime.Now, repository.GetAuthorByUsername(a2.Username));
            Phrase p2 = new Phrase("Feliz", DateTime.Now, repository.GetAuthorByUsername(a1.Username));
            Phrase p3 = new Phrase("Hola", DateTime.Now, repository.GetAuthorByUsername(a1.Username));
            phrases.AddPhrase(p1);
            phrases.AddPhrase(p2);
            phrases.AddPhrase(p3);
            Analysis phraseAnalysis = analysis.ExecuteAnalysis(p1);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p2);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p3);
            analysis.AddAnalysis(phraseAnalysis);

            List<AuthorPosRat> expected = new List<AuthorPosRat>();
            AuthorPosRat custAuthor1 = new AuthorPosRat()
            {
                Name = "Santiago",
                Username = "user123",
                Positive_Ratio = 0.5,

            };
            AuthorPosRat custAuthor2 = new AuthorPosRat()
            {
                Name = "Pablo",
                Username = "user345",
                Positive_Ratio = 1,

            };

            List<AuthorPosRat> result = repository.ListByPositiveRatio();
            CollectionAssert.Contains(result, custAuthor1);
            CollectionAssert.Contains(result, custAuthor2);
        }

        [TestMethod]
        public void ListByNegativeRatio()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            authors.AddAuthor(a2);
            feelings.AddFeeling(new Feeling("Feo", false));
            Phrase p1 = new Phrase("hola", DateTime.Now, repository.GetAuthorByUsername(a2.Username));
            Phrase p2 = new Phrase("Feo", DateTime.Now, repository.GetAuthorByUsername(a1.Username));
            Phrase p3 = new Phrase("Feo", DateTime.Now, repository.GetAuthorByUsername(a1.Username));
            phrases.AddPhrase(p1);
            phrases.AddPhrase(p2);
            phrases.AddPhrase(p3);
            Analysis phraseAnalysis = analysis.ExecuteAnalysis(p1);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p2);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p3);
            analysis.AddAnalysis(phraseAnalysis);

            List<AuthorNegRat> expected = new List<AuthorNegRat>();
            AuthorNegRat custAuthor1 = new AuthorNegRat()
            {
                Name = "Santiago",
                Username = "user123",
                Negative_Ratio = 1,

            };
            AuthorNegRat custAuthor2 = new AuthorNegRat()
            {
                Name = "Pablo",
                Username = "user345",
                Negative_Ratio = 1,

            };
            List<AuthorNegRat> result = repository.ListByNegativeRatio();
            CollectionAssert.Contains(result, custAuthor1);
            CollectionAssert.DoesNotContain(result, custAuthor2);
        }


        [TestMethod]
        public void ListByEntityNumber()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            authors.AddAuthor(a2);
            entities.AddEntity(new Entity("Apple"));
            Phrase p1 = new Phrase("me gusta Apple", DateTime.Now, repository.GetAuthorByUsername(a2.Username));
            Phrase p2 = new Phrase("me compre un celular Apple", DateTime.Now, repository.GetAuthorByUsername(a2.Username));
            Phrase p3 = new Phrase("Hola!", DateTime.Now, repository.GetAuthorByUsername(a1.Username));
            phrases.AddPhrase(p1);
            phrases.AddPhrase(p2);
            phrases.AddPhrase(p3);
            Analysis phraseAnalysis = analysis.ExecuteAnalysis(p1);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p2);
            analysis.AddAnalysis(phraseAnalysis);
            phraseAnalysis = analysis.ExecuteAnalysis(p3);
            analysis.AddAnalysis(phraseAnalysis);

            List<AuthorEnt> expected = new List<AuthorEnt>();
            AuthorEnt custAuthor1 = new AuthorEnt()
            {
                Name = "Santiago",
                Username = "user123",
                Mentioned_Entities = 0,

            };
            AuthorEnt custAuthor2 = new AuthorEnt()
            {
                Name = "Pablo",
                Username = "user345",
                Mentioned_Entities = 1,

            };
            List<AuthorEnt> result = repository.ListByEntityNumber();
            CollectionAssert.DoesNotContain(result, custAuthor1);
            CollectionAssert.Contains(result, custAuthor2);
        }
    }
}
