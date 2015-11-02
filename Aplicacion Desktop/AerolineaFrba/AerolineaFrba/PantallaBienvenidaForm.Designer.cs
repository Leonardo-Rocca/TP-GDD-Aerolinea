namespace AerolineaFrba
{
    partial class PantallaBienvenidaForm
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
            this.lbAerolinea = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lbseleccion = new System.Windows.Forms.Label();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAerolinea
            // 
            this.lbAerolinea.AutoSize = true;
            this.lbAerolinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAerolinea.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAerolinea.ForeColor = System.Drawing.Color.Red;
            this.lbAerolinea.Location = new System.Drawing.Point(124, 24);
            this.lbAerolinea.Name = "lbAerolinea";
            this.lbAerolinea.Size = new System.Drawing.Size(258, 35);
            this.lbAerolinea.TabIndex = 1;
            this.lbAerolinea.Text = "AEROLINEA FRBA";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(61, 138);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(406, 28);
            this.cmbRoles.TabIndex = 8;
            // 
            // lbseleccion
            // 
            this.lbseleccion.AutoSize = true;
            this.lbseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbseleccion.Location = new System.Drawing.Point(97, 104);
            this.lbseleccion.Name = "lbseleccion";
            this.lbseleccion.Size = new System.Drawing.Size(325, 18);
            this.lbseleccion.TabIndex = 7;
            this.lbseleccion.Text = "Seleccione la forma en que desea iniciar sesión:";
            // 
            // btIngresar
            // 
            this.btIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(340, 213);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(103, 56);
            this.btIngresar.TabIndex = 6;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(77, 213);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(103, 56);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // PantallaBienvenidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(532, 290);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lbseleccion);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.lbAerolinea);
            this.Name = "PantallaBienvenidaForm";
            this.Text = "PantallaBienvenidaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAerolinea;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lbseleccion;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btSalir;
    }
}