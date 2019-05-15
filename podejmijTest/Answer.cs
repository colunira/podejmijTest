using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Answer
    {
        uint id;
        bool correct;
        public Answer(uint id, bool correct)
        {
            this.id = id;
            this.correct = correct;
        }
    }
}
