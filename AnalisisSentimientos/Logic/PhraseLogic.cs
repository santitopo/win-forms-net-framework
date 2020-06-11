﻿using Domain;
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
        private Repository Repository { get; }

        public PhraseLogic(Repository repo)
        {
            Repository = repo;
        }

        public void AddPhrase(Phrase aPhrase)
        {
           Repository.AddPhrase(aPhrase);
        }
        public Phrase[] GetPhrases
        {
            get { return Repository.GetPhrases().ToArray(); }
        }

        public void DeletePhrase(Phrase aPhrase)
        {
            if (Repository.GetPhrases().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Repository.DeletePhrase(aPhrase);
        }

    }
}
