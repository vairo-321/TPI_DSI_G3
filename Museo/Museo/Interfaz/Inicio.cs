using Museo.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo
{
    public partial class PantallaPrincipal : Form
    {
        GestorRegistroVentaEntrada gestor = new GestorRegistroVentaEntrada();

        string montoTarifa;
        string tipoEntrada;
        string tipoVisita;
        string montoAdTarifa;
        string idTarifa;
        string fechaInicio;
        string fechaFin;
        public PantallaPrincipal()
        {
            InitializeComponent();
            panelResultado.Visible = false;
            dgvTarifas.Visible = false;
        }

        public void mostrarTarifas()
        {
            object[,] rows = gestor.buscarTarifasSedeActual();
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                object[] row = new object[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }

                dgvTarifas.Rows.Add(row);
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelResultado.Visible = true;
            dgvTarifas.Visible = true;
            mostrarTarifas();
        }

        private void dgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            //obtienes la fila seleccionada
            DataGridViewRow row = dgvTarifas.Rows[e.RowIndex];

            //por el numero obtiene la columna
            montoTarifa = row.Cells[0].Value.ToString();
            tipoEntrada = row.Cells[1].Value.ToString();
            tipoVisita = row.Cells[2].Value.ToString();
            montoAdTarifa = row.Cells[3].Value.ToString();
            idTarifa = row.Cells[4].Value.ToString();
            fechaInicio = row.Cells[5].Value.ToString();
            fechaFin = row.Cells[6].Value.ToString();

            txtDuracionExposicion.Visible = false;
            txtDuracionExposicion.Text = gestor.tomarSeleccionTarifa(tipoVisita);

            txtCantidad.Enabled = true;
            txtCantidad.Visible = true;
            label1.Visible = true;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (int.Parse(montoAdTarifa) != 0)
                    {
                        mostrarDetallesEntrada(int.Parse(txtCantidad.Text), TimeSpan.Parse(txtDuracionExposicion.Text), int.Parse(montoTarifa) + int.Parse(montoAdTarifa));
                    }
                    else
                    {
                        mostrarDetallesEntrada(int.Parse(txtCantidad.Text), TimeSpan.Parse(txtDuracionExposicion.Text), int.Parse(montoTarifa));
                    }

                    DialogResult dialogResult = MessageBox.Show("Confirma la venta?", "Venta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gestor.tomarConfirmacionVenta(int.Parse(txtCantidad.Text), int.Parse(montoTarifa), int.Parse(idTarifa), tipoEntrada, tipoVisita, int.Parse(montoAdTarifa), DateTime.Parse(fechaInicio), DateTime.Parse(fechaFin));
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se registró la venta!");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        private void mostrarDetallesEntrada(int cantEntradas, TimeSpan duracion, int monto)
        {
            dgvDetalle.Visible = true;
            dgvTarifas.Visible = false;
            int[] detalle = gestor.tomarCantidadEntradas(cantEntradas, duracion, monto);

            dgvDetalle.Rows[0].Cells[0].Value = detalle[0];
            dgvDetalle.Rows[0].Cells[1].Value = detalle[1];
            dgvDetalle.Rows[0].Cells[2].Value = detalle[2];
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //gestor.tomarConfirmacionVenta(int.Parse(txtCantidad.Text), int.Parse(montoTarifa), int.Parse(idTarifa), tipoEntrada, tipoVisita, int.Parse(montoAdTarifa), DateTime.Parse(fechaInicio), DateTime.Parse(fechaFin));
        }
    }
}
