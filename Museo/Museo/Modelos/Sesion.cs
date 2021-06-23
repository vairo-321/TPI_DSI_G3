using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Sesion
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public Usuario usuario { get; set; }

        public int conocerUsuario()
        {
            return usuario.conocerEmpleado();
        }
    }
}
