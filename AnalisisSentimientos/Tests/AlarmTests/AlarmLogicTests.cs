using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de AlarmLogicTests
    /// </summary>
    [TestClass]
    public class AlarmLogicTests
    {
        Alarm al1;

        [TestInitialize]
        public void Setup()
        {
            al1 = new Alarm(new Entity("Nacional"), 3, false, 240);
        }

        [TestMethod]
        public void IncreaseCounter()
        {
            al1.IncreaseCounter();
            al1.IncreaseCounter();
            Assert.IsTrue(al1.Counter == 2);
        }

        [TestMethod]
        public void TurnOnAlarm()
        {
            for (int i = 0; i < 3; i++)
            {
                al1.IncreaseCounter();
                al1.CheckAlarm();
            }
            Assert.IsTrue(al1.Counter == 3);
            Assert.IsTrue(al1.State);
        }

        [TestMethod]
        public void KeepOffAlarm()
        {
            al1.IncreaseCounter();
            al1.CheckAlarm();
            Assert.IsFalse(al1.State);

            List<Entity> l1 = new List<Entity>();
            Entity[] ar1 = l1.ToArray();
        }

        [TestMethod]
        public void ResetCounterTest()
        {
            for (int i = 0; i < 10; i++)
            {
                al1.IncreaseCounter();
            }
            al1.ResetCounter();
            al1.CheckAlarm();
            Assert.IsFalse(al1.State);
            Assert.IsTrue(al1.Counter == 0);
        }
    }
}
