using System;
using System.Collections.Generic;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AlarmTest

    {
        Alarm al1;
        [TestInitialize]
        public void Setup()
        {
            al1 = new Alarm(new Entity("Nacional"), 3, false, 240) ;
        }
        //[TestMethod]
        //public void ProteccionTest()
        //{
        //   Entity e1 = al1.
        //    al1.= true;

        //}
       
        [TestMethod]
        public void ParametersConstructor()
        {
            //Should Clone the Entity
            al1 = new Alarm(new Entity("Peniarol"), 5, true, 12);
            Assert.IsTrue(al1.Entity.Equals(new Entity("Peniarol")));
            Assert.IsTrue(al1.PostNumber == 5);
            Assert.IsTrue(al1.Counter == 0);
            Assert.IsTrue(al1.Type);
            Assert.IsTrue(al1.TimeBack == 12);
            Assert.IsFalse(al1.State);
        }

        [TestMethod]
        public void EqualAnalysis()
        {
            Alarm al2 = new Alarm(new Entity("Nacional"), 3, false, 240);
            Assert.IsTrue(al1.Equals(al2));
        }

        [TestMethod]
        public void DifferentAlarms()
        {
            Alarm al2 = new Alarm(new Entity("Peniarol"), 5, true, 12);
            Assert.IsFalse(al1.Equals(al2));
        }

        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(al1.Equals(null));
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
            for (int i = 0; i < 3; i++) { 
                al1.IncreaseCounter();
            }
            Assert.IsTrue(al1.Counter == 3);
            Assert.IsTrue(al1.State);
        }

        [TestMethod]
        public void KeepOffAlarm()
        {
            al1.IncreaseCounter();
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
            Assert.IsFalse(al1.State);
            Assert.IsTrue(al1.Counter == 0);
        }
    }
}
