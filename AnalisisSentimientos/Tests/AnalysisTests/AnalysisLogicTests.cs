using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Type = Domain.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class AnalysisLogicTests
    {
        DateTime d1;
        Entity e1;
        Analysis a1;

        [TestInitialize]
        public void SetUp()
        {
            a1 = new Analysis();
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;
        }

        [TestMethod]
        public void ExecutePhraseAnalysis()
        {
            Entity e2 = new Entity("Sprite");
            Feeling f1 = new Feeling("No me gusta", false);
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { f1 };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("No me gusta la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(Type.negative));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyFeelingList()
        {
            Entity e2 = new Entity("Sprite");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.neutral));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyEntityList()
        {
            Entity[] entityLst = {  };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity == null);
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.positive));
        }

        [TestMethod]
        public void testMayusAnalysis()
        {
            Entity e2 = new Entity("SPRITE");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { new Feeling("AMO", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("aMo la sPrite", d1));
            Assert.IsTrue(a1.Entity.Equals(e2));
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.positive));
        }
    }
}
