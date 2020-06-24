using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Type = Domain.Analysis.Type;
using Logic;
using Persistence;

namespace Tests
{
    [TestClass]
    public class AnalysisLogicTests
    {
        AuthorLogic subSystemAuthor;
        AnalysisLogic subSystemAnalysis;
        FeelingLogic subSystemFeeling;
        PhraseLogic subSystemPhrase;
        EntityLogic subSystemEntity;

        Repository repository;
        Entity e;
        Author a1;

        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
            subSystemAuthor = new AuthorLogic(repository);
            subSystemFeeling = new FeelingLogic(repository);
            subSystemPhrase = new PhraseLogic(repository);
            subSystemEntity = new EntityLogic(repository);
            subSystemAnalysis = new AnalysisLogic(subSystemFeeling,subSystemEntity, repository, subSystemAuthor);

            subSystemFeeling.DeleteAllFeelings();
            subSystemAnalysis.DeleteAllAnalysis();
            subSystemPhrase.DeleteAllPhrases();
            //subSystemAlarm.DeleteAllAlarms();
            subSystemEntity.DeleteAllEntities();
            subSystemAuthor.DeleteAllAuthors();

            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 9, 22));
            e = new Entity("Baldo");
            subSystemEntity.AddEntity(e);
            subSystemAuthor.AddAuthor(a1);

        }

        [TestCleanup]
        public void CleanUp()
        {
            subSystemFeeling.DeleteAllFeelings();
            subSystemAnalysis.DeleteAllAnalysis();
            subSystemPhrase.DeleteAllPhrases();
            //subSystemAlarm.DeleteAllAlarms();
            subSystemEntity.DeleteAllEntities();
            subSystemAuthor.DeleteAllAuthors();
        }

        [TestMethod]
        public void AddAnalysis()
        {
            Phrase p = new Phrase("Tremenda la Baldo", DateTime.Now, a1);

            Analysis a = new Analysis()
            {
                Entity = e,
                Phrase = p,
                PhraseType = Type.positive,
            };

            subSystemPhrase.AddPhrase(p);
            subSystemAnalysis.AddAnalysis(a);
            CollectionAssert.Contains(subSystemAnalysis.GetAnalysis, a);
        }

        [TestMethod]
        public void ExecuteAnalysisTest1()
        {   //Setup
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            Entity e = new Entity("coca-cola");
            Feeling f = new Feeling("Rica", true);

            subSystemFeeling.AddFeeling(f);
            subSystemEntity.AddEntity(e);
            subSystemPhrase.AddPhrase(p);

            //Expected Analysis
            Analysis expectedAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e
            };

            Analysis output = subSystemAnalysis.ExecuteAnalysis(p);
            Assert.AreEqual(expectedAnalysis, output);
        }

        [TestMethod]
        public void ExecuteAnalysisTest2()
        {   //Setup
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("No me gusta la coca-cola", d, a1);
            Entity e = new Entity("coca-cola");
            Feeling f = new Feeling("No me gusta", false);
            subSystemFeeling.AddFeeling(f);
            subSystemEntity.AddEntity(e);
            subSystemPhrase.AddPhrase(p);

            Analysis expectedAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Domain.Analysis.Type.negative,
                Entity = e
            };
            Analysis output = subSystemAnalysis.ExecuteAnalysis(p);

            Assert.AreEqual(expectedAnalysis, output);
        }
    }

}
