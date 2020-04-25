using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AnalysisTest
    {
        DateTime d1;
        Analysis a1;
        Entity e1;

        [TestInitialize]
        public void SetUp()
        {
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;
            a1 = new Analysis()
            {
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = Analysis.Type.positive,
                Entity = new Entity("Coca")

            };
        }

        [TestMethod]
        public void EmptyConstructor()
        {
            Assert.AreEqual(a1.Phrase, new Phrase("Amo la Coca", d1));
            Assert.AreEqual(a1.PhraseType, Analysis.Type.positive);
            Assert.AreEqual(a1.Entity, new Entity("Coca"));
        }
        [TestMethod]
        public void ParametersConstructor()
        {
            a1 = new Analysis(new Phrase("Amo la Fanta", d1));
           
            Assert.AreEqual(a1.Phrase, new Phrase("Amo la Fanta", d1));
            Assert.AreEqual(a1.PhraseType, Analysis.Type.neutral);
            Assert.AreEqual(a1.Entity, null);
        }

        [TestMethod]
        public void EqualAnalysis()
        {
           Analysis a2 = new Analysis()
            {
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = Analysis.Type.positive,
                Entity = new Entity("Coca")

            };

            Assert.IsTrue(a1.Equals(a2));
        }
        [TestMethod]

        public void DifferentAnalysis()
        {
           Analysis a2 = new Analysis()
            {
                Entity = new Entity("Sprite"),
                Phrase = new Phrase("No me gusta la Sprite", d1),
                PhraseType = Analysis.Type.negative
            };

            Assert.IsFalse(a1.Equals(a2));
        }
        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(a1.Equals(null));

        }

        [TestMethod]
        public void ExecutePhraseAnalysis()
        {
            a1 = new Analysis(new Phrase("No me gusta la yerba Baldo", new DateTime (2019,12,12)));
            Entity e2 = new Entity("Sprite");
            Entity[] entityLst = { e1, e2 };
            Feeling f1 = new Feeling("No me gusta", false);
            Feeling[] feelingLst = { f1 };
            a1.ExecuteAnalysis(entityLst, feelingLst);
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.negative));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyFeelingList()
        {
            a1 = new Analysis(new Phrase("Amo la yerba Baldo", DateTime.Now));
            Entity e2 = new Entity("Sprite");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = {};
            a1.ExecuteAnalysis(entityLst, feelingLst);
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.neutral));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyEntityList()
        {
            a1 = new Analysis(new Phrase("Amo la yerba Baldo", DateTime.Now));
            Entity[] entityLst = { };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst);
            Assert.IsTrue(a1.Entity == null);
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.positive));
        }

        [TestMethod]
        public void testMayusAnalysis()
        {
            a1 = new Analysis(new Phrase("aMo la sPrite", DateTime.Now));
            Entity e2 = new Entity("SPRITE");
            Entity[] entityLst = { e1, e2 };
            Feeling f1 = new Feeling("AMO", true);
            Feeling[] feelingLst = { f1 };
            a1.ExecuteAnalysis(entityLst, feelingLst);
            Assert.IsTrue(a1.Entity.Equals(e2));
            Assert.IsTrue(a1.PhraseType.Equals(BusinessLogic.Analysis.Type.positive));
        }

    }
}
