using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AuthorAlarm : Alarm
    {
        private List<Author> associatedAuthors;

        public AuthorAlarm() 
        {
            associatedAuthors = new List<Author>();
        }
        public AuthorAlarm(Entity e, int postNum, bool type, int time) : base(e, postNum, type, time)
        {
            associatedAuthors = new List<Author>();
        }

        public override void VerifyAlarm(Analysis[] analysis, Author[] authors)
        {
            Tuple<Author, int>[] authorIncidence = initializeList(authors);

            for (int j = 0; j < analysis.Count(); j++)
            {
                Analysis actualAnalysis = analysis[j];
                Author phraseAuthor = actualAnalysis.Phrase.Author;
                DateTime phraseEntryDate = actualAnalysis.Phrase.Date;

                if (ValidDateRange(phraseEntryDate, this.TimeBack) && Match(actualAnalysis, this))
                {
                    CheckAuthor(authorIncidence, phraseAuthor, PostNumber);
                }
            }

            CheckAlarm();
        }

        private Tuple<Author, int>[] initializeList(Author[] authors)
        {
            int size = authors.Length;

            Tuple<Author, int>[] authorIncidence = new Tuple<Author, int>[size];

            for (int i = 0; i < size; i++)
            {
                Author a = authors[i];
                authorIncidence[i] = new Tuple<Author, int>(a, 0);
            }

            return authorIncidence;
        }

        private void AddAuthorToAlarm(Author anAuthor)
        {
            associatedAuthors.Add(anAuthor);
        }

        private void CheckAuthor(Tuple<Author, int>[] list, Author author, int MaxPostNumber)
        {

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Item1.Equals(author))
                {
                    int previousValue = list[i].Item2;
                    list[i] = new Tuple<Author, int>(author, previousValue+1);
                }

                if (list[i].Item2 == MaxPostNumber)
                {
                    AddAuthorToAlarm(author);
                }
            }

        }

        public override void CheckAlarm()
        {
            if (associatedAuthors.Count > 0)
            {
                State = true;
            }
        }
    }
}
