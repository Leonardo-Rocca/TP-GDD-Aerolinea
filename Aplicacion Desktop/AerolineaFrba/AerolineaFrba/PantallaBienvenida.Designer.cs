namespace AerolineaFrba
{
    partial class PantallaBienvenida
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
            this.btAdministrador = new System.Windows.Forms.Button();
            this.butCliente = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbAerolinea
            // 
            this.lbAerolinea.AutoSize = true;
            this.lbAerolinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAerolinea.Location = new System.Drawing.Point(153, 23);
            this.lbAerolinea.Name = "lbAerolinea";
            this.lbAerolinea.Size = new System.Drawing.Size(252, 33);
            this.lbAerolinea.TabIndex = 0;
            this.lbAerolinea.Text = "AEROLINEA FRBA";
            // 
            // btAdministrador
            // 
            this.btAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdministrador.Location = new System.Drawing.Point(355, 203);
            this.btAdministrador.Name = "btAdministrador";
            this.btAdministrador.Size = new System.Drawing.Size(103, 56);
            this.btAdministrador.TabIndex = 1;
            this.btAdministrador.Text = "Administrador";
            this.btAdministrador.UseVisualStyleBackColor = true;
            this.btAdministrador.Click += new System.EventHandler(this.btAdministrador_Click);
            // 
            // butCliente
            // 
            this.butCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCliente.Location = new System.Drawing.Point(94, 203);
            this.butCliente.Name = "butCliente";
            this.butCliente.Size = new System.Drawing.Size(103, 56);
            this.butCliente.TabIndex = 2;
            this.butCliente.Text = "Cliente";
            this.butCliente.UseVisualStyleBackColor = true;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Location = new System.Drawing.Point(85, 170);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSeleccion.Size = new System.Drawing.Size(385, 102);
            this.gbSeleccion.TabIndex = 3;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Seleccione la forma en que desea iniciar sesión";
            // 
            // PantallaBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(538, 306);
            this.Controls.Add(this.butCliente);
            this.Controls.Add(this.btAdministrador);
            this.Controls.Add(this.lbAerolinea);
            this.Controls.Add(this.gbSeleccion);
            this.Name = "PantallaBienvenida";
            this.Text = "PantallaBienvenida";
            this.Load += new System.EventHandler(this.PantallaBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAerolinea;
        private System.Windows.Forms.Button btAdministrador;
        private System.Windows.Forms.Button butCliente;
        private System.Windows.Forms.GroupBox gbSeleccion;
    }
}