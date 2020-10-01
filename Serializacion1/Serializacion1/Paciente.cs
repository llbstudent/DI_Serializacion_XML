using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion1
{
    [Serializable]
    class Paciente
    {
        public int edad { get; private set; }
        public string nombre { get; private set; }
        public string direc { get; private set; }
        public string dni { get; private set; }


        public Paciente()
        {

        }
        public Paciente(string d,string n,string di, int e)
        {
            dni = d;
            nombre = n;
            direc = di;
            edad = e;
        }
        
    }
}
