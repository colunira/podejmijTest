using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace podejmijTest
{
    class Model
    {
        
        private Test test;
        private int currentQuestion = 1;
        private List<int>[] userAnswers;
        #region Properties
        public int CurrentQuestion { get { return currentQuestion; } }
        public string ReturnTestName { get { return test.Title; } }
        public string ReturnTestLevel { get { return test.Level; } }
        public string ReturnTestAuthor { get { return test.Author; } }
        public byte ReturnTestTime { get { return test.Time; } }
        public int[] ReturnQuestionsAmount { get { return new int[] { CurrentQuestion, test.Questions.Count }; } }
        public string ReturnCurrentQuestionText { get { return test.Questions[currentQuestion - 1].Text; } }
        public string[] ReturnCurrentQuestionAnswers
        {
            get
            {
                int l = test.Questions[currentQuestion - 1].Answers.Count;
                string[] r = new string[l];
                for (int i = 0; i < l; i++)
                {
                    r[i] = test.Questions[currentQuestion - 1].Answers[i].Text;
                }
                return r;
            }
        }
        public int[] ReturnCheckedAnsers
        {
            get
            {
                return userAnswers[currentQuestion - 1].ToArray();
            }
        }
        #endregion
        
        public void readXML(string path)
        {
            XmlDocument xml = new XmlDocument();
            Console.WriteLine(path);
            xml.Load(path);
            XmlNodeList tests = xml.GetElementsByTagName("test");
            XmlNode t = tests[0];
            string level = t.Attributes.GetNamedItem("level").InnerText;
            string author = t.Attributes.GetNamedItem("author").InnerText;
            string title = t.Attributes.GetNamedItem("title").InnerText;
            byte time = byte.Parse(t.Attributes.GetNamedItem("time").InnerText);
            test = new Test(level, author, title, time);

            XmlNodeList questions = xml.GetElementsByTagName("question");
            foreach (XmlNode q in questions)
            {
                uint id = uint.Parse(q.Attributes.GetNamedItem("number").InnerText);
                string text = q.Attributes.GetNamedItem("text").InnerText.Trim();
                Question question = new Question(id, text);
                foreach (XmlNode a in q.ChildNodes)
                {
                    uint Id = uint.Parse(a.Attributes.GetNamedItem("number").InnerText);
                    bool correct = bool.Parse(a.Attributes.GetNamedItem("correct").InnerText);
                    string Text = a.InnerText.Trim();
                    Answer answer = new Answer(Id, correct, Text);

                    question.Answers.Add(answer);
                }
                test.Questions.Add(question);
            }
            userAnswers = new List<int>[test.Questions.Count];
            for (int i = 0; i < userAnswers.Length; i++)
            {
                userAnswers[i] = new List<int>();
            }
        }
        public void NextQuestion(string whichWay)
        {
            if (whichWay == "next")
            {
                if (currentQuestion == test.Questions.Count)
                    currentQuestion = 1;
                else
                    currentQuestion += 1;
            }
            if (whichWay == "previous")
            {
                if (currentQuestion == 1)
                    currentQuestion = test.Questions.Count;
                else
                    currentQuestion -= 1;
            }
        }
        public void SaveCheckedAnswers(int[] answers)
        {
            userAnswers[currentQuestion - 1].Clear();
            userAnswers[currentQuestion - 1].AddRange(answers);
        }
        public int[] CalculateResult()
        {
            int points = 0;
            switch (test.Level)
            {
                case "easy":
                    

                    for (int i = 0; i < userAnswers.Length; i++)
                    {
                        List<int> incorrectAnswers = new List<int>();
                        foreach (var a in test.Questions[i].Answers)
                        {
                            if (a.Correct == false)
                            {
                                incorrectAnswers.Add((int)a.Id-1);
                            }

                        }
                        //jeśli w zbiorze Incorrect \ (Incorrect \ odpowiedzi usera) nie ma nic to nie popełniono błędu
                        //można przyznać punkty za każdą poprawną odpowiedź
                        if (!incorrectAnswers.Except(incorrectAnswers.Except(userAnswers[i])).Any())
                        {
                            foreach (var a in userAnswers[i]) points++;
                        }
                    }
                    break;
                case "medium":
                    for (int i = 0; i < userAnswers.Length; i++)
                    {
                        List<int> incorrectAnswers = new List<int>();
                        List<int> correctAnswers = new List<int>();
                        foreach (var a in test.Questions[i].Answers)
                        {
                            if (a.Correct == false)
                            {
                                incorrectAnswers.Add((int)a.Id - 1);
                            }
                            else
                            {
                                correctAnswers.Add((int)a.Id - 1);
                            }
                        }
                        //jeśli w zbiorze Incorrect \ (Incorrect \ odpowiedzi usera) nie ma nic to nie popełniono błędu
                        //można przyznać punkty za każdą poprawną odpowiedź
                        foreach (var wrong in incorrectAnswers.Except(incorrectAnswers.Except(userAnswers[i])))
                            points--;
                        foreach (var right in correctAnswers.Except(correctAnswers.Except(userAnswers[i])))
                            points++;
                    }
                    break;
                case "hard":
                    for (int i = 0; i < userAnswers.Length; i++)
                    {
                        List<int> incorrectAnswers = new List<int>();
                        foreach (var a in test.Questions[i].Answers)
                        {
                            if (a.Correct == false)
                            {
                                incorrectAnswers.Add((int)a.Id - 1);
                            }

                        }
                        //jeśli w zbiorze Incorrect \ (Incorrect \ odpowiedzi usera) nie ma nic to nie popełniono błędu
                        //można przyznać punkty za każdą poprawną odpowiedź
                        if (!incorrectAnswers.Except(incorrectAnswers.Except(userAnswers[i])).Any())
                        {
                            foreach (var a in userAnswers[i]) points++;
                        }
                        else if (incorrectAnswers.Except(incorrectAnswers.Except(userAnswers[i])).Any())
                        {
                            foreach (var wrong in incorrectAnswers.Except(incorrectAnswers.Except(userAnswers[i])))
                                points--;
                        }
                    }
                    break;
            }
            int maxPoints = 0;
            foreach(var q in test.Questions)
            {
                foreach (var a in q.Answers)
                    if (a.Correct==true) maxPoints++;
            }
            return new int[] { points, maxPoints };
        }
    }
}
