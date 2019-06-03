using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Question
    {
        public uint Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; } //get
        public Question(uint id, string text)
        {
            Id = id;
            Text = text;
            Answers = new List<Answer>();
        }
    }
}
