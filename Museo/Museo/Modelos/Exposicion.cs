using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Exposicion
    {
        public string nombre { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaFinReplanificada { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaInicioReplanificada { get; set; }
        public DateTime horaApertura{ get; set; }
        public DateTime horaCierre { get; set; }
        public DetalleExposicion[] detalle { get; set; }

        public bool esVigente(DateTime fechaActual)
        {
            if ((fechaInicio <= fechaActual || fechaInicioReplanificada <= fechaActual) && (fechaActual <= fechaFin || fechaActual <= fechaFinReplanificada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime calcularDuracionObrasExpuestas()
        {
            object[] res = new object[detalle.Length];
            DateTime hora = new DateTime();
            for (int i = 0; i < detalle.Length; i++)
            {
                if (hora.ToString() == "1/1/0001 00:00:00")
                {
                    hora = (detalle[i].buscarDuracEstimadaObra());
                }
                else
                {
                    hora = hora.AddTicks((detalle[i].buscarDuracEstimadaObra()).Ticks);
                }
            }

            return hora;
        }
    }
}
