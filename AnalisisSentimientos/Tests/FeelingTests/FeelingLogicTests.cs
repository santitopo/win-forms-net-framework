using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de FeelingLogicTests
    /// </summary>
    [TestClass]
    public class FeelingLogicTests
    {
        FeelingLogic subsystem;
        Repository repository;
        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
            subsystem = new FeelingLogic(repository);
        }

        [TestMethod]
        public void AddFeeling()
        {
            Feeling f = new Feeling("Bueno", true);
            subsystem.AddFeeling(f);
            CollectionAssert.Contains(subsystem.GetFeelings, f);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar el mismo sentimiento o una subsecuencia de un sentimiento " +
            "que ya se encuentra en la lista")]
        public void AddSameFeeling()
        {
            Feeling f = new Feeling("bUEno", true);
            subsystem.AddFeeling(f);
            Feeling f2 = new Feeling("BuEnO", false);
            subsystem.AddFeeling(f2);
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar el mismo sentimiento o una subsecuencia de un sentimiento " +
            "que ya se encuentra en la lista")]
        public void AddSubstringFeeling()
        {
            Feeling f = new Feeling("Que Bueno", true);
            subsystem.AddFeeling(f);
            Feeling f2 = new Feeling("Bueno", false);
            subsystem.AddFeeling(f2);
        }

        [TestMethod]
        public void deleteFeeling()
        {
            Feeling f = new Feeling("Bueno", true);
            subsystem.AddFeeling(f);
            subsystem.DeleteFeeling(f);
            CollectionAssert.DoesNotContain(subsystem.GetFeelings, f);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "no es posible eliminar de una lista vacía")]
        public void deleteFeelingOfAnEmptyList()
        {
            Feeling f = new Feeling("Bueno", true);
            subsystem.DeleteFeeling(f);
        }

        [TestMethod]
        public void deleteFeelingWithMoreElements()
        {
            Feeling f = new Feeling("Bueno", true);
            Feeling f2 = new Feeling("Me encanta", false);
            subsystem.AddFeeling(f);
            subsystem.AddFeeling(f2);
            subsystem.DeleteFeeling(f);
            CollectionAssert.DoesNotContain(subsystem.GetFeelings, f);
        }
    }
}
