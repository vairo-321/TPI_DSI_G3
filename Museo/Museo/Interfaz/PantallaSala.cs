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
            lbl_CapacAct.Text = cantVisitantes.ToString();
            lbl_capacMax.Text = capSede.ToString();
            lbl_fechaHora.Text = t.ToString();
            lbl_Porc.Text = calcularPorcentaje(cantVisitantes, capSede).ToString();
            this.Show();
        }

        private double calcularPorcentaje(int adentro, int capacidad)
        {
            double primero = Convert.ToDouble(adentro);
            double segundo = Convert.ToDouble(capacidad);
            return (primero / segundo) * 100;
        }
    }
}
