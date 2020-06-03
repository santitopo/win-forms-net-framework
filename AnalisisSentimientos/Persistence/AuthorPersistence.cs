using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class AuthorPersistence
    {
        private List<Author> authors;

        public AuthorPersistence()
        {
            authors = new List<Author>();

        }

        public void Add(Author anAuthor)
        {
            authors.Add(anAuthor);
        }

        public void Delete(Author anAuthor)
        {
            authors.Remove(anAuthor);
        }

        public List<Author> Get()
        {
            return authors;
        }
    }
}
