namespace AerolineaFrba.Abm_Aeronave
{
    partial class MotivoDeBaja
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
            this.checkBoxFueraDeServicio = new System.Windows.Forms.CheckBox();
            this.checkBoxBajaDefinitiva = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFechaDeReinsercion = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFueraDeServicio
            // 
            this.checkBoxFueraDeServicio.AutoSize = true;
            this.checkBoxFueraDeServicio.Location = new System.Drawing.Point(19, 35);
            this.checkBoxFueraDeServicio.Name = "checkBoxFueraDeServicio";
            this.checkBoxFueraDeServicio.Size = new System.Drawing.Size(107, 17);
            this.checkBoxFueraDeServicio.TabIndex = 0;
            this.checkBoxFueraDeServicio.Text = "Fuera de servicio";
            this.checkBoxFueraDeServicio.UseVisualStyleBackColor = true;
            this.checkBoxFueraDeServicio.CheckedChanged += new System.EventHandler(this.checkBoxFueraDeServicio_CheckedChanged);
            // 
            // checkBoxBajaDefinitiva
            // 
            this.checkBoxBajaDefinitiva.AutoSize = true;
            this.checkBoxBajaDefinitiva.Location = new System.Drawing.Point(19, 70);
            this.checkBoxBajaDefinitiva.Name = "checkBoxBajaDefinitiva";
            this.checkBoxBajaDefinitiva.Size = new System.Drawing.Size(92, 17);
            this.checkBoxBajaDefinitiva.TabIndex = 1;
            this.checkBoxBajaDefinitiva.Text = "Baja definitiva";
            this.checkBoxBajaDefinitiva.UseVisualStyleBackColor = true;
            this.checkBoxBajaDefinitiva.CheckedChanged += new System.EventHandler(this.checkBoxBajaDefinitiva_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateFecha);
            this.groupBox3.Controls.Add(this.labelFechaDeReinsercion);
            this.groupBox3.Controls.Add(this.checkBoxBajaDefinitiva);
            this.groupBox3.Controls.Add(this.checkBoxFueraDeServicio);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 177);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivo de Baja";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelFechaDeReinsercion
            // 
            this.labelFechaDeReinsercion.AutoSize = true;
            this.labelFechaDeReinsercion.Location = new System.Drawing.Point(151, 36);
            this.labelFechaDeReinsercion.Name = "labelFechaDeReinsercion";
            this.labelFechaDeReinsercion.Size = new System.Drawing.Size(109, 13);
            this.labelFechaDeReinsercion.TabIndex = 36;
            this.labelFechaDeReinsercion.Text = "Fecha de reinsercion:";
            this.labelFechaDeReinsercion.Visible = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(366, 213);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(108, 21);
            this.buttonAceptar.TabIndex = 37;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(30, 213);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 21);
            this.buttonCancelar.TabIndex = 38;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(266, 32);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(196, 20);
            this.dateFecha.TabIndex = 64;
            // 
            // MotivoDeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox3);
            this.Name = "MotivoDeBaja";
            this.Text = "MotivoDeBaja";
            this.Load += new System.EventHandler(this.MotivoDeBaja_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFueraDeServicio;
        private System.Windows.Forms.CheckBox checkBoxBajaDefinitiva;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelFechaDeReinsercion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker dateFecha;
    }
}