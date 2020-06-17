using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int TotalPosts { get; set; }
        public int PositivePosts { get; set; }
        public int NegativePosts { get; set; }
        public List<Entity> MentionedEntities { get; }

        public Author()
        {
            MentionedEntities = new List<Entity>();
        }

        public Author(string username, string name, string surname, DateTime birthDate)
        {
            Username = username;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            TotalPosts = 0;
            PositivePosts = 0;
            NegativePosts = 0;
            MentionedEntities = new List<Entity>();
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

        public void AddEntity(Entity anEntity)
        {
            if (!MentionedEntities.Contains(anEntity))
            {
                MentionedEntities.Add(anEntity);
            }
        }

        public double PositiveRatio()
        {
            if (TotalPosts == 0) return 0;
            // return Math.Truncate(((double)PositivePosts / TotalPosts) * 100.0 / 100.0);
            return (double)PositivePosts / (double)TotalPosts;
        }

        public double NegativeRatio()
        {
            if (TotalPosts == 0) return 0;
            return (double) NegativePosts / (double) TotalPosts;
        }
    }
}
