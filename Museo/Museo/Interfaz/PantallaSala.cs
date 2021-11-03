using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Museo.Modelos;

namespace Museo.Interfaz
{
    public partial class PantallaSala : Form, IObservadorOcupacionSede
    {
        public PantallaSala()
        {
            InitializeComponent();
        }

        public void actualizarCanVisitantes(DateTime t, int cantVisitantes, int capSede)
        {
            throw new NotImplementedException();
        }
    }
}
