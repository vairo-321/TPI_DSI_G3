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
    public partial class Impresora : Form
    {
        public Impresora()
        {
            InitializeComponent();
        }

        public void imprimir(string numeroEntrada, string monto)
        {
            lblNumEntrada1.Text = numeroEntrada;
            lblNumEntrada2.Text = numeroEntrada;
            lblPrecio.Text += monto;
        }
    }
}
