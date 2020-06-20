using System;
using System.Collections.Generic;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;

namespace Tests
{
    [TestClass]
    public class GeneralAlarmTest
    {
        private AlarmLogic subSystemAlarm;
        private AnalysisLogic subSystemAnalysis;
        private AuthorLogic subSystemAuthor;
        private EntityLogic subSystemEntity;
        private FeelingLogic subSystemFeeling;
        private PhraseLogic subSystemPhrase;
        private Repository systemRepo;
        GeneralAlarm al1;

        [TestInitialize]
        public void Setup()
        {
            systemRepo = new Repository();
            subSystemAuthor = new AuthorLogic(systemRepo);
            subSystemEntity = new EntityLogic(systemRepo);
            subSystemFeeling = new FeelingLogic(systemRepo);
            subSystemPhrase = new PhraseLogic(systemRepo);
            subSystemAnalysis = new AnalysisLogic(subSystemFeeling, subSystemEntity, systemRepo, subSystemAuthor);
            subSystemAlarm = new AlarmLogic(subSystemAnalysis, subSystemAuthor, systemRepo);

            subSystemFeeling.DeleteAllFeelings();
            subSystemAnalysis.DeleteAllAnalysis();
            subSystemPhrase.DeleteAllPhrases();
            subSystemAlarm.DeleteAllAlarms();
            subSystemEntity.DeleteAllEntities();
            subSystemAuthor.DeleteAllAuthors();


            al1 = new GeneralAlarm(new Entity("Nacional"), 3, false, 240);
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
        public void ParametersConstructor()
        {
            //Should Clone the Entity
            al1 = new GeneralAlarm(new Entity("Peniarol"), 5, true, 12);
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
            al1 = new GeneralAlarm()
            {
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
            Alarm al2 = new GeneralAlarm(new Entity("Nacional"), 3, false, 240);
            Assert.IsTrue(al1.Equals(al2));
        }

        [TestMethod]
        public void DifferentAlarms()
        {
            Alarm al2 = new GeneralAlarm(new Entity("Peniarol"), 5, true, 12);
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

        [TestMethod]
        public void VerifyAlarmTest()
        {
            Entity e = new Entity()
            {
                Name = "Coca"
            };
            Author a = new Author()
            {
                Name = "Jose",
                Surname = "Hernandez",
                BirthDate = new DateTime(1990, 10, 20),
                Username = "jH"
            };
            Phrase p1 = new Phrase()
            {
                Content = "Me gusta la coca",
                Date = DateTime.Now,
                Author = a
            };
            GeneralAlarm alarm = new GeneralAlarm()
            {
                PostNumber = 1,
                State = false,
                Counter = 0,
                TimeBack = 24,
                Entity = e,
                Type = true
            };
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p1,
                PhraseType = Analysis.Type.positive,
                Entity = e,
            };
            Feeling f = new Feeling()
            {
                Name = "Me gusta",
                Type = true
            };


            subSystemAuthor.AddAuthor(a);
            subSystemPhrase.AddPhrase(p1);
            subSystemEntity.AddEntity(e);
            subSystemFeeling.AddFeeling(f);
            subSystemAnalysis.AddAnalysis(anAnalysis);
            subSystemAlarm.AddGeneralAlarm(alarm);

            alarm.VerifyAlarm(subSystemAnalysis.GetAnalysis, subSystemAuthor.GetAuthors);

            Assert.IsTrue(alarm.State);
        }

        [TestMethod]
        public void VerifyAlarmTest2()
        {
            Entity e = new Entity()
            {
                Name = "Coca"
            };
            Author a = new Author()
            {
                Name = "Jose",
                Surname = "Hernandez",
                BirthDate = new DateTime(1990, 10, 20),
                Username = "jH"
            };
            Phrase p1 = new Phrase()
            {
                Content = "Me gusta la coca",
                Date = DateTime.Now,
                Author = a
            };
            GeneralAlarm alarm = new GeneralAlarm()
            {
                PostNumber = 2,
                State = false,
                Counter = 0,
                TimeBack = 24,
                Entity = e,
                Type = true
            };
            Analysis anAnalysis = new Analysis()
            {
                Phrase = p1,
                PhraseType = Analysis.Type.positive,
                Entity = e,
            };
            Feeling f = new Feeling()
            {
                Name = "Me gusta",
                Type = true
            };

            subSystemAuthor.AddAuthor(a);
            subSystemPhrase.AddPhrase(p1);
            subSystemEntity.AddEntity(e);
            subSystemFeeling.AddFeeling(f);
            subSystemAnalysis.AddAnalysis(anAnalysis);
            subSystemAlarm.AddGeneralAlarm(alarm);

            alarm.VerifyAlarm(subSystemAnalysis.GetAnalysis, subSystemAuthor.GetAuthors);

            Assert.IsFalse(alarm.State);
        }
    }
}
