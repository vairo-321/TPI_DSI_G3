
namespace Museo.Interfaz
{
    partial class PantallaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCantActual = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCantActual
            // 
            this.lblCantActual.AutoSize = true;
            this.lblCantActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantActual.Location = new System.Drawing.Point(12, 19);
            this.lblCantActual.Name = "lblCantActual";
            this.lblCantActual.Size = new System.Drawing.Size(124, 42);
            this.lblCantActual.TabIndex = 0;
            this.lblCantActual.Text = "label1";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.Red;
            this.lblCapacidad.Location = new System.Drawing.Point(12, 94);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(124, 42);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "label1";
            // 
            // PantallaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 162);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblCantActual);
            this.Name = "PantallaEntrada";
            this.Text = "PantallaEntrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantActual;
        private System.Windows.Forms.Label lblCapacidad;
    }
}