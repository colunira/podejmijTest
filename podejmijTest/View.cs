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
    public partial class View : Form,IView
    {
        public View()
        {
            InitializeComponent();
        }
        public event Action ReadXML;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            ReadXML?.Invoke();
        }
    }
}
