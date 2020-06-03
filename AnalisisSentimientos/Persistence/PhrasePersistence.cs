using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PhrasePersistence
    {
        private List<Phrase> phrases;

        public PhrasePersistence()
        {
            phrases = new List<Phrase>();
        }

        public void Add(Phrase aPhrase)
        {
            phrases.Add(aPhrase);
        }

        public void Delete(Phrase aPhrase)
        {
            phrases.Remove(aPhrase);
        }

        public List<Phrase> Get()
        {
            return phrases;
        }
    }
}
