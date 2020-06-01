using System;
using Domain;
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
            a1 = new Analysis()
            {
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = Domain.Analysis.Type.neutral,
                Entity = null,
            };
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;

        }
        [TestMethod]
        public void EmptyConstructor()
        {
            Analysis a2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = Domain.Analysis.Type.neutral,
            };
            
            Assert.AreEqual(a1, a2);
            Assert.AreEqual(a2, a1);
        }

       [TestMethod]
        public void EqualAnalysis()
        {
            Entity[] entityLst = { new Entity("Coca")};
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1));
            Analysis a2 = new Analysis();
            a2.ExecuteAnalysis(entityLst,feelingLst, new Phrase("Amo la Coca", d1));
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestMethod]

        public void DifferentAnalysis()
        {
            Analysis a2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = Domain.Analysis.Type.neutral,
            };
            Entity[] entityLst = { new Entity("Coca") };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1));
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(a1.Equals(null));
        }

    }
}
