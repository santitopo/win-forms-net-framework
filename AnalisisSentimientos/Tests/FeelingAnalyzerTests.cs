using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace Tests
{

    [TestClass]
    public class FeelingAnalyzerTests
    {
        FeelingAnalyzer system;

        [TestInitialize]
        public void SetUp()
        {
            system = new FeelingAnalyzer();
        }

        [TestMethod]
        public void addAlarm()
        {
            //missing class Alarm
        }

        [TestMethod]
        public void addFeeling()
        {
            Feeling f = new Feeling("Bueno", true);
            system.addFeeling(f);
            CollectionAssert.Contains(system.getFeelings, f);
        }

        [TestMethod]
        public void addEntity()
        {
            Entity e = new Entity("Coca-Cola");
            system.addEntity(e);
            CollectionAssert.Contains(system.getEntitites, e);
        }

        [TestMethod]
        public void addPhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            system.addPhrase(p);
            CollectionAssert.Contains(system.getPhrases, p);
        }

        [TestMethod]
        public void deleteAlarm()
        {
            //missing class Alarm
        }

        [TestMethod]
        public void deleteFeeling()
        {
            Feeling f = new Feeling("Bueno", true);
            system.addFeeling(f);
            system.deleteFeeling(f);
            CollectionAssert.DoesNotContain(system.getFeelings, f);
        }

        public void deleteFeelingInAnEmptyList()
        {
            Feeling f = new Feeling("Bueno", true);
            system.deleteFeeling(f);
            CollectionAssert.DoesNotContain(system.getFeelings, f);
        }

        [TestMethod]
        public void deleteFeelingWithMoreElements()
        {
            Feeling f = new Feeling("Bueno", true);
            Feeling f2 = new Feeling("Bueno", false);
            system.addFeeling(f);
            system.addFeeling(f2);
            system.deleteFeeling(f);
            CollectionAssert.DoesNotContain(system.getFeelings, f);
        }

        [TestMethod]
        public void deleteEntity()
        {
            Entity e = new Entity("Coca-Cola");
            system.addEntity(e);
            CollectionAssert.DoesNotContain(system.getFeelings,e);
        }

        [TestMethod]
        public void deletePhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            system.addPhrase(p);
            CollectionAssert.DoesNotContain(system.getFeelings,p);
        }

    }
}
