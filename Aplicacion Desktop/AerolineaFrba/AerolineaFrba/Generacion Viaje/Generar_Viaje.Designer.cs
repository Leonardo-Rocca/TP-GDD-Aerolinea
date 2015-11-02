namespace AerolineaFrba.Generacion_Viaje
{
    partial class Generar_Viaje
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
            this.seleccionarCodigo = new System.Windows.Forms.Button();
            this.textCodRuta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.seleccionarHasta = new System.Windows.Forms.Button();
            this.textFechaHasta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.seleccionarMatricula = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionarDesde = new System.Windows.Forms.Button();
            this.textFechaDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // seleccionarCodigo
            // 
            this.seleccionarCodigo.Location = new System.Drawing.Point(387, 138);
            this.seleccionarCodigo.Name = "seleccionarCodigo";
            this.seleccionarCodigo.Size = new System.Drawing.Size(108, 21);
            this.seleccionarCodigo.TabIndex = 52;
            this.seleccionarCodigo.Text = "Seleccionar";
            this.seleccionarCodigo.UseVisualStyleBackColor = true;
            // 
            // textCodRuta
            // 
            this.textCodRuta.Location = new System.Drawing.Point(131, 139);
            this.textCodRuta.Name = "textCodRuta";
            this.textCodRuta.Size = new System.Drawing.Size(250, 20);
            this.textCodRuta.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Codigo de ruta";
            // 
            // seleccionarHasta
            // 
            this.seleccionarHasta.Location = new System.Drawing.Point(387, 100);
            this.seleccionarHasta.Name = "seleccionarHasta";
            this.seleccionarHasta.Size = new System.Drawing.Size(108, 21);
            this.seleccionarHasta.TabIndex = 49;
            this.seleccionarHasta.Text = "Seleccionar";
            this.seleccionarHasta.UseVisualStyleBackColor = true;
            this.seleccionarHasta.Click += new System.EventHandler(this.seleccionarHasta_Click);
            // 
            // textFechaHasta
            // 
            this.textFechaHasta.Location = new System.Drawing.Point(131, 101);
            this.textFechaHasta.Name = "textFechaHasta";
            this.textFechaHasta.Size = new System.Drawing.Size(250, 20);
            this.textFechaHasta.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Hasta";
            // 
            // seleccionarMatricula
            // 
            this.seleccionarMatricula.Location = new System.Drawing.Point(387, 22);
            this.seleccionarMatricula.Name = "seleccionarMatricula";
            this.seleccionarMatricula.Size = new System.Drawing.Size(108, 21);
            this.seleccionarMatricula.TabIndex = 55;
            this.seleccionarMatricula.Text = "Seleccionar";
            this.seleccionarMatricula.UseVisualStyleBackColor = true;
            this.seleccionarMatricula.Click += new System.EventHandler(this.seleccionarMatricula_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(131, 23);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(250, 20);
            this.textBoxMatricula.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Matricula Aeronave";
            // 
            // seleccionarDesde
            // 
            this.seleccionarDesde.Location = new System.Drawing.Point(387, 61);
            this.seleccionarDesde.Name = "seleccionarDesde";
            this.seleccionarDesde.Size = new System.Drawing.Size(108, 21);
            this.seleccionarDesde.TabIndex = 58;
            this.seleccionarDesde.Text = "Seleccionar";
            this.seleccionarDesde.UseVisualStyleBackColor = true;
            this.seleccionarDesde.Click += new System.EventHandler(this.seleccionarDesde_Click);
            // 
            // textFechaDesde
            // 
            this.textFechaDesde.Location = new System.Drawing.Point(131, 62);
            this.textFechaDesde.Name = "textFechaDesde";
            this.textFechaDesde.Size = new System.Drawing.Size(250, 20);
            this.textFechaDesde.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Desde";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(25, 214);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(108, 21);
            this.butCancelar.TabIndex = 61;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(387, 214);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(108, 21);
            this.butAceptar.TabIndex = 62;
            this.butAceptar.Text = "Generar Viaje";
            this.butAceptar.UseVisualStyleBackColor = true;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(110, 26);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 63;
            this.calendario.Visible = false;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // Generar_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 259);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.seleccionarDesde);
            this.Controls.Add(this.textFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccionarMatricula);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionarCodigo);
            this.Controls.Add(this.textCodRuta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.seleccionarHasta);
            this.Controls.Add(this.textFechaHasta);
            this.Controls.Add(this.label6);
            this.Name = "Generar_Viaje";
            this.Text = "Generar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seleccionarCodigo;
        private System.Windows.Forms.TextBox textCodRuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button seleccionarHasta;
        private System.Windows.Forms.TextBox textFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seleccionarMatricula;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seleccionarDesde;
        private System.Windows.Forms.TextBox textFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.MonthCalendar calendario;
    }
}