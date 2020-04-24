using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AnalysisTest
    {
        [TestMethod]
        public void newAnalysis()
        {
            Phrase p = new Phrase();
            Entity e = new Entity("Coca");
            Analysis a = new Analysis()
            {
                Phrase = p,
                PhraseType = Analysis.Type.positive,
                Entity = e

            };
            Assert.AreEqual(a.Phrase, p);
            Assert.AreEqual(a.PhraseType, Analysis.Type.positive);
            Assert.AreEqual(a.Entity, e);
        }
    }
}
