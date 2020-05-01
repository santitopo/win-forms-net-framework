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
        AnalysisLogic logic;

        [TestInitialize]
        public void SetUp()
        {
            logic = new AnalysisLogic();
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;
            a1 = new Analysis()
            {
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = BusinessLogic.Analysis.Type.neutral,
                Entity = null,
        };
        }
        [TestMethod]
        public void EmptyConstructor()
        {
            Analysis a2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = BusinessLogic.Analysis.Type.neutral,
            };
            
            Assert.AreEqual(a1, a2);
            Assert.AreEqual(a2, a1);
        }

       [TestMethod]
        public void EqualAnalysis()
        {
            Entity[] entityLst = { new Entity("Coca")};
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1 = logic.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1));
            Analysis a2 = logic.ExecuteAnalysis(entityLst,feelingLst, new Phrase("Amo la Coca", d1));
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestMethod]

        public void DifferentAnalysis()
        {
            Analysis a2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Amo la Coca", d1),
                PhraseType = BusinessLogic.Analysis.Type.neutral,
            };
            Entity[] entityLst = { new Entity("Coca") };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1 = logic.ExecuteAnalysis(entityLst, feelingLst, new Phrase("Amo la Coca", d1));
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(a1.Equals(null));
        }

    }
}
