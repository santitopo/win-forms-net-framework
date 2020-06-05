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
        private AnalysisPersistence Analysis { get; set; }
        private FeelingLogic Feelings { get; }
        private EntityLogic Entities { get; }

        public AnalysisLogic(FeelingLogic feelings, EntityLogic entities){
            Analysis = new AnalysisPersistence();
            Feelings = feelings;
            Entities = entities;
        }

        public void AddAnalysis(Analysis anAnalysis)
        {
            Analysis.Add(anAnalysis);
        }

        public Analysis[] GetAnalysis
        {
            get { return Analysis.Get().ToArray(); }
        }

        public Analysis ExecuteAnalysis(Phrase aPhrase)
        {
            Analysis newAnalysis = new Analysis();
            newAnalysis.ExecuteAnalysis(Entities.GetEntitites, Feelings.GetFeelings, aPhrase);
            return newAnalysis;
        }
    }
}
