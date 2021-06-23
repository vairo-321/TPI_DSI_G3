using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class Obra
    {
        public int alto { get; set; }
        public int ancho { get; set; }
        public int codigoSensor { get; set; }
        public string descripcion { get; set; }
        public DateTime duracionExtendida { get; set; }
        public DateTime duracionResumida { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaPrimerIngreso { get; set; }
        public string nombreObra{ get; set; }
        public int peso { get; set; }
        public int valuacion { get; set; }

        public DateTime getDuracResumida()
        {
            return duracionResumida;
        }
    }
}
