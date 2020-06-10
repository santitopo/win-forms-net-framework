using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;

namespace Tests.AlarmTests
{

    [TestClass]
    public class AuthorAlarmTests
    {
        private AlarmLogic subSystemAlarm;
        private AnalysisLogic subSystemAnalysis;
        private AuthorLogic subSystemAuthor;
        private EntityLogic subSystemEntity;
        private FeelingLogic subSystemFeeling;
        private PhraseLogic subSystemPhrase;
        private Repository systemRepo;
        AuthorAlarm al1;


        [TestInitialize]
        public void Setup()
        {
            systemRepo = new Repository();
            subSystemAuthor = new AuthorLogic(systemRepo);
            subSystemEntity = new EntityLogic(systemRepo);
            subSystemFeeling = new FeelingLogic(systemRepo);
            subSystemPhrase = new PhraseLogic(systemRepo);
            subSystemAnalysis = new AnalysisLogic(subSystemFeeling, subSystemEntity, systemRepo,subSystemAuthor);
            subSystemAlarm = new AlarmLogic(subSystemAnalysis, subSystemAuthor, systemRepo);

            al1 = new AuthorAlarm(3, false, 240);

        }

        [TestMethod]
        public void ParametersConstructor()
        {
            //Should Clone the Entity
            al1 = new AuthorAlarm(5, true, 12);
            Assert.IsTrue(al1.PostNumber == 5);
            Assert.IsTrue(al1.Type);
            Assert.IsTrue(al1.TimeBack == 12);
            Assert.IsFalse(al1.State);
        }

        [TestMethod]
        public void EmptyConstructor()
        {
            al1 = new AuthorAlarm()
            {
                PostNumber = 5,
                Type = true,
                TimeBack = 12,
                State = false,
            };
            Assert.IsTrue(al1.PostNumber == 5);
            Assert.IsTrue(al1.Type);
            Assert.IsTrue(al1.TimeBack == 12);
            Assert.IsFalse(al1.State);
        }

        [TestMethod]
        public void EqualAlarms()
        {
            Alarm al2 = new AuthorAlarm(3, false, 240);
            Assert.IsTrue(al1.Equals(al2));
        }

        [TestMethod]
        public void DifferentAlarms()
        {
            Alarm al2 = new AuthorAlarm(5, true, 12);
            Assert.IsFalse(al1.Equals(al2));
        }

        [TestMethod]
        public void NullCompare()
        {
            Assert.IsFalse(al1.Equals(null));
        }


        [TestMethod]
        public void ResetCounterTest()
        {
            al1.ResetCounter();
            al1.CheckAlarm();
            Assert.IsFalse(al1.State);
            Assert.IsTrue(al1.getAsocciatedAuthors().Length == 0);
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
            Alarm alarm = new AuthorAlarm()
            {
                PostNumber = 1,
                State = false,
                TimeBack = 24,
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
            subSystemAlarm.AddAlarm(alarm);
            subSystemEntity.AddEntity(e);
            subSystemFeeling.AddFeeling(f);
            subSystemAnalysis.AddAnalysis(anAnalysis);

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
            Alarm alarm = new AuthorAlarm()
            {
                PostNumber = 2,
                State = false,
                TimeBack = 24,
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
            subSystemAlarm.AddAlarm(alarm);
            subSystemEntity.AddEntity(e);
            subSystemFeeling.AddFeeling(f);
            subSystemAnalysis.AddAnalysis(anAnalysis);

            alarm.VerifyAlarm(subSystemAnalysis.GetAnalysis, subSystemAuthor.GetAuthors);

            Assert.IsFalse(alarm.State);
        }
    }
}
