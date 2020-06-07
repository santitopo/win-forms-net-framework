using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Domain.Analysis.Type;

namespace Logic
{
    public class AuthorLogic
    {
        public Repository Repository { get; }
        public const int MIN_AGE = 13;
        public const int MAX_AGE = 100;
        public AuthorLogic(Repository repo)
        {
            Repository = repo;
        }

        public void AddAuthor(Author anAuthor)
        {
            if (RepeatedAuthor(anAuthor))
            {
                throw new ApplicationException("El nombre de usuario ya se encuentra en uso");
            }
            if (ValidAuthor(anAuthor))
                Repository.AddAuthor(anAuthor);
        }

        public void DeleteAuthor(Author anAuthor)
        {
            if (Repository.GetAuthors().Count == 0)
            {
                throw new InvalidOperationException("No hay autores en el sistema");
            }
            Repository.DeleteAuthor(anAuthor);
        }

        private bool RepeatedAuthor(Author anAuthor)
        {
            foreach (Author a in Repository.GetAuthors())
            {
                if (anAuthor.Equals(a))
                    return true;
            }
            return false;
        }

        private bool ValidAuthor(Author anAuthor)
        {
            return ValidName(anAuthor.Name)
                && ValidSurName(anAuthor.Surname)
                && ValidUserName(anAuthor.Username)
                && ValidAge(anAuthor.BirthDate);
        }

        private bool ValidName(String name)
        {
            if (name.Length <= 15 && name.Length > 0)
            {
                return true;
            }
            else
            {
                throw new ApplicationException("El nombre debe tener entre 1 y 15 caracteres");
            }
        }

        private bool ValidSurName(String surName)
        {
            if (surName.Length <= 15 && surName.Length > 0)
            {
                return true;
            }
            else
            {
                throw new ApplicationException("El apellido debe tener entre 1 y 15 caracteres");
            }
        }

        private bool ValidUserName(String userName)
        {
            if (userName.Length <= 10 && userName.Length > 0)
            {
                return true;
            }
            else
            {
                throw new ApplicationException("El username debe tener entre 1 y 10 caracteres");
            }
        }
        private bool ValidAge(DateTime birthDate)
        {
            TimeSpan span = DateTime.Now - birthDate;
            DateTime age = DateTime.MinValue.Add(span); // MinValue is 1/1/1
            int years = age.Year - 1;

            if (years > MIN_AGE && years <= MAX_AGE)
            {
                return true;
            }
            else
            {
                throw new ApplicationException("El usuario debe tener entre 13 y 100 años");
            }

        }

        public Author[] GetAuthors
        {
            get { return Repository.GetAuthors().ToArray(); }
        }

        public void UpdateAuthorCounter(Analysis anAnalysis)
        {
            anAnalysis.Phrase.Author.TotalPosts++;

            if (anAnalysis.PhraseType == Type.positive)
            {
                anAnalysis.Phrase.Author.PositivePosts++;
            }
            else if (anAnalysis.PhraseType == Type.negative)
            {
                anAnalysis.Phrase.Author.NegativePosts++;
            }
        }

        public void UpdateAuthorEntities(Analysis anAnalysis)
        {
            Author author = anAnalysis.Phrase.Author;
            Entity entity = anAnalysis.Entity;
            if (entity != null)
            {
                author.AddEntity(entity);
            }
        }

        public List<Author> ListByPositiveRatioDesc()
        {
            List<Author> authList = Repository.GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.PositiveRatio() > y.PositiveRatio()) return -1;
                else if (x.PositiveRatio() < y.PositiveRatio()) return 1;
                return 0;
            });
            return authList;

        }

        public List<Author> ListByNegativeRatioDesc()
        {
            List<Author> authList = Repository.GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.NegativeRatio() > y.NegativeRatio()) return -1;
                else if (x.NegativeRatio() < y.NegativeRatio()) return 1;
                return 0;
            });
            return authList;

        }

        public List<Author> ListByEntityNumberDesc()
        {
            List<Author> authList = Repository.GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (x.MentionedEntities.Count() > y.MentionedEntities.Count()) return -1;
                else if (x.MentionedEntities.Count() < y.MentionedEntities.Count()) return 1;
                return 0;
            });
            return authList;
        }

        public List<Author> ListByPhraseAverageDesc()
        {
            List<Author> authList = Repository.GetAuthors();
            authList.Sort(delegate (Author x, Author y)
            {
                if (!Repository.AuthorHasPhrases(x)) return 1;
                if (!Repository.AuthorHasPhrases(y)) return -1;
                int activeDaysX = (DateTime.Now - Repository.GetFirstPhraseDate(x)).Days;
                double averageX = (activeDaysX == 0) ? 0 : (double)x.TotalPosts / activeDaysX;

                int activeDaysY = (DateTime.Now - Repository.GetFirstPhraseDate(y)).Days;
                double averageY = (activeDaysY == 0) ? 0 : (double)y.TotalPosts / activeDaysY;

                if (averageX > averageY) return -1;
                else if (averageX < averageY) return 1;
                return 0;
            });
            return authList;
        }

    }
}
