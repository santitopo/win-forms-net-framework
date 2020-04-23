using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Phrase
    {
        public string content { get; set; }
        public DateTime date { get; set; }

        public Phrase() { }
        public Phrase(string aContent, DateTime aDate)
        {
            content = aContent;
            date = aDate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Phrase p = obj as Phrase;
            return (content.Equals(p.content) && date.Equals(p.date));
        }

        public override string ToString()
        {
            return string.Format("Content:{0}, Date:{1}", content, date.ToString("dd-MM-yyyy"));
        }
    }
}
