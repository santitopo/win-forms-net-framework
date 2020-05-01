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
        public void EmptyConstructor()
        {
            al1 = new Alarm(){
                Entity = new Entity("Peniarol"),
                PostNumber = 5,
                Counter = 0,
                Type = true,
                TimeBack = 12,
                State = false,
        };
        Assert.IsTrue(al1.Entity.Equals(new Entity("Peniarol")));
            Assert.IsTrue(al1.PostNumber == 5);
            Assert.IsTrue(al1.Counter == 0);
            Assert.IsTrue(al1.Type);
            Assert.IsTrue(al1.TimeBack == 12);
            Assert.IsFalse(al1.State);
        }

        [TestMethod]
        public void EqualAlarms()
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
 
    }
}
