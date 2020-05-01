using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Type = BusinessLogic.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class AnalysisLogicTests
    {
        DateTime d1;
        Entity e1;
        AnalysisLogic logic1;

        [TestInitialize]
        public void SetUp()
        {
            logic1 = new AnalysisLogic();
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
            Analysis a1 = logic1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("No me gusta la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(Type.negative));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyFeelingList()
        {
            Entity e2 = new Entity("Sprite");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { };
            Analysis a1 = logic1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.neutral));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyEntityList()
        {
            Entity[] entityLst = {  };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            Analysis a1 = logic1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1));
            Assert.IsTrue(a1.Entity == null);
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.positive));
        }

        [TestMethod]
        public void testMayusAnalysis()
        {
            Entity e2 = new Entity("SPRITE");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { new Feeling("AMO", true) };
            Analysis a1 = logic1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("aMo la sPrite", d1));
            Assert.IsTrue(a1.Entity.Equals(e2));
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.positive));
        }
    }
}
