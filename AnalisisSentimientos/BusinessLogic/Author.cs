using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Author() { }

        public Author(string username, string name, string surname, DateTime birthDate)
        {
            Username = username;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Author))
            {
                return false;
            }
            return Username == ((Author)obj).Username;
        }

        public override String ToString()
        {
            return Username;
        }

    }
}
