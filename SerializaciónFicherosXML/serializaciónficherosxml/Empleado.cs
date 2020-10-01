using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializaciónFicherosXML
{
    [Serializable()]
    [XmlRoot("Empleado")]
    public class Empleado
    {
        private int identificacion;
        private string nombre;
        private string apellido;
        private int edad;
        private string telefono;
        
        public int Identificacion
        {
            get
            {
                return identificacion;
            }
            set
            {
                identificacion = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
       
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
    }
}
