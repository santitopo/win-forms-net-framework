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
        AuthorLogic authors;
        Author a1;
        DateTime d1;
        Repository repository;
        [TestInitialize]
        public void SetUp()
        {
            repository = new Repository();
            authors = new AuthorLogic(repository);
            d1 = new DateTime(1998, 10, 22);
            a1 = new Author("user123", "Juan", "Perez", d1);
        }

        [TestMethod]
        public void addAuthor()
        {
            authors.AddAuthor(a1);
            CollectionAssert.Contains(authors.GetAuthors, a1);
        }

        [TestMethod]
        public void deleteAuthor()
        {
            authors.AddAuthor(a1);
            authors.DeleteAuthor(a1);
            CollectionAssert.DoesNotContain(authors.GetAuthors, a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El usuario debe tener entre 13 y 100 años")]
        public void invalidAge()
        {
            a1 = new Author("user123", "Juan", "Perez", new DateTime(2018, 1, 1));
            authors.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El nombre debe tener entre 1 y 15 caracteres")]
        public void invalidName()
        {
            a1 = new Author("user123", "", "Perez", new DateTime(1999, 1, 1));
            authors.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El apellido debe tener entre 1 y 15 caracteres")]
        public void invalidSurName()
        {
            a1 = new Author("user123", "Juan", "", new DateTime(1999, 1, 1));
            authors.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El username debe tener entre 1 y 10 caracteres")]
        public void invalidUserName()
        {
            a1 = new Author("user123456789", "Juan", "Perez", new DateTime(1999, 1, 1));
            authors.AddAuthor(a1);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "El nombre de usuario ya se encuentra en uso")]
        public void RepeatedAuthor()
        {
            Author a2 = new Author("user123", "Pedro", "Fernandez", new DateTime(1999, 1, 1));
            authors.AddAuthor(a1);
            authors.AddAuthor(a2);
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
            authors.UpdateAuthorCounter(analysis);
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
            authors.UpdateAuthorCounter(analysis);
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
            authors.UpdateAuthorCounter(analysis);
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
            authors.UpdateAuthorEntities(analysis);
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
            authors.UpdateAuthorEntities(analysis);
            CollectionAssert.DoesNotContain(a1.MentionedEntities, e1);
        }

        [TestMethod]
        public void ListByPositiveRatioDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2)); 
            authors.AddAuthor(a1);
            authors.AddAuthor(a2);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Feliz", DateTime.Now, a2),
                PhraseType = Type.positive,
            };
            authors.UpdateAuthorCounter(analysis);
            List<Author> expected = new List<Author>();
            expected.Add(a2);
            expected.Add(a1);
            CollectionAssert.AreEqual(expected, authors.ListByPositiveRatioDesc());
        }

        [TestMethod]
        public void ListByNegativeRatioDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a1);
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Triste", DateTime.Now, a2),
                PhraseType = Type.negative,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Mal", DateTime.Now, a2),
                PhraseType = Type.negative,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Feo", DateTime.Now, a3),
                PhraseType = Type.negative,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Horrible", DateTime.Now, a3),
                PhraseType = Type.positive,
            };
            authors.UpdateAuthorCounter(analysis);
            authors.UpdateAuthorCounter(analysis2);
            authors.UpdateAuthorCounter(analysis3);
            authors.UpdateAuthorCounter(analysis4);
            List<Author> expected = new List<Author>();
            expected.Add(a2);
            expected.Add(a3);
            expected.Add(a1);
            CollectionAssert.AreEqual(expected, authors.ListByNegativeRatioDesc());
        }

        [TestMethod]
        public void ListByEntityNumberDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a1);
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);
            Analysis analysis = new Analysis()
            {
                Entity = new Entity("Coca"),
                Phrase = new Phrase("Me tomé una coca", DateTime.Now, a1),
                PhraseType = Type.neutral,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = new Entity("Sprite"),
                Phrase = new Phrase("Me tomé una spritE", DateTime.Now, a1),
                PhraseType = Type.neutral,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = new Entity("Sprite"),
                Phrase = new Phrase("Rica Sprite", DateTime.Now, a3),
                PhraseType = Type.positive,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = new Phrase("Horrible", DateTime.Now, a3),
                PhraseType = Type.positive,
            };
            authors.UpdateAuthorEntities(analysis);
            authors.UpdateAuthorEntities(analysis2);
            authors.UpdateAuthorEntities(analysis3);
            authors.UpdateAuthorEntities(analysis4);
            List<Author> expected = new List<Author>();
            expected.Add(a1);
            expected.Add(a3);
            expected.Add(a2);
            CollectionAssert.AreEqual(expected, authors.ListByEntityNumberDesc());
        }

        [TestMethod]
        public void ListByPhraseAverageDesc()
        {
            Author a2 = new Author("user345", "Pablo", "Gimenez", new DateTime(1990, 2, 2));
            Author a3 = new Author("user678", "Fernando", "Perez", new DateTime(1991, 2, 2));
            authors.AddAuthor(a1);
            authors.AddAuthor(a2);
            authors.AddAuthor(a3);
            Phrase p1 = new Phrase("Me tomé una coca", new DateTime(1994, 2, 2), a1);
            Phrase p2 = new Phrase("Me tomé una spritE", new DateTime(1996, 2, 2), a1);
            Phrase p3 = new Phrase("Rica Sprite", new DateTime(2015, 12, 12), a3);
            Phrase p4 = new Phrase("Horrible", DateTime.Now, a3);
            Analysis analysis = new Analysis()
            {
                Entity = null,
                Phrase = p1,
                PhraseType = Type.neutral,
            };
            Analysis analysis2 = new Analysis()
            {
                Entity = null,
                Phrase = p2,
                PhraseType = Type.neutral,
            };
            Analysis analysis3 = new Analysis()
            {
                Entity = null,
                Phrase = p3,
                PhraseType = Type.positive,
            };
            Analysis analysis4 = new Analysis()
            {
                Entity = null,
                Phrase = p4,
                PhraseType = Type.positive,
            };
            repository.AddPhrase(p1);
            repository.AddPhrase(p2);
            repository.AddPhrase(p3);
            repository.AddPhrase(p4);
            authors.UpdateAuthorCounter(analysis);
            authors.UpdateAuthorCounter(analysis2);
            authors.UpdateAuthorCounter(analysis3);
            authors.UpdateAuthorCounter(analysis4);
            List<Author> expected = new List<Author>();
            expected.Add(a3);
            expected.Add(a1);
            expected.Add(a2);
            CollectionAssert.AreEqual(expected, authors.ListByPhraseAverageDesc());
        }
    }
}
