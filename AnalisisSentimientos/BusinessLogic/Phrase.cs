using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Phrase
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Phrase() { }
        public Phrase(string aContent, DateTime aDate)
        {
            Content = aContent;
            Date = aDate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not a Phrase
            if (!(obj is Phrase))
            {
                return false;
            }
            Phrase p = obj as Phrase;
            return (Content.Equals(p.Content) && Date.Equals(p.Date));
        }

        public override string ToString()
        {
            return string.Format("{0}", Content);
        }

        public Phrase Clone()
        {
            return new Phrase(Content, Date);
        }
    }
}
