using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace XMLListadeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("datos.xml", FileMode.Create);
            Empleado e = new Empleado();
            Empresa emp = new Empresa();
            //Empleado 1
            e.Apellido = "Garcia";
            e.Edad = 38;
            e.Identificacion = 12345678;
            e.Nombre = "Bea";
            e.Telefono = "956123123";
            emp.LE.Add(e); //Lo añadimos a la lista
            //Empleado 2
            e = new Empleado();
            e.Apellido = "Gómez";
            e.Edad = 25;
            e.Identificacion = 33345678;
            e.Nombre = "Antonio";
            e.Telefono = "956456456";
            emp.LE.Add(e);


            //Creamos el formateador XML
            XmlSerializer format = new XmlSerializer(emp.GetType());
            format.Serialize(f, emp);
            
            f.Close();
            Empresa emp2 = new Empresa();
            f = new FileStream("datos.xml", FileMode.Open);
            while (f.Position < f.Length){
                emp2 = (Empresa)format.Deserialize(f);
               
            }
            f.Close();
            Console.WriteLine("Nombre Empleado:{0}", emp2.LE[1].Nombre);

            Console.ReadKey();
        }
    }
}
