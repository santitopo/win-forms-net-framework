using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PhraseLogic
    {
        private PhrasePersistence Phrases { get; set; }

        public PhraseLogic()
        {
            Phrases = new PhrasePersistence();
        }

        public void AddPhrase(Phrase aPhrase)
        {
            Phrases.Add(aPhrase);
        }
        public Phrase[] GetPhrases
        {
            get { return Phrases.Get().ToArray(); }
        }

        public void DeletePhrase(Phrase aPhrase)
        {
            if (Phrases.Get().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Phrases.Delete(aPhrase);
        }
    }
}
