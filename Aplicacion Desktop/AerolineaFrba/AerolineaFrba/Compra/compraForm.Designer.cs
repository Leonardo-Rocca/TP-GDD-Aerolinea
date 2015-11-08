namespace AerolineaFrba.Compra
{
    partial class compraForm
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPasaje = new System.Windows.Forms.Button();
            this.btEncomienda = new System.Windows.Forms.Button();
            this.cmbPasaje = new System.Windows.Forms.ComboBox();
            this.lbNombreOrigen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncomienda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(118, 61);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(314, 25);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "Compra de Pasaje/Encomienda";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(394, 367);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 49);
            this.buttonGuardar.TabIndex = 16;
            this.buttonGuardar.Text = "Comprar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(85, 367);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 49);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btPasaje
            // 
            this.btPasaje.BackColor = System.Drawing.Color.Turquoise;
            this.btPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPasaje.Location = new System.Drawing.Point(385, 134);
            this.btPasaje.Name = "btPasaje";
            this.btPasaje.Size = new System.Drawing.Size(106, 49);
            this.btPasaje.TabIndex = 17;
            this.btPasaje.Text = "Agregar Pasaje";
            this.btPasaje.UseVisualStyleBackColor = false;
            this.btPasaje.Click += new System.EventHandler(this.btPasaje_Click);
            // 
            // btEncomienda
            // 
            this.btEncomienda.BackColor = System.Drawing.Color.Turquoise;
            this.btEncomienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncomienda.Location = new System.Drawing.Point(385, 228);
            this.btEncomienda.Name = "btEncomienda";
            this.btEncomienda.Size = new System.Drawing.Size(106, 49);
            this.btEncomienda.TabIndex = 18;
            this.btEncomienda.Text = "Agregar Encomienda";
            this.btEncomienda.UseVisualStyleBackColor = false;
            this.btEncomienda.Click += new System.EventHandler(this.btEncomienda_Click);
            // 
            // cmbPasaje
            // 
            this.cmbPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPasaje.Location = new System.Drawing.Point(120, 145);
            this.cmbPasaje.Name = "cmbPasaje";
            this.cmbPasaje.Size = new System.Drawing.Size(232, 28);
            this.cmbPasaje.TabIndex = 19;
            this.cmbPasaje.SelectedIndexChanged += new System.EventHandler(this.cmbPasaje_SelectedIndexChanged);
            // 
            // lbNombreOrigen
            // 
            this.lbNombreOrigen.AutoSize = true;
            this.lbNombreOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreOrigen.Location = new System.Drawing.Point(119, 122);
            this.lbNombreOrigen.Name = "lbNombreOrigen";
            this.lbNombreOrigen.Size = new System.Drawing.Size(69, 20);
            this.lbNombreOrigen.TabIndex = 57;
            this.lbNombreOrigen.Text = "Pasajes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "KGs a enviar via Encomiendas:";
            // 
            // txtEncomienda
            // 
            this.txtEncomienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncomienda.Location = new System.Drawing.Point(120, 239);
            this.txtEncomienda.Name = "txtEncomienda";
            this.txtEncomienda.ReadOnly = true;
            this.txtEncomienda.Size = new System.Drawing.Size(232, 26);
            this.txtEncomienda.TabIndex = 59;
            this.txtEncomienda.TextChanged += new System.EventHandler(this.txtEncomienda_TextChanged);
            // 
            // compraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 442);
            this.Controls.Add(this.txtEncomienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreOrigen);
            this.Controls.Add(this.cmbPasaje);
            this.Controls.Add(this.btEncomienda);
            this.Controls.Add(this.btPasaje);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbTitulo);
            this.Name = "compraForm";
            this.Text = "compraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btPasaje;
        private System.Windows.Forms.Button btEncomienda;
        private System.Windows.Forms.ComboBox cmbPasaje;
        private System.Windows.Forms.Label lbNombreOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncomienda;
    }
}