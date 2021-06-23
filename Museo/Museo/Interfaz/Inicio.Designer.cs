
namespace Museo
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonIndi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDuracionExposicion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.entradasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaReservaToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // nuevaReservaToolStripMenuItem
            // 
            this.nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            this.nuevaReservaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevaReservaToolStripMenuItem.Text = "Registrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.reservaToolStripMenuItem});
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.entradasToolStripMenuItem.Text = "Venta";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.reservaToolStripMenuItem.Text = "Consultar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.dgvDetalle);
            this.panelResultado.Controls.Add(this.dgvTarifas);
            this.panelResultado.Location = new System.Drawing.Point(174, 103);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(447, 186);
            this.panelResultado.TabIndex = 2;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCant,
            this.colMonIndi,
            this.colMontoTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(4, 0);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(443, 186);
            this.dgvDetalle.TabIndex = 1;
            this.dgvDetalle.Visible = false;
            // 
            // colCant
            // 
            this.colCant.HeaderText = "Cant. Entradas";
            this.colCant.Name = "colCant";
            // 
            // colMonIndi
            // 
            this.colMonIndi.HeaderText = "Precio Unitario";
            this.colMonIndi.Name = "colMonIndi";
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.HeaderText = "Total";
            this.colMontoTotal.Name = "colMontoTotal";
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonto,
            this.colTipoEntrada,
            this.colTipoVisita,
            this.colMontoAdicional,
            this.colId,
            this.colFecInicio,
            this.colFecFin});
            this.dgvTarifas.Location = new System.Drawing.Point(0, 0);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.Size = new System.Drawing.Size(445, 186);
            this.dgvTarifas.TabIndex = 0;
            this.dgvTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifas_CellClick);
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            // 
            // colTipoEntrada
            // 
            this.colTipoEntrada.HeaderText = "Tipo Entrada";
            this.colTipoEntrada.Name = "colTipoEntrada";
            // 
            // colTipoVisita
            // 
            this.colTipoVisita.HeaderText = "Tipo Visita";
            this.colTipoVisita.Name = "colTipoVisita";
            // 
            // colMontoAdicional
            // 
            this.colMontoAdicional.HeaderText = "Monto Adicional";
            this.colMontoAdicional.Name = "colMontoAdicional";
            // 
            // colId
            // 
            this.colId.HeaderText = "IdTarifa";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colFecInicio
            // 
            this.colFecInicio.HeaderText = "Fecha Inicio Vigencia";
            this.colFecInicio.Name = "colFecInicio";
            this.colFecInicio.Visible = false;
            // 
            // colFecFin
            // 
            this.colFecFin.HeaderText = "Fecha Fin Vigencia";
            this.colFecFin.Name = "colFecFin";
            this.colFecFin.Visible = false;
            // 
            // txtDuracionExposicion
            // 
            this.txtDuracionExposicion.Location = new System.Drawing.Point(262, 27);
            this.txtDuracionExposicion.Name = "txtDuracionExposicion";
            this.txtDuracionExposicion.Size = new System.Drawing.Size(232, 20);
            this.txtDuracionExposicion.TabIndex = 3;
            this.txtDuracionExposicion.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(720, 107);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Visible = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cant. Entradas";
            this.label1.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(712, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDuracionExposicion);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.TextBox txtDuracionExposicion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonIndi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoAdicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecFin;
    }
}

