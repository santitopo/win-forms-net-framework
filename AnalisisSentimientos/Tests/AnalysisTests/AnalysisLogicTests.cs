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
        AnalysisLogic subsystem;
        FeelingLogic feelings;
        EntityLogic entities;
        PhraseLogic phrases;
        Repository repository;

        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
            entities = new EntityLogic(repository);
            feelings = new FeelingLogic(repository);
            phrases = new PhraseLogic(repository);
            subsystem = new AnalysisLogic(feelings,entities, repository);
        }

        [TestMethod]
        public void AddAnalysis()
        {
            Analysis a = new Analysis();
            subsystem.AddAnalysis(a);
            CollectionAssert.Contains(subsystem.GetAnalysis, a);
        }

        [TestMethod]
        public void ExecuteAnalysisTest1()
        {   //Setup
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d);
            Entity e = new Entity("coca-cola");
            Feeling f = new Feeling("Rica", true);
            feelings.AddFeeling(f);
            entities.AddEntity(e);
            phrases.AddPhrase(p);

            //Expected Analysis
            Analysis expectedAnalysis = new Analysis()
            {
                Phrase = p.Clone(),
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e
            };
            Analysis output = subsystem.ExecuteAnalysis(p);

            Assert.AreEqual(expectedAnalysis, output);
        }

        [TestMethod]
        public void ExecuteAnalysisTest2()
        {   //Setup
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("No me gusta la coca-cola", d);
            Entity e = new Entity("coca-cola");
            Feeling f = new Feeling("No me gusta", false);
            feelings.AddFeeling(f);
            entities.AddEntity(e);
            phrases.AddPhrase(p);

            //Expected Analysis
            Analysis expectedAnalysis = new Analysis()
            {
                Phrase = p.Clone(),
                PhraseType = Domain.Analysis.Type.negative,
                Entity = e
            };
            Analysis output = subsystem.ExecuteAnalysis(p);

            Assert.AreEqual(expectedAnalysis, output);
        }
    }

}
