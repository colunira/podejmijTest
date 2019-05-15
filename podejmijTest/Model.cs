using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace podejmijTest
{
    class Model
    {
        public void readXML()
        {
            XDocument xml = XDocument.Load("testxml.xml");
            //Console.Write(xml.ToString());
            foreach (var q in xml.Root.Elements("question"))
            {
                
                foreach (var a in q.Elements("answer"))
                {
                    Console.WriteLine(a.Attribute("number").Value);
                }
            }
        }

    }
}
