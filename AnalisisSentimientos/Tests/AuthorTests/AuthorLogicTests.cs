using System;
using System.Collections.Generic;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using Type = Domain.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class AuthorLogicTests
    {
        AuthorLogic subsystem;
        Author a1;
        DateTime d1;
        Repository repository;

        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
            subsystem = new AuthorLogic(repository);

            subsystem.DeleteAllAuthors();

            d1 = new DateTime(1998, 10, 22);
            a1 = new Author("user123", "Juan", "Perez", d1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            subsystem.DeleteAllAuthors();
        }

        [TestMethod]
        public void addAuthor()
        {
            subsystem.AddAuthor(a1);
            CollectionAssert.Contains(subsystem.GetAuthors, a1);
        }

        [TestMethod]
        public void deleteAuthor()
        {
            subsystem.AddAuthor(a1);
            subsystem.DeleteAuthor(a1);
            CollectionAssert.DoesNotContain(subsystem.GetAuthors, a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El usuario debe tener entre 13 y 100 años")]
        public void invalidAge()
        {
            a1 = new Author("user123", "Juan", "Perez", new DateTime(2018, 1, 1));
            subsystem.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El nombre debe tener entre 1 y 15 caracteres")]
        public void invalidName()
        {
            a1 = new Author("user123", "", "Perez", new DateTime(1999, 1, 1));
            subsystem.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El apellido debe tener entre 1 y 15 caracteres")]
        public void invalidSurName()
        {
            a1 = new Author("user123", "Juan", "", new DateTime(1999, 1, 1));
            subsystem.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El username debe tener entre 1 y 10 caracteres")]
        public void invalidUserName()
        {
            a1 = new Author("user123456789", "Juan", "Perez", new DateTime(1999, 1, 1));
            subsystem.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El nombre de usuario ya se encuentra en uso")]
        public void RepeatedAuthor()
        {
            Author a2 = new Author("user123", "Pedro", "Fernandez", new DateTime(1999, 1, 1));
            subsystem.AddAuthor(a1);
            subsystem.AddAuthor(a2);
        }

        [TestMethod]
        public void UpdatePositiveCounter()
        {
            Analysis analysis = new Analysis()
            {
                Entity = new Entity("Coca"),
                Phrase = new Phrase("Me gusta la Coca", DateTime.Now, a1),
                PhraseType = Type.positive,
            };
            subsystem.UpdateAuthorCounter(analysis);
            Assert.AreEqual(a1.PositivePosts, 1);
            Assert.AreEqual(a1.TotalPosts, 1);
        }

        [TestMethod]
        public void UpdateNegativeCounter()
        {
            Analysis analysis = new Analysis()
            {
                Entity = new Entity("Coca"),
                Phrase = new Phrase("Odio la Coca", DateTime.Now, a1),
                PhraseType = Type.negative,
            };
            subsystem.UpdateAuthorCounter(analysis);
            Assert.AreEqual(a1.NegativePosts, 1);
            Assert.AreEqual(a1.TotalPosts, 1);
        }

        [TestMethod]
        public void UpdateOnlyTotalCounter()
        {
            Analysis analysis = new Analysis()
            {
                Entity = new Entity("Coca"),
                Phrase = new Phrase("Hoy tomé Coca", DateTime.Now, a1),
                PhraseType = Type.neutral,
            };
            subsystem.UpdateAuthorCounter(analysis);
            Assert.AreEqual(a1.NegativePosts, 0);
            Assert.AreEqual(a1.PositivePosts, 0);
            Assert.AreEqual(a1.TotalPosts, 1);
        }

        [TestMethod]
        public void AddEntityToList()
        {
            Entity e1 = new Entity("Coca");
            Analysis analysis = new Analysis()
            {
                Entity = e1,
                Phrase = new Phrase("Hoy tomé Coca", DateTime.Now, a1),
                PhraseType = Type.neutral,
            };
            subsystem.UpdateAuthorEntities(analysis);
            CollectionAssert.Contains(a1.MentionedEntities, e1);
        }

        [TestMethod]
        public void DontAddEntityToList()
        {
            Entity e1 = new Entity("Coca");
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Día aburrido", DateTime.Now, a1),
                PhraseType = Type.neutral,
            };
            subsystem.UpdateAuthorEntities(analysis);
            CollectionAssert.DoesNotContain(a1.MentionedEntities, e1);
        }


        [TestMethod]
        public void deleteAuthorByUsarname()
        {
            subsystem.AddAuthor(a1);
            subsystem.DeleteAuthorByUsername(a1.Username);
            CollectionAssert.DoesNotContain(subsystem.GetAuthors,a1);
        }
    }
}
