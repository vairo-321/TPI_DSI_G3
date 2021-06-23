using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class ReservaVisita
    {
        public int numeroReserva { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public TimeSpan duracionEstimada { get; set; }
        public DateTime fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public TimeSpan horaFinReal { get; set; }
        public TimeSpan horaInicioReal { get; set; }
        public Exposicion[] exposicion { get; set; }
        public Sede sede { get; set; }

        public bool esSedeActual(int numero)
        {
            if (sede.numero == numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esDeFechaHora(DateTime fechaActual, TimeSpan duracion)
        {
            if (fechaActual == (fechaHoraReserva.Date))
            {
                if (duracion == (horaFinReal - horaInicioReal))
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

        public int getCantidadAlumnosConfirmada()
        {
            return cantidadAlumnosConfirmada;
        }
    }
}
