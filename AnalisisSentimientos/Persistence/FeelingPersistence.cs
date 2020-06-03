using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class FeelingPersistence
    {
        private List<Feeling> feelings;

        public FeelingPersistence()
        {
            feelings = new List<Feeling>();

        }

        public void Add(Feeling aFeeling)
        {
            feelings.Add(aFeeling);
        }

        public void Delete(Feeling aFeeling)
        {
            feelings.Remove(aFeeling);
        }

        public List<Feeling> Get()
        {
            return feelings;
        }

    }
}
