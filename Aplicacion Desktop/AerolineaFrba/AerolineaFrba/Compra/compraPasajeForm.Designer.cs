namespace AerolineaFrba.Compra
{
    partial class compraPasajeForm
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtCityOrigen = new System.Windows.Forms.TextBox();
            this.lbNombreOrigen = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btsDestino = new System.Windows.Forms.Button();
            this.btsOringen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(440, 369);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(130, 58);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "seleccionar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(86, 369);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 58);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtCityOrigen
            // 
            this.txtCityOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityOrigen.Location = new System.Drawing.Point(189, 94);
            this.txtCityOrigen.Name = "txtCityOrigen";
            this.txtCityOrigen.Size = new System.Drawing.Size(306, 26);
            this.txtCityOrigen.TabIndex = 11;
            // 
            // lbNombreOrigen
            // 
            this.lbNombreOrigen.AutoSize = true;
            this.lbNombreOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreOrigen.Location = new System.Drawing.Point(38, 97);
            this.lbNombreOrigen.Name = "lbNombreOrigen";
            this.lbNombreOrigen.Size = new System.Drawing.Size(114, 20);
            this.lbNombreOrigen.TabIndex = 10;
            this.lbNombreOrigen.Text = "Ciudad Origen:";
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(189, 139);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(306, 26);
            this.txtDestino.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ciudad Destino:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(216, 24);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(187, 25);
            this.lbTitulo.TabIndex = 19;
            this.lbTitulo.Text = "Seleccion de viaje";
            // 
            // btsDestino
            // 
            this.btsDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsDestino.Location = new System.Drawing.Point(516, 139);
            this.btsDestino.Name = "btsDestino";
            this.btsDestino.Size = new System.Drawing.Size(124, 29);
            this.btsDestino.TabIndex = 21;
            this.btsDestino.Text = "Seleccionar";
            this.btsDestino.UseVisualStyleBackColor = true;
            this.btsDestino.Click += new System.EventHandler(this.btsDestino_Click);
            // 
            // btsOringen
            // 
            this.btsOringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsOringen.Location = new System.Drawing.Point(516, 88);
            this.btsOringen.Name = "btsOringen";
            this.btsOringen.Size = new System.Drawing.Size(124, 29);
            this.btsOringen.TabIndex = 20;
            this.btsOringen.Text = "Seleccionar";
            this.btsOringen.UseVisualStyleBackColor = true;
            this.btsOringen.Click += new System.EventHandler(this.btsOringen_Click);
            // 
            // compraPasajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 456);
            this.Controls.Add(this.btsDestino);
            this.Controls.Add(this.btsOringen);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtCityOrigen);
            this.Controls.Add(this.lbNombreOrigen);
            this.Name = "compraPasajeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtCityOrigen;
        private System.Windows.Forms.Label lbNombreOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btsDestino;
        private System.Windows.Forms.Button btsOringen;
    }
}