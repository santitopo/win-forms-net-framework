using System;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;

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

    }
}
