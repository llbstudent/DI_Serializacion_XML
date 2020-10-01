using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializaciónFicheros
{
     [Serializable]
    class Empleado
    {
        private int identificacion;
        private string nombre;
        private string apellido;
        private int edad;
        private string telefono;
        private DateTime fechaIngreso;
        private int diasLaborados;

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
        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
            set
            {
                fechaIngreso = value;
                DiasLaborados = (DateTime.Now.Subtract(fechaIngreso).Days);
            }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int DiasLaborados
        {
            get
            {
                return diasLaborados;
            }
            set
            {
                diasLaborados = value;
            }
        }
    }
}
