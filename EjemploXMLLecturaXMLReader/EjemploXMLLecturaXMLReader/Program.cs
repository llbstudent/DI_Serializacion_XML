using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjemploXMLLecturaXMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("datos.xml");
            XmlNode child = doc.SelectSingleNode("/Empleados");

            if (child != null)
            {
                XmlNodeReader nr = new XmlNodeReader(child);
                while (nr.Read())
                    Console.WriteLine(nr.Value);
            }

            Console.ReadKey();
        }
    }
}
