
namespace Museo.Interfaz
{
    partial class Impresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresora));
            this.lblNumEntrada1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumEntrada2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumEntrada1
            // 
            this.lblNumEntrada1.AutoSize = true;
            this.lblNumEntrada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEntrada1.Location = new System.Drawing.Point(82, 63);
            this.lblNumEntrada1.Name = "lblNumEntrada1";
            this.lblNumEntrada1.Size = new System.Drawing.Size(55, 39);
            this.lblNumEntrada1.TabIndex = 3;
            this.lblNumEntrada1.Text = "18";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(177, 63);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(36, 39);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "$";
            // 
            // lblNumEntrada2
            // 
            this.lblNumEntrada2.AutoSize = true;
            this.lblNumEntrada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEntrada2.Location = new System.Drawing.Point(327, 63);
            this.lblNumEntrada2.Name = "lblNumEntrada2";
            this.lblNumEntrada2.Size = new System.Drawing.Size(55, 39);
            this.lblNumEntrada2.TabIndex = 5;
            this.lblNumEntrada2.Text = "18";
            // 
            // Impresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 165);
            this.Controls.Add(this.lblNumEntrada2);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNumEntrada1);
            this.Name = "Impresora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumEntrada1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumEntrada2;
    }
}