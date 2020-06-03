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
        AlarmLogic alarms;
        
        [TestInitialize]
        public void Setup()
        {
           //= new AlarmLogic();
        }

        [TestMethod]
        public void AddAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            system.AddAlarm(a);
            CollectionAssert.Contains(system.GetAlarms, a);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "no es posible agregar exactamente la misma alarma")]
        public void AddSameAlarm()
        {
            Entity e = new Entity("cocA-Cola");
            Alarm a = new Alarm(e, 5, true, 1);
            system.AddAlarm(a);
            Alarm b = new Alarm(e, 5, true, 1);
            system.AddAlarm(b);
        }
    }
}
