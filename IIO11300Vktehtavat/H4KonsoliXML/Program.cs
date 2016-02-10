using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace H4KonsoliXML
{
    class Program
    {

        static void ReadWorkersFromXML (string filu)
        {

            //tutkitaan löytyykö tiedostoa
            if (System.IO.File.Exists(filu)) {
                //luetaan XML tiedosto XmlDocumentti olioon
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(filu);
                //kyselyllä haetaan halutut elementit
                XmlNodeList xnl = xmldoc.SelectNodes("/tyontekijat/tyontekija");
                XmlNodeList xnl2;
                XmlNode xn; //edustaa ykssitäistä noodia xml docissa.
                XmlNode xn2;
                //Console.WriteLine("Löytyi " + xnl.Count + " Työntekijä")
                Console.WriteLine(string.Format("Tiedostosta {0} löytyi {1} työntekijää:", filu, xnl.Count));
                for (int i = 0; i < xnl.Count; i++)
                {
                    xn = xnl.Item(i);
                    //listaan=näytetään kokonaisuudessaan
                    Console.WriteLine(xn.InnerText);
                    xnl2 = xn.ChildNodes;
                    //haedaan noodin kaikki noodit näytettäväksi
                    for (int j = 0; j < xnl2.Count; j++)
                    {
                        xn2 = xnl2.Item(j);
                        Console.WriteLine(xn2.InnerText);

                    }

                }

            }

        }

        static void Main(string[] args)
        {

            ReadWorkersFromXML("d:\\Tyontekijat.xml");

        }
    }
}
