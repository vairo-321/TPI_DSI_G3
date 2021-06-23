using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo.Interfaz
{
    public partial class PantallaEntrada : Form
    {
        public PantallaEntrada()
        {
            InitializeComponent();
        }

        public void actualizarPantalla(int cantPersonas, int capacidad)
        {
            lblCantActual.Text = cantPersonas.ToString() + " PERSONAS DENTRO";
            lblCapacidad.Text = capacidad.ToString() + " CAPACIDAD MAXIMA";
        }
    }
}
