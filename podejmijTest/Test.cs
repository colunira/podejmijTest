using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Test
    {
        public string Level { get; } 
        public string Author { get; } 
        public string Title { get; } 
        public byte Time { get; } 
        public List<Question> Questions { get; } //get
        public Test()
        {
            Level = "";
            Author = "";
            Title = "";
            Time = 0;
            List<Question> questions = new List<Question>();
        }
        public Test(string level, string author, string title, byte time)
        {
            Level = level;
            Author = author;
            Title = title;
            Time = time;
            Questions = new List<Question>();
        }
    }
}
