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
        EntityLogic entities;
        FeelingLogic feelings;
        AuthorLogic authors;
        AlarmLogic alarms;
        AnalysisLogic analysis;
        Repository repository;
        Author a1;

        [TestInitialize]
        public void Setup()
        {
            repository = new Repository();
            entities = new EntityLogic(repository);
            authors = new AuthorLogic(repository);
            a1 = new Author("user123", "Santiago", "Fernandez", new DateTime(1999, 09, 08));
            authors.AddAuthor(a1);
            feelings = new FeelingLogic(repository);
            analysis = new AnalysisLogic(feelings, entities, repository, authors);
            alarms = new AlarmLogic(analysis, authors, repository);
        }

        [TestMethod]
        public void AddAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new GeneralAlarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            CollectionAssert.Contains(alarms.GetAlarms, a);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new GeneralAlarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            Alarm b = new GeneralAlarm(e, 5, true, 1);
            alarms.AddAlarm(b);
        }

        [TestMethod]
        public void DeleteAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new GeneralAlarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            alarms.DeleteAlarm(a);
            CollectionAssert.DoesNotContain(alarms.GetAlarms, a);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "no es posible eliminar de una lista vacía")]
        public void DeleteAlarmOfAnEmptyList()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new GeneralAlarm(e, 5, true, 1);
            alarms.DeleteAlarm(a);
        }

        [TestMethod]
        public void VerifyAllAlarmsTest()
        {   
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            Entity e = new Entity("coca-cola");
            Alarm alarm = new GeneralAlarm(e, 1, true, 10);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p.Clone(),
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e,
            };

            alarms.AddAlarm(alarm);
            analysis.AddAnalysis(anAnalysis);
            alarms.VerifyAllAlarms();
            Assert.IsTrue(alarm.State);
        }

        [TestMethod]
        public void VerifyAlarmsOutOfRangeTest()
        {   
            DateTime d = new DateTime(2019, 4, 23);
            Phrase p = new Phrase("La coca-cola es rica", d, a1);
            Entity e = new Entity("coca-cola");
            Alarm alarm = new GeneralAlarm(e, 1, true,2);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Analysis.Type.positive,
                Entity = e,
            };

            alarms.AddAlarm(alarm);
            analysis.AddAnalysis(anAnalysis);
            alarms.VerifyAllAlarms();
            Assert.IsFalse(alarm.State);
        }

    }
}
