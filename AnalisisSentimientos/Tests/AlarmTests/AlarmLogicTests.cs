using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de AlarmLogicTests
    /// </summary>
    [TestClass]
    public class AlarmLogicTests
    {
        EntityLogic entities;
        FeelingLogic feelings;
        AlarmLogic alarms;
        AnalysisLogic analysis;

        [TestInitialize]
        public void Setup()
        {
            entities = new EntityLogic();
            feelings = new FeelingLogic();
            analysis = new AnalysisLogic(feelings, entities);
            alarms = new AlarmLogic(analysis);
        }

        [TestMethod]
        public void AddAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            CollectionAssert.Contains(alarms.GetAlarms, a);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            Alarm b = new Alarm(e, 5, true, 1);
            alarms.AddAlarm(b);
        }

        [TestMethod]
        public void deleteAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            alarms.AddAlarm(a);
            alarms.DeleteAlarm(a);
            CollectionAssert.DoesNotContain(alarms.GetAlarms, a);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "no es posible eliminar de una lista vacía")]
        public void deleteAlarmOfAnEmptyList()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            alarms.DeleteAlarm(a);
        }

        [TestMethod]
        public void verifyAlarmsTest()
        {   //Setup
            DateTime d = DateTime.Now;
            Phrase p = new Phrase("La coca-cola es rica", d);
            Entity e = new Entity("coca-cola");
           // Feeling f = new Feeling("rica", true);
            Alarm alarm = new Alarm(e, 1, true, 10);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p.Clone(),
                PhraseType = Domain.Analysis.Type.positive,
                Entity = e,
            };

            //Add to the system
            //feelings.AddFeeling(f);
            // entities.AddEntity(e);
            //phrases.AddPhrase(p);
            alarms.AddAlarm(alarm);
            analysis.AddAnalysis(anAnalysis);
            alarms.VerifyAlarms();

            Assert.IsTrue(alarm.State);
        }

        [TestMethod]
        public void verifyAlarmsOutOfRangeTest()
        {   //Setup
            DateTime d = new DateTime(2019, 4, 23);
            Phrase p = new Phrase("La coca-cola es rica", d);
            Entity e = new Entity("coca-cola");
           // Feeling f = new Feeling("rica", true);
            Alarm alarm = new Alarm(e, 1, true, 2);
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p,
                PhraseType = Analysis.Type.positive,
                Entity = e,
            };

            //Add to the system
            //system.AddFeeling(f);
            //system.AddEntity(e);
            //system.AddPhrase(p);
            alarms.AddAlarm(alarm);
            analysis.AddAnalysis(anAnalysis);

            //system.VerifyAlarms();

            Assert.IsFalse(alarm.State);
        }

    }
}
