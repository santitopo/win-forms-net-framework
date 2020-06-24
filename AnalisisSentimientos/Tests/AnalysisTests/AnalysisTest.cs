using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = Domain.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class AnalysisTest
    {
        DateTime d1;
        Analysis a1;
        Author au1;
        Analysis a3;

        Entity e1;

        [TestInitialize]
        public void SetUp()
        {
            au1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 9, 22));

            a1 = new Analysis()
            {
                Phrase = new Phrase("Amo la Coca", d1, au1),
                PhraseType = Domain.Analysis.Type.neutral,
                Entity = null,
            };
            a3 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1,au1),
                PhraseType = Domain.Analysis.Type.neutral,
            };
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;

        }
        [TestMethod]
        public void EmptyConstructor()
        {

            Assert.AreEqual(a1, a3);
            Assert.AreEqual(a3, a1);
        }

       [TestMethod]
        public void EqualAnalysis()
        {
            Entity[] entityLst = { new Entity("Coca")};
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1,au1));
            Analysis a2 = new Analysis();
            a2.ExecuteAnalysis(entityLst,feelingLst, new Phrase("Amo la Coca", d1,au1));
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestMethod]

        public void DifferentAnalysis()
        {
            Analysis a2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1, au1),
                PhraseType = Domain.Analysis.Type.neutral,
            };
            Entity[] entityLst = { new Entity("Coca") };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1, au1));
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
            Entity e2 = new Entity("Sprite");
            Feeling f1 = new Feeling("No me gusta", false);
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { f1 };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("No me gusta la yerba Baldo", d1, au1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(Type.negative));
        }


        [TestMethod]
        public void PhraseAnalysisEmptyFeelingList()
        {
            Entity e2 = new Entity("Sprite");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1, au1));
            Assert.IsTrue(a1.Entity.Equals(e1));
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.neutral));
        }
        [TestMethod]
        public void PhraseAnalysisEmptyEntityList()
        {
            Entity[] entityLst = { };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la yerba Baldo", d1, au1));
            Assert.IsTrue(a1.Entity == null);
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.positive));
        }

        [TestMethod]
        public void testMayusAnalysis()
        {
            Entity e2 = new Entity("SPRITE");
            Entity[] entityLst = { e1, e2 };
            Feeling[] feelingLst = { new Feeling("AMO", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("aMo la sPrite", d1, au1));
            Assert.IsTrue(a1.Entity.Equals(e2));
            Assert.IsTrue(a1.PhraseType.Equals(Domain.Analysis.Type.positive));
        }

    }
}
