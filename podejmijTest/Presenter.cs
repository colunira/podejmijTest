using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            view.ReadXML += View_ReadXML;
            view.GetTestProperties += View_GetTestProperties;
        }

        private void View_GetTestProperties()
        {
            view.TestName = model.ReturnTestName;
            view.Level = model.ReturnTestLevel;
            view.Author = model.ReturnTestAuthor;
            view.Time = model.ReturnTestTime.ToString();
        }

        private void View_ReadXML(string path)
        {
            model.readXML(path);
        }
    }
}
