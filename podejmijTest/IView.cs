using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    public interface IView
    {

        string TestName { set; }
        string Level { set; }
        string Author { set; }
        string Time { set; }
        int TimeValue { set; }
        int [] QuestionsAmount { set; }
        string QuestionText { set; }
        string[] Questions { set; }
        int [] QuestionsSelected { get; set; }
        event Action<string> ReadXML;
        event Action GetTestProperties;
        event Action StartTest;
        event Action<string> NextQuestion;
        event Action SaveCheckedAnswers;
        event Action FinishTest;
        void ShowResults(int points, int maxPoints);
    }
}
