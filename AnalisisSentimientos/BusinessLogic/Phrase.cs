using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Phrase
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Author Author { get; set; }

        public Phrase()
        {

        }
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
