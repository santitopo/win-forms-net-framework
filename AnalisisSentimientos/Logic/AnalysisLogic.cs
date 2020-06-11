using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AnalysisLogic
    {
        public Repository Repository { get; }

        private AuthorLogic Authors { get; }
        private FeelingLogic Feelings { get; }
        private EntityLogic Entities { get; }

        public AnalysisLogic(FeelingLogic feelings, EntityLogic entities, Repository repo, AuthorLogic authors)
        {
            Repository = repo;
            Feelings = feelings;
            Entities = entities;
            Authors = authors;
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            Repository.AddAnalysis(anAnalysis);
            Repository.UpdateAuthorCounterBD(anAnalysis);
            Authors.UpdateAuthorCounter(anAnalysis);
            Authors.UpdateAuthorEntities(anAnalysis);
        }

        public Analysis[] GetAnalysis
        {
            get { return Repository.GetAnalysis().ToArray(); }
        }

        public Analysis ExecuteAnalysis(Phrase aPhrase)
        {
            Analysis newAnalysis = new Analysis();
            newAnalysis.ExecuteAnalysis(Entities.GetEntitites, Feelings.GetFeelings, aPhrase);
            return newAnalysis;
        }
    }
}
