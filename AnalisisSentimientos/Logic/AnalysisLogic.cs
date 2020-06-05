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
        private Repository Repository { get; }
        private FeelingLogic Feelings { get; }
        private EntityLogic Entities { get; }

        public AnalysisLogic(FeelingLogic feelings, EntityLogic entities, Repository repo){
            Repository = repo;
            Feelings = feelings;
            Entities = entities;
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            Repository.AddAnalysis(anAnalysis);
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
