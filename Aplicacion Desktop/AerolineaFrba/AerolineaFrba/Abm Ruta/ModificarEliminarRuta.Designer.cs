namespace AerolineaFrba.Abm_Ruta
{
    partial class ModificarEliminarRuta
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
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSeleccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCDestino = new System.Windows.Forms.TextBox();
            this.lbDestino = new System.Windows.Forms.Label();
            this.txtCOrigen = new System.Windows.Forms.TextBox();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.btsDestino = new System.Windows.Forms.Button();
            this.btsOringen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrecioKG = new System.Windows.Forms.Label();
            this.lbEntre = new System.Windows.Forms.Label();
            this.txtPKGLimInferior = new System.Windows.Forms.TextBox();
            this.txtPKGSuperior = new System.Windows.Forms.TextBox();
            this.lby = new System.Windows.Forms.Label();
            this.txtPasajeSuperior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasajeLimInferior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkListaServicios = new System.Windows.Forms.CheckedListBox();
            this.lbService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(909, 579);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(138, 50);
            this.butAceptar.TabIndex = 42;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(71, 579);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(138, 50);
            this.butCancelar.TabIndex = 41;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(557, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(406, 223);
            this.dataGridView2.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 50);
            this.button3.TabIndex = 38;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 50);
            this.button2.TabIndex = 37;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(483, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(63, 25);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = " Ruta";
            // 
            // lbSeleccion
            // 
            this.lbSeleccion.AutoSize = true;
            this.lbSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccion.Location = new System.Drawing.Point(47, 53);
            this.lbSeleccion.Name = "lbSeleccion";
            this.lbSeleccion.Size = new System.Drawing.Size(192, 24);
            this.lbSeleccion.TabIndex = 44;
            this.lbSeleccion.Text = " Seleccione la Ruta a ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(224, 97);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 46;
            // 
            // txtCDestino
            // 
            this.txtCDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDestino.Location = new System.Drawing.Point(224, 200);
            this.txtCDestino.Name = "txtCDestino";
            this.txtCDestino.ReadOnly = true;
            this.txtCDestino.Size = new System.Drawing.Size(180, 26);
            this.txtCDestino.TabIndex = 50;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.Location = new System.Drawing.Point(30, 203);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(118, 20);
            this.lbDestino.TabIndex = 49;
            this.lbDestino.Text = "Ciudad Destino";
            // 
            // txtCOrigen
            // 
            this.txtCOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOrigen.Location = new System.Drawing.Point(224, 135);
            this.txtCOrigen.Name = "txtCOrigen";
            this.txtCOrigen.ReadOnly = true;
            this.txtCOrigen.Size = new System.Drawing.Size(180, 26);
            this.txtCOrigen.TabIndex = 48;
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(30, 138);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(110, 20);
            this.lbOrigen.TabIndex = 47;
            this.lbOrigen.Text = "Ciudad Origen";
            // 
            // btsDestino
            // 
            this.btsDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsDestino.Location = new System.Drawing.Point(438, 197);
            this.btsDestino.Name = "btsDestino";
            this.btsDestino.Size = new System.Drawing.Size(108, 29);
            this.btsDestino.TabIndex = 52;
            this.btsDestino.Text = "Seleccionar";
            this.btsDestino.UseVisualStyleBackColor = true;
            // 
            // btsOringen
            // 
            this.btsOringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsOringen.Location = new System.Drawing.Point(438, 132);
            this.btsOringen.Name = "btsOringen";
            this.btsOringen.Size = new System.Drawing.Size(108, 29);
            this.btsOringen.TabIndex = 51;
            this.btsOringen.Text = "Seleccionar";
            this.btsOringen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Precio Base por Pasaje";
            // 
            // lbPrecioKG
            // 
            this.lbPrecioKG.AutoSize = true;
            this.lbPrecioKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioKG.Location = new System.Drawing.Point(585, 95);
            this.lbPrecioKG.Name = "lbPrecioKG";
            this.lbPrecioKG.Size = new System.Drawing.Size(148, 20);
            this.lbPrecioKG.TabIndex = 53;
            this.lbPrecioKG.Text = "Precio Base por KG";
            // 
            // lbEntre
            // 
            this.lbEntre.AutoSize = true;
            this.lbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntre.Location = new System.Drawing.Point(600, 135);
            this.lbEntre.Name = "lbEntre";
            this.lbEntre.Size = new System.Drawing.Size(45, 18);
            this.lbEntre.TabIndex = 57;
            this.lbEntre.Text = "entre:";
            // 
            // txtPKGLimInferior
            // 
            this.txtPKGLimInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPKGLimInferior.Location = new System.Drawing.Point(651, 133);
            this.txtPKGLimInferior.Name = "txtPKGLimInferior";
            this.txtPKGLimInferior.Size = new System.Drawing.Size(107, 26);
            this.txtPKGLimInferior.TabIndex = 58;
            // 
            // txtPKGSuperior
            // 
            this.txtPKGSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPKGSuperior.Location = new System.Drawing.Point(835, 135);
            this.txtPKGSuperior.Name = "txtPKGSuperior";
            this.txtPKGSuperior.Size = new System.Drawing.Size(107, 26);
            this.txtPKGSuperior.TabIndex = 60;
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lby.Location = new System.Drawing.Point(806, 138);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(23, 18);
            this.lby.TabIndex = 59;
            this.lby.Text = "y :";
            // 
            // txtPasajeSuperior
            // 
            this.txtPasajeSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasajeSuperior.Location = new System.Drawing.Point(835, 236);
            this.txtPasajeSuperior.Name = "txtPasajeSuperior";
            this.txtPasajeSuperior.Size = new System.Drawing.Size(107, 26);
            this.txtPasajeSuperior.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "y :";
            // 
            // txtPasajeLimInferior
            // 
            this.txtPasajeLimInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasajeLimInferior.Location = new System.Drawing.Point(651, 234);
            this.txtPasajeLimInferior.Name = "txtPasajeLimInferior";
            this.txtPasajeLimInferior.Size = new System.Drawing.Size(107, 26);
            this.txtPasajeLimInferior.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "entre:";
            // 
            // chkListaServicios
            // 
            this.chkListaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListaServicios.FormattingEnabled = true;
            this.chkListaServicios.Location = new System.Drawing.Point(224, 252);
            this.chkListaServicios.Name = "chkListaServicios";
            this.chkListaServicios.Size = new System.Drawing.Size(199, 99);
            this.chkListaServicios.TabIndex = 66;
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.Location = new System.Drawing.Point(30, 259);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(120, 20);
            this.lbService.TabIndex = 65;
            this.lbService.Text = "Tipo de Servicio";
            // 
            // ModificarEliminarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 654);
            this.Controls.Add(this.chkListaServicios);
            this.Controls.Add(this.lbService);
            this.Controls.Add(this.txtPasajeSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasajeLimInferior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPKGSuperior);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.txtPKGLimInferior);
            this.Controls.Add(this.lbEntre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrecioKG);
            this.Controls.Add(this.btsDestino);
            this.Controls.Add(this.btsOringen);
            this.Controls.Add(this.txtCDestino);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.txtCOrigen);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbSeleccion);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "ModificarEliminarRuta";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCDestino;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.TextBox txtCOrigen;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Button btsDestino;
        private System.Windows.Forms.Button btsOringen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrecioKG;
        private System.Windows.Forms.Label lbEntre;
        private System.Windows.Forms.TextBox txtPKGLimInferior;
        private System.Windows.Forms.TextBox txtPKGSuperior;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.TextBox txtPasajeSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasajeLimInferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chkListaServicios;
        private System.Windows.Forms.Label lbService;
    }
}