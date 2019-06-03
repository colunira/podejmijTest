using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace podejmijTest
{
    class Model
    {
        private Test test;
        public string ReturnTestName { get { return test.Title;  } }
        public string ReturnTestLevel { get { return test.Level; } }
        public string ReturnTestAuthor { get { return test.Author; } }
        public byte ReturnTestTime { get { return test.Time; } }
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
        }
    }
}
