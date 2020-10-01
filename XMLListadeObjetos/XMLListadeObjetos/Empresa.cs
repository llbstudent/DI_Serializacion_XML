using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLListadeObjetos
{
    [Serializable()]
    [XmlRoot("Empresa")]
    public class Empresa
    {
        private List<Empleado> le;

        public List<Empleado> LE
        {
            get { return le; }
            set { le = value; }
        }

        public Empresa()
        {
            le = new List<Empleado>();
        }
    }
}
