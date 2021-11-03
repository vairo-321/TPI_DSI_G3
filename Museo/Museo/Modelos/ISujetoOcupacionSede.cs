using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Modelos
{
    public interface ISujetoOcupacionSede
    {

        void desuscribir(IObservadorOcupacionSede obj);

        void notificar();

        void suscribir(IObservadorOcupacionSede obj);

    }
}
