using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class AnalysisPersistence
    {
        private List<Analysis> analysis;

        public AnalysisPersistence()
        {
            analysis = new List<Analysis>();

        }

        public void Add(Analysis anAnalysis)
        {
            analysis.Add(anAnalysis);
        }

        public void Delete(Analysis anAnalysis)
        {
            analysis.Remove(anAnalysis);
        }

        public List<Analysis> Get()
        {
            return analysis;
        }

    }
}
