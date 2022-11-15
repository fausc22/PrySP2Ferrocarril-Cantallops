namespace PrySP2Ferrocarril_Cantallops
{
    partial class frmFerrocarril
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
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(196, 94);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(77, 20);
            this.txtDistancia.TabIndex = 10;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(29, 144);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(149, 24);
            this.lblDias.TabIndex = 9;
            this.lblDias.Text = "Dias de Estancia";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(30, 90);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(130, 24);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Distancia (KM)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Ferro S.A";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(98, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 46);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Precio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(196, 144);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(77, 20);
            this.txtDias.TabIndex = 11;
            // 
            // frmFerrocarril
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 298);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmFerrocarril";
            this.Text = "Precio de Boletos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDias;
    }
}

