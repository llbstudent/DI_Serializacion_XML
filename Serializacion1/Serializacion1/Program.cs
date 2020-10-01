using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serializacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("1234", "Pepe López", "Calle Sol", 35);
            Stream fichero=null;
            BinaryFormatter b = new BinaryFormatter();
            try
            {
                fichero = File.Open("Pacientes.bin", FileMode.Append);
                b.Serialize(fichero, p);
                Console.WriteLine("Paciente escrito en fichero");
                fichero.Close();
                fichero = File.Open("Pacientes.bin", FileMode.Open);
                p = null;
                p = (Paciente)b.Deserialize(fichero);
                Console.WriteLine("DNI:{0}, Nombre:{1}, Dirección:{2},Telefono:{3}",p.dni,p.nombre,p.direc,p.edad);

            }
            catch (IOException ex)
            {
                Console.WriteLine("Se ha producido un error:" + ex.Message);
            }
            finally
            {
                if (fichero != null)
                    fichero.Close();
            }
            Console.ReadKey();
        }
    }
}
