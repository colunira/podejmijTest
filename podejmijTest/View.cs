using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace podejmijTest
{
    public partial class View : Form, IView
    {
        private int time;
        Timer t = new Timer();
        #region Properties
        public string TestName
        {
            set
            {
                testNameL.Text = value;
            }
        }
        public string Level
        {
            set
            {
                levelL.Text = "Poziom: " + value;
            }
        }
        public string Author
        {
            set
            {
                authorL.Text = "Autor: " + value;
            }
        }
        public string Time
        {
            set
            {
                timeL.Text = "Czas: " + value + " min";
                timeLeftL.Text = "Czas pozostały: " + value + " min";
            }
        }
        public int TimeValue
        {
            set
            {
                time = value*60;
            }
        }
        public int[] QuestionsAmount
        {
            set
            {
                questionNumberL.Text = "Pytanie nr " + value[0] + "/" + value[1];
            }
        }
        public string QuestionText
        {
            set
            {
                questionTextL.Text = value;
            }
        }
        public string[] Questions
        {
            set
            {
                answersCheckedBox.Items.Clear();
                answersCheckedBox.Items.AddRange(value);
            }
        }
        public int[] QuestionsSelected
        {
            get
            {
                int[] q = answersCheckedBox.CheckedIndices.Cast<int>().ToArray();
                return q;
            }
            set
            {
                foreach (var i in value)
                    answersCheckedBox.SetItemChecked(i, true);
            }

        }

        #endregion
        public View()
        {
            InitializeComponent();
        }
        public event Action<string> ReadXML;
        public event Action GetTestProperties;
        public event Action StartTest;
        public event Action<string> NextQuestion;
        public event Action SaveCheckedAnswers;
        public event Action FinishTest;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartTest?.Invoke();
            nextB.Enabled = true;
            previousB.Enabled = true;
            finishB.Enabled = true;
            Console.WriteLine(time);
            if (time != 0)
            {
                t.Interval = 1000;
                t.Tick += T_Tick;
                t.Start();
            }
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int minutes = time / 60;
            int seconds = time % 60;
            timeLeftL.Text = "Czas pozostały: ";
            if (minutes < 10)
                timeLeftL.Text += "0" + minutes;
            else timeLeftL.Text += minutes;
            timeLeftL.Text += ":";
            if (seconds < 10)
                timeLeftL.Text += "0" + seconds;
            else timeLeftL.Text += seconds;
            time--;
            if (time==0)
            {
                t.Stop();
                FinishTest?.Invoke();
            }
        }

        private void chooseTestB_Click(object sender, EventArgs e)
        {
            chooseFileDialog.ShowDialog();
        }

        private void chooseFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = chooseFileDialog.FileName;
            ReadXML?.Invoke(path);
            GetTestProperties?.Invoke();
            startB.Enabled = true;
        }

        private void previousB_Click(object sender, EventArgs e)
        {
            SaveCheckedAnswers?.Invoke();
            NextQuestion?.Invoke("previous");
        }

        private void nextB_Click(object sender, EventArgs e)
        {
            SaveCheckedAnswers?.Invoke();
            NextQuestion?.Invoke("next");
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            t.Stop();
            SaveCheckedAnswers?.Invoke();
            FinishTest?.Invoke();
            startB.Enabled = false;
            nextB.Enabled = false;
            previousB.Enabled = false;
            finishB.Enabled = false;
        }

        public void ShowResults(int points, int maxPoints)
        {
            MessageBox.Show("Wynik: " + points + "/" + maxPoints);
            nextB.Enabled = false;
            previousB.Enabled = false;
            finishB.Enabled = false;
        }


    }
}
