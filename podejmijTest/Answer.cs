using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Answer
    {
        public uint Id { get; set; }
        public bool Correct { get; set; }
        public string Text { get; set; }
        public Answer(uint id, bool correct, string text)
        {
            Id = id;
            Correct = correct;
            Text = text;
        }
    }
}
