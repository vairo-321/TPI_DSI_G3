using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Tarifa
    {
        public int idTarifa { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public DateTime fechaInicioVigencia { get; set; }
        public int monto { get; set; }
        public int montoAdicionalGuia { get; set; }
        public TipoDeEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }

        public bool esVigente(DateTime fechaActual)
        {
            if (fechaInicioVigencia <= fechaActual && fechaActual <= fechaFinVigencia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getMonto()
        {
            return monto;
        }

        public string getTipoDeEntrada()
        {
            return tipoEntrada.getNombre();
        }

        public string getTipoVisita()
        {
            return tipoVisita.getNombre();
        }

        public int getMontoAdicionalGuia()
        {
            return montoAdicionalGuia;
        }
    }
}
