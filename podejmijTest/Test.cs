using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Test
    {
        string level;
        string author;
        string title;
        byte time;
        List<Question> questions;
        public Test(string level, string author, string title, byte time, List<Question> questions)
        {
            this.level = level;
            this.author = author;
            this.title = title;
            this.time = time;
            this.questions = new List<Question>();
            foreach(var q in questions)
            {
                this.questions.Add(q);
            }
        }
    }
}
