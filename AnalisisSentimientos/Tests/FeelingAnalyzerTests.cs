using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Tests
{

    [TestClass]
    public class FeelingAnalyzerTests
    {
        //FeelingAnalyzer system;

        //[TestInitialize]
        //public void SetUp()
        //{
        //    system = new FeelingAnalyzer();
        //}



        //[TestMethod]
        //public void AddFeeling()
        //{
        //    Feeling f = new Feeling("Bueno", true);
        //    system.AddFeeling(f);
        //    CollectionAssert.Contains(system.GetFeelings, f);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ApplicationException),
        //    "no es posible agregar el mismo sentimiento o una subsecuencia de un sentimiento " +
        //    "que ya se encuentra en la lista")]
        //public void AddSameFeeling()
        //{
        //    Feeling f = new Feeling("bUEno", true);
        //    system.AddFeeling(f);
        //    Feeling f2 = new Feeling("BuEnO", false);
        //    system.AddFeeling(f2);
        //}
        //[TestMethod]
        //[ExpectedException(typeof(ApplicationException),
        //    "no es posible agregar el mismo sentimiento o una subsecuencia de un sentimiento " +
        //    "que ya se encuentra en la lista")]
        //public void AddSubstringFeeling()
        //{
        //    Feeling f = new Feeling("Que Bueno", true);
        //    system.AddFeeling(f);
        //    Feeling f2 = new Feeling("Bueno", false);
        //    system.AddFeeling(f2);
        //}

        //[TestMethod]
        //public void addEntity()
        //{
        //    Entity e = new Entity("Coca-Cola");
        //    system.AddEntity(e);
        //    CollectionAssert.Contains(system.GetEntitites, e);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ApplicationException),
        //    "no es posible agregar la misma entidad o una subsecuencia de una entidad que ya se encuentra " +
        //    "en la lista")]
        //public void AddSameEntity()
        //{
        //    Entity e = new Entity("cocA-Cola");
        //    system.AddEntity(e);
        //    Entity e2 = new Entity("CoCa-cola");
        //    system.AddEntity(e);
        //}
        //[TestMethod]
        //[ExpectedException(typeof(ApplicationException),
        //    "no es posible agregar la misma entidad o una subsecuencia de una entidad que ya se encuentra " +
        //    "en la lista")]
        //public void AddSubstringEntity()
        //{
        //    Entity e = new Entity("Coca-Cola");
        //    system.AddEntity(e);
        //    Entity e2 = new Entity("Coca-Cola2");
        //    system.AddEntity(e);
        //}




        //[TestMethod]
        //public void deleteFeeling()
        //{
        //    Feeling f = new Feeling("Bueno", true);
        //    system.AddFeeling(f);
        //    system.DeleteFeeling(f);
        //    CollectionAssert.DoesNotContain(system.GetFeelings, f);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException),
        //    "no es posible eliminar de una lista vacía")]
        //public void deleteFeelingOfAnEmptyList()
        //{
        //    Feeling f = new Feeling("Bueno", true);
        //    system.DeleteFeeling(f);
        //}

        //[TestMethod]
        //public void deleteFeelingWithMoreElements()
        //{
        //    Feeling f = new Feeling("Bueno", true);
        //    Feeling f2 = new Feeling("Me encanta", false);
        //    system.AddFeeling(f);
        //    system.AddFeeling(f2);
        //    system.DeleteFeeling(f);
        //    CollectionAssert.DoesNotContain(system.GetFeelings, f);
        //}

        //[TestMethod]
        //public void deleteEntity()
        //{
        //    Entity e = new Entity("Coca-Cola");
        //    system.AddEntity(e);
        //    system.DeleteEntity(e);
        //    CollectionAssert.DoesNotContain(system.GetEntitites, e);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException),
        //   "no es posible eliminar de una lista vacía")]
        //public void deleteEntityOfAnEmptyList()
        //{
        //    Entity e = new Entity("Coca-Cola");
        //    system.DeleteEntity(e);
        //}



        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException),
        //   "no es posible eliminar de una lista vacía")]
        //public void deletePhraseOfAnEmptyList()
        //{
        //    DateTime d = new DateTime(2020, 4, 23);
        //    Phrase p = new Phrase("La coca-cola es riquisima", d);
        //    system.DeletePhrase(p);
        //}

        //[TestMethod]
        //public void AddAnalysis()
        //{
        //    Analysis a = new Analysis();
        //    system.AddAnalysis(a);
        //    CollectionAssert.Contains(system.GetAnalysis, a);
        //}

        //[TestMethod]
        //public void ExecuteAnalysisTest()
        //{   //Setup
        //    DateTime d = DateTime.Now;
        //    Phrase p = new Phrase("La coca-cola es rica", d);
        //    Entity e = new Entity("coca-cola");
        //    Feeling f = new Feeling("Rica", true);
        //    system.AddFeeling(f);
        //    system.AddEntity(e);
        //    system.AddPhrase(p);

        //    //Expected Analysis
        //    Analysis expectedAnalysis = new Analysis()
        //    {
        //        Phrase = p.Clone(),
        //        PhraseType = Domain.Analysis.Type.positive,
        //        Entity = e,
        //    };
        //    Analysis output = null; // system.ExecuteAnalysis(p);

        //    Assert.AreEqual(expectedAnalysis, output);
    }






}

