using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Question
    {
        uint id;
        string text;
        List<Answer> answers;
        public Question(uint id, string text,List<Answer> answers)
        {
            this.id = id;
            this.text = text;
            this.answers = new List<Answer>();
            foreach (var answer in answers)
            {
                this.answers.Add(answer);
            }
        }
    }
}
