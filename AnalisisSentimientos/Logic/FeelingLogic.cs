using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FeelingLogic
    {
        private FeelingPersistence Feelings { get; set; }

        public FeelingLogic()
        {
            Feelings = new FeelingPersistence();
        }

        public void AddFeeling(Feeling aFeeling)
        {
            if (RepeatedFeeling(aFeeling.Name))
            {
                throw new ApplicationException("no es posible agregar el mismo sentimiento " +
                       "o una subsecuencia de un sentimiento que ya se encuentra en la lista");
            }
            Feelings.Add(aFeeling);
        }

        private bool RepeatedFeeling(string name)
        {
            var nameLower = name.ToLower();
            //Three Cases: 
            //1. The name is excactly the same (lower/upper case also)
            //2. Name is a substring of f.Name
            //3. f.Name is a substring of Name
            foreach (Feeling f in Feelings.Get())
            {
                if (f.Name.ToLower().Contains(nameLower) || nameLower.Contains(f.Name.ToLower()))
                    return true;
            }
            return false;
        }
        public void DeleteFeeling(Feeling aFeeling)
        {
            if (Feelings.Get().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Feelings.Get().Remove(aFeeling);
        }

        public Feeling[] GetFeelings
        {
            get { return Feelings.Get().ToArray(); }
        }

    }
}
