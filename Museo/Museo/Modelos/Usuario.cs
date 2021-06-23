using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Usuario
    {
        public string caducidad { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public Empleado empleado { get; set; } 

        public int conocerEmpleado()
        {
            return empleado.conocerEmpleado();
        }
    }
}
