using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de AlarmLogicTests
    /// </summary>
    [TestClass]
    public class AlarmLogicTests
    {
        Alarm al1;
        AlarmLogic logic;
        [TestInitialize]
        public void Setup()
        {
            logic = new AlarmLogic();
            al1 = new Alarm(new Entity("Nacional"), 3, false, 240);
        }

        [TestMethod]
        public void IncreaseCounter()
        {
            logic.IncreaseCounter(al1);
            logic.IncreaseCounter(al1);
            Assert.IsTrue(al1.Counter == 2);
        }

        [TestMethod]
        public void TurnOnAlarm()
        {
            for (int i = 0; i < 3; i++)
            {
                logic.IncreaseCounter(al1);
                logic.CheckAlarm(al1);
            }
            Assert.IsTrue(al1.Counter == 3);
            Assert.IsTrue(al1.State);
        }

        [TestMethod]
        public void KeepOffAlarm()
        {
            logic.IncreaseCounter(al1);
            logic.CheckAlarm(al1);
            Assert.IsFalse(al1.State);

            List<Entity> l1 = new List<Entity>();
            Entity[] ar1 = l1.ToArray();
        }

        [TestMethod]
        public void ResetCounterTest()
        {
            for (int i = 0; i < 10; i++)
            {
                logic.IncreaseCounter(al1);
            }
            logic.ResetCounter(al1);
            logic.CheckAlarm(al1);
            Assert.IsFalse(al1.State);
            Assert.IsTrue(al1.Counter == 0);
        }
    }
}
