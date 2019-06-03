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
        event Action<string> ReadXML;
        event Action GetTestProperties;
    }
}
