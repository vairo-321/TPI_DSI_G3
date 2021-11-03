using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public interface IObservadorOcupacionSede
    {
        void actualizarCanVisitantes(DateTime t, int cantVisitantes, int capSede);
        
    }
}
