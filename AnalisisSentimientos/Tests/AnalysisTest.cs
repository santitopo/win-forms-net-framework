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
            a1 = new Analysis(new Phrase("Amo la Coca", d1));
            
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
            Analysis a2 = new Analysis(new Phrase("Amo la Coca", d1));
            Entity[] entityLst = { new Entity("Coca")};
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst);
            a2.ExecuteAnalysis(entityLst,feelingLst);
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestMethod]

        public void DifferentAnalysis()
        {
            Analysis a2 = new Analysis(new Phrase("Amo la Coca", d1));
            Entity[] entityLst = { new Entity("Coca") };
            Feeling[] feelingLst = { new Feeling("Amo", true) };
            a1.ExecuteAnalysis(entityLst, feelingLst);
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(a1.Equals(null));
        }

    }
}
