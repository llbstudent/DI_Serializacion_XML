using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;


namespace XmlWriter_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter writer = null;

            try
            {

                 
                XmlWriterSettings settings = new XmlWriterSettings();
                
                settings.Indent = true;
                settings.IndentChars = ("\t");
                settings.OmitXmlDeclaration = true;

                
                writer = XmlWriter.Create("data.xml", settings);

                writer.WriteStartElement("book");
                writer.WriteElementString("item", "tesing");
                writer.WriteEndElement();

                writer.Flush();

            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            Console.WriteLine("Fichero creado");
            Console.ReadLine();
        }
    }
}
