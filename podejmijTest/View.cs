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
                timeL.Text = "Czas: " + value;
            }
        }
        public View()
        {
            InitializeComponent();
        }
        public event Action<string> ReadXML;
        public event Action GetTestProperties;
        private void buttonStart_Click(object sender, EventArgs e)
        {

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
            testNameL.Visible = true;
            levelL.Visible = true;
            authorL.Visible = true;
            timeL.Visible = true;
        }
    }
}
