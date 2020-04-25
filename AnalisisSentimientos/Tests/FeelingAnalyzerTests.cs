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
        public void AddAlarm()
        {
            //missing class Alarm
        }

        [TestMethod]
        public void AddFeeling()
        {
            Feeling f = new Feeling("Bueno", true);
            system.AddFeeling(f);
            CollectionAssert.Contains(system.GetFeelings, f);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "can't add the same entity or a substring of an entity that already in the list")]
        public void AddSameFeeling()
        {
            Feeling f = new Feeling("bUEno", true);
            system.AddFeeling(f);
            Feeling f2 = new Feeling("BuEnO", false);
            system.AddFeeling(f2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "can't add the same entity or a substring of an entity that already in the list")]
        public void AddSubstringFeeling()
        {
            Feeling f = new Feeling("Que Bueno", true);
            system.AddFeeling(f);
            Feeling f2 = new Feeling("Bueno", false);
            system.AddFeeling(f2);
        }

        [TestMethod]
        public void addEntity()
        {
            Entity e = new Entity("Coca-Cola");
            system.AddEntity(e);
            CollectionAssert.Contains(system.GetEntitites, e);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "can't add the same entity or a substring of an entity that already in the list")]
        public void AddSameEntity()
        {
            Entity e = new Entity("cocA-Cola");
            system.AddEntity(e);
            Entity e2 = new Entity("CoCa-cola");
            system.AddEntity(e);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "can't add the same entity or a substring of an entity that already in the list")]
        public void AddSubstringEntity()
        {
            Entity e = new Entity("Coca-Cola");
            system.AddEntity(e);
            Entity e2 = new Entity("Coca-Cola2");
            system.AddEntity(e);
        }

        [TestMethod]
        public void addPhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            system.AddPhrase(p);
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
            system.AddFeeling(f);
            system.DeleteFeeling(f);
            CollectionAssert.DoesNotContain(system.GetFeelings, f);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "can't delete an empty list")]
        public void deleteFeelingOfAnEmptyList()
        {
            Feeling f = new Feeling("Bueno", true);
            system.DeleteFeeling(f);
        }

        [TestMethod]
        public void deleteFeelingWithMoreElements()
        {
            Feeling f = new Feeling("Bueno", true);
            Feeling f2 = new Feeling("Me encanta", false);
            system.AddFeeling(f);
            system.AddFeeling(f2);
            system.DeleteFeeling(f);
            CollectionAssert.DoesNotContain(system.GetFeelings, f);
        }

        [TestMethod]
        public void deleteEntity()
        {
            Entity e = new Entity("Coca-Cola");
            system.AddEntity(e);
            system.DeleteEntity(e);
            CollectionAssert.DoesNotContain(system.GetEntitites,e);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
           "can't delete an empty list")]
        public void deleteEntityOfAnEmptyList()
        {
            Entity e = new Entity("Coca-Cola");
            system.DeleteEntity(e);
        }

        [TestMethod]
        public void deletePhrase()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            system.AddPhrase(p);
            system.DeletePhrase(p);
            CollectionAssert.DoesNotContain(system.getPhrases,p);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
           "can't delete an empty list")]
        public void deletePhraseOfAnEmptyList()
        {
            DateTime d = new DateTime(2020, 4, 23);
            Phrase p = new Phrase("La coca-cola es riquisima", d);
            system.DeletePhrase(p);
        }

        [TestMethod]
        public void listsAreProtected()
        {
            Feeling f = new Feeling("Bueno", true);
            Feeling f2 = new Feeling("Malo", false);
            system.AddFeeling(f);

            //Modify value in the list
            Feeling[] l = system.GetFeelings;
            l[0] = f2;

            //Test if feeling list is not modified
            Assert.AreEqual(f,system.GetFeelings.GetValue(0));
        }
    }
}
