using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace podejmijTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            View view = new podejmijTest.View();
            Model model = new podejmijTest.Model();
            Presenter presenter = new Presenter(view, model);
            Application.EnableVisualStyles();
            Application.Run((View) view);
        }
    }
}
