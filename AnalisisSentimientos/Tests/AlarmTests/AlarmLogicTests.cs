using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;

namespace Tests
{
    [TestClass]
    public class AlarmLogicTests
    {
        EntityLogic subSystemEntity;
        FeelingLogic subSystemFeeling;
        AuthorLogic subSystemAuthor;
        AlarmLogic subSystemAlarm;
        AnalysisLogic subSystemAnalysis;
        PhraseLogic subSystemPhrase;
        Repository repository;

        Author a1;
        Entity e;

        [TestInitialize]
        public void Setup()
        {
            repository = new Repository();
            subSystemEntity = new EntityLogic(repository);
            subSystemAuthor = new AuthorLogic(repository);
            subSystemFeeling = new FeelingLogic(repository);
            subSystemAnalysis = new AnalysisLogic(subSystemFeeling, subSystemEntity, repository, subSystemAuthor);
            subSystemAlarm = new AlarmLogic(subSystemAnalysis, subSystemAuthor, repository);
            subSystemPhrase = new PhraseLogic(repository);

            subSystemFeeling.DeleteAllFeelings();
            subSystemAnalysis.DeleteAllAnalysis();
            subSystemPhrase.DeleteAllPhrases();
            subSystemAlarm.DeleteAllAlarms();
            subSystemEntity.DeleteAllEntities();
            subSystemAuthor.DeleteAllAuthors();

            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 09, 08));
            e = new Entity("cocA-Cola");
            subSystemAuthor.AddAuthor(a1);
            subSystemEntity.AddEntity(e);
        }

        [TestCleanup]
        public void CleanUp()
        {
            subSystemFeeling.DeleteAllFeelings();
            subSystemAnalysis.DeleteAllAnalysis();
            subSystemPhrase.DeleteAllPhrases();
            subSystemAlarm.DeleteAllAlarms();
            subSystemEntity.DeleteAllEntities();
            subSystemAuthor.DeleteAllAuthors();
        }

        [TestMethod]
        public void AddGeneralAlarm()
        {
            GeneralAlarm a = new GeneralAlarm(e, 5, true, 1);
            subSystemAlarm.AddGeneralAlarm(a);
            CollectionAssert.Contains(subSystemAlarm.GetAlarms, a);
        }

        [TestMethod]
        public void AddAuthorAlarm()
        {
            AuthorAlarm a = new AuthorAlarm(4, false, 2);
            subSystemAlarm.AddAuthorAlarm(a);
            CollectionAssert.Contains(subSystemAlarm.GetAlarms, a);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameGeneralAlarm()
        {
            GeneralAlarm a = new GeneralAlarm(e, 5, true, 1);
            subSystemAlarm.AddGeneralAlarm(a);
            GeneralAlarm b = new GeneralAlarm(e, 5, true, 1);
            subSystemAlarm.AddGeneralAlarm(b);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameAuthorAlarm()
        {
            AuthorAlarm a = new AuthorAlarm(4, false, 2);
            subSystemAlarm.AddAuthorAlarm(a);
            AuthorAlarm b = new AuthorAlarm(4, false, 2);
            subSystemAlarm.AddAuthorAlarm(b);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameAlarm()
        {
            GeneralAlarm a = new GeneralAlarm(e, 5, true, 1);
            subSystemAlarm.AddGeneralAlarm(a);
            AuthorAlarm b = new AuthorAlarm(5, true, 1);
            subSystemAlarm.AddAuthorAlarm(b);
        }



        [TestMethod]
        public void VerifyAllAlarmsTest()
        {   
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e,
            };
            GeneralAlarm alarm = new GeneralAlarm(e, 1, true, 10);

            subSystemPhrase.AddPhrase(p);
            subSystemAnalysis.AddAnalysis(anAnalysis);
            subSystemAlarm.AddGeneralAlarm(alarm);

            subSystemAlarm.VerifyAllAlarms();

            Assert.IsTrue(alarm.State);
        }

        [TestMethod]
        public void VerifyAllAlarmsTest2()
        {
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e,
            };
            AuthorAlarm alarm = new AuthorAlarm(1, true, 2);

            subSystemPhrase.AddPhrase(p);
            subSystemAnalysis.AddAnalysis(anAnalysis);
            subSystemAlarm.AddAuthorAlarm(alarm);

            subSystemAlarm.VerifyAllAlarms();

            Assert.IsTrue(alarm.State);
        }


        //TODO: Agegar verifyAlarms para alarmas autores

        [TestMethod]
        public void VerifyAlarmsOutOfRangeTest()
        {
            DateTime d = new DateTime(2019, 4, 23);
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            GeneralAlarm alarm = new GeneralAlarm(e, 1, true,2);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Analysis.Type.positive,
                Entity = e,
            };

            subSystemPhrase.AddPhrase(p);
            subSystemAnalysis.AddAnalysis(anAnalysis);
            subSystemAlarm.AddGeneralAlarm(alarm);
            subSystemAlarm.VerifyAllAlarms();

            Assert.IsFalse(alarm.State);
        }

        [TestMethod]
        public void getGeneralAlarms()
        {
            GeneralAlarm alarm = new GeneralAlarm(e, 1, true, 2);

            subSystemAlarm.AddGeneralAlarm(alarm);
            Alarm[] generalAlarms = subSystemAlarm.GetGeneralAlarms();

            Assert.IsTrue(generalAlarms.Length == 1);
            Assert.IsTrue(generalAlarms[0].Equals(alarm));
        }

        [TestMethod]
        public void getEmptyGeneralAlarms()
        {
            AuthorAlarm alarm = new AuthorAlarm(1, true, 2);

            subSystemAlarm.AddAuthorAlarm(alarm);
            Alarm[] generalAlarms = subSystemAlarm.GetGeneralAlarms();

            Assert.IsTrue(generalAlarms.Length == 0);
        }

        [TestMethod]
        public void getAuthorAlarms()
        {
            AuthorAlarm alarm = new AuthorAlarm(1, true, 2);
            subSystemAlarm.AddAuthorAlarm(alarm);

            Alarm[] authorAlarms = subSystemAlarm.GetAuthorAlarms();

            Assert.IsTrue(authorAlarms.Length == 1);
            Assert.IsTrue(authorAlarms[0].Equals(alarm));
        }

        [TestMethod]
        public void getEmptyAuthorAlarms()
        {
            GeneralAlarm alarm = new GeneralAlarm(e, 1, true, 2);

            subSystemAlarm.AddGeneralAlarm(alarm);
            Alarm[] authorAlarms = subSystemAlarm.GetAuthorAlarms();

            Assert.IsTrue(authorAlarms.Length == 0);
        }

    }
}
