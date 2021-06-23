using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Entrada
    {
        public int numero {get; set;}
        public DateTime fechaVenta { get; set; }
        public TimeSpan horaVenta { get; set; }
        public int monto { get; set; }
        public Sede sede { get; set; }
        public Tarifa tarifa { get; set; }

        public bool esDeSedeActual(int numero)
        {
            if (numero == sede.numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esDeFechaHora(DateTime fechaActual)
        {
            if (fechaActual.ToString("dd/MM/yyyy") == fechaVenta.ToString("dd/MM/yyyy"))
            {
                if (TimeSpan.FromTicks(Convert.ToDateTime(fechaVenta.ToString()).Ticks) <= TimeSpan.FromTicks(Convert.ToDateTime(fechaActual.ToString()).Ticks))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int getNumero()
        {
            return numero;
        }
    }
}
