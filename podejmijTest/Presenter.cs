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
        }

        private void View_ReadXML()
        {
            model.readXML();
        }
    }
}
