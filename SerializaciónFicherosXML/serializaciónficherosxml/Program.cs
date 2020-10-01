using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SerializaciónFicherosXML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("datos.xml", FileMode.Create);
            Empleado e = new Empleado();
            
            
            e.Apellido = "Garcia";
            e.Edad = 38;
            e.Identificacion = 12345678;
            e.Nombre = "Bea";
            e.Telefono = "956123123";
            
            XmlSerializer format = new XmlSerializer(e.GetType());
            format.Serialize(f, e);

            e.Apellido = "Gómez";
            e.Edad = 25;
            e.Identificacion = 33345678;
            e.Nombre = "Antonio";
            e.Telefono = "956456456";
            format.Serialize(f, e);
            f.Close();
            Empleado e2 = new Empleado();
            f = new FileStream("datos.xml", FileMode.Open);
            while (f.Position < f.Length)
            {
                e2 = (Empleado)format.Deserialize(f);
                Console.WriteLine("Nombre Empleado:{0}", e2.Nombre);

            }
            f.Close();               
            Console.ReadKey();
        }
    }
}
