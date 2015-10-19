namespace AerolineaFrba.FormsPrincipales
{
    partial class Redireccionador
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
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.btSeleccion = new System.Windows.Forms.Button();
            this.lbSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(244, 109);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(301, 26);
            this.cmbFuncionalidades.TabIndex = 0;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(64, 273);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(118, 53);
            this.botonVolver.TabIndex = 17;
            this.botonVolver.Text = "<< Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // btSeleccion
            // 
            this.btSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccion.Location = new System.Drawing.Point(421, 273);
            this.btSeleccion.Name = "btSeleccion";
            this.btSeleccion.Size = new System.Drawing.Size(124, 53);
            this.btSeleccion.TabIndex = 18;
            this.btSeleccion.Text = "Seleccionar Funcinalidad";
            this.btSeleccion.UseVisualStyleBackColor = true;
            this.btSeleccion.Click += new System.EventHandler(this.btSeleccion_Click);
            // 
            // lbSeleccione
            // 
            this.lbSeleccione.AutoSize = true;
            this.lbSeleccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccione.Location = new System.Drawing.Point(30, 109);
            this.lbSeleccione.Name = "lbSeleccione";
            this.lbSeleccione.Size = new System.Drawing.Size(194, 20);
            this.lbSeleccione.TabIndex = 19;
            this.lbSeleccione.Text = "Seleccione Funcionalidad:";
            // 
            // Redireccionador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.lbSeleccione);
            this.Controls.Add(this.btSeleccion);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Name = "Redireccionador";
            this.Text = "Redireccionador";
            this.Load += new System.EventHandler(this.Redireccionador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button btSeleccion;
        private System.Windows.Forms.Label lbSeleccione;

    }
}