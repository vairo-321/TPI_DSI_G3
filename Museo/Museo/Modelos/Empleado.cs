using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Empleado
    {
        public string apellido { get; set; }
        public string codigoValidacion { get; set; }
        public string cuit { get; set; }
        public string dni { get; set; }
        public string domicilio { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public Sede sedeDondeTrabaja { get; set; }

        public int conocerEmpleado()
        {
            return sedeDondeTrabaja.getSede();
        }
    }
}
