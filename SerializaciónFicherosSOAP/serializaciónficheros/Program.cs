using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


using System.IO;


namespace SerializaciónFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("datos.txt", FileMode.Create);
            Empleado e = new Empleado();
            e.Apellido = "Garcia";
            e.Edad = 38;
            e.FechaIngreso = DateTime.Now.AddDays(-5);
            e.Identificacion = 12345678;
            e.Nombre = "Bea";
            e.Telefono = "956123123";
            SoapFormatter format = new SoapFormatter();
            format.Serialize(f, e);
            f.Close();
            Empleado e2 = new Empleado();
            f = new FileStream("datos.txt", FileMode.Open);
            e2 = (Empleado)format.Deserialize(f);
            Console.WriteLine("Nombre Empleado:{0}", e.Nombre);
            Console.ReadKey();

        }
    }
}
