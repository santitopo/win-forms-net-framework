using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AuthorAlarm : Alarm
    {
        private List<Author> authors;

        public AuthorAlarm()
        {
            authors = new List<Author>();
        }

        public override void VerifyAlarm(Analysis[] analysis)
        {
            for (int j = 0; j < analysis.Count(); j++)
            {
                Analysis actualAnalysis = analysis[j];
                Author phraseAuthor = actualAnalysis.Phrase.Author;
                DateTime phraseEntryDate = actualAnalysis.Phrase.Date;

                if (ValidDateRange(phraseEntryDate, this.TimeBack) && Match(actualAnalysis, this))
                {
                    //chequear autores
                    IncreaseCounter();
                    CheckAlarm();
                }
            }
        }

        private void AddAuthorToAlarm(Author anAuthor)
        {
            authors.Add(anAuthor);
        }

        private void CheckAuthors()
        {

            //Tuple<Phrase, int> = new Tuple<Phrase, int>( , 1) 
        }
    }
}
