using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Sede
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public int cantMaximaVisitantes { get; set; }
        public int cantMaxPorGuia { get; set; }
        public Tarifa[] tarifa { get; set; }
        public Exposicion[] exposicion { get; set; }

        public int getSede()
        {
            return numero;
        }
        public object[,] getTarifa(DateTime fechaActual)
        {
            object[,] objeto = new object[tarifa.Length, 7];

            for (int i = 0; i < tarifa.Length; i++)
            {
                if (tarifa[i].esVigente(fechaActual))
                {
                    objeto[i, 0] = tarifa[i].getMonto();
                    objeto[i, 1] = tarifa[i].getTipoDeEntrada();
                    objeto[i, 2] = tarifa[i].getTipoVisita();
                    objeto[i, 3] = tarifa[i].getMontoAdicionalGuia();
                    objeto[i, 4] = tarifa[i].idTarifa;
                    objeto[i, 5] = tarifa[i].fechaInicioVigencia;
                    objeto[i, 6] = tarifa[i].fechaFinVigencia;
                }
            }

            return objeto;
        }

        public DateTime[] calcularDuracionAExposicionesVigentes(DateTime fechaActual)
        {
            DateTime[] obj = new DateTime[exposicion.Length];

            for (int i = 0; i < exposicion.Length; i++)
            {

                if (exposicion[i].esVigente(fechaActual))
                {
                    obj[i] = exposicion[i].calcularDuracionObrasExpuestas();
                }
            }

            return obj;
        }

        public int calcularCantidadReservada(ReservaVisita[] reserva, DateTime fechaActual, TimeSpan duracion)
        {
            int total = 0;
            for (int i = 0; i < reserva.Length; i++)
            {
                if (reserva[i].esSedeActual(numero) && reserva[i].esDeFechaHora(fechaActual, duracion))
                {
                    if (total == 0)
                    {
                        total = reserva[i].getCantidadAlumnosConfirmada();
                    }
                    else
                    {
                        total = total + reserva[i].getCantidadAlumnosConfirmada();
                    }
                }
            }

            return total;
        }

        public int getCantMaximaVisitantes()
        {
            return cantMaximaVisitantes;
        }
    }
}
