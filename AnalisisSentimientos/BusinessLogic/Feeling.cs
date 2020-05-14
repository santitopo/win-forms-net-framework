using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Feeling
    {
        public string Name { get; set; }
        public bool Type { get; set; }

        public Feeling(){}

        public Feeling(string name, bool type)
        {
            Name = name;
            Type = type;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Feeling f = obj as Feeling;
            return (Name.Equals(f.Name) && Type.Equals(f.Type));
        }

        public override string ToString()
        {
            return string.Format("Name:{0}, Type:{1}", Name, Type);
        }
    }
}
