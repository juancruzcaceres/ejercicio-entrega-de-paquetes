using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CodigoPostal { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Telefono { get; set; }

    }
}
