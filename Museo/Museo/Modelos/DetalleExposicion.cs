using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public class DetalleExposicion
    {
        public string lugarAsignado { get; set; }
        public Obra obra { get; set; }

        public DateTime buscarDuracEstimadaObra()
        {
            return obra.getDuracResumida();
        }
    }
}
