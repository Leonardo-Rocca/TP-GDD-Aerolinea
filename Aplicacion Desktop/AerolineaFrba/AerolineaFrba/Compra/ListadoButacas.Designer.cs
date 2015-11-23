namespace AerolineaFrba.Compra
{
    partial class ListadoButacas
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
            this.dgvbutaca = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPasillo = new System.Windows.Forms.CheckBox();
            this.chkVentanilla = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbutaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbutaca
            // 
            this.dgvbutaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbutaca.Location = new System.Drawing.Point(37, 254);
            this.dgvbutaca.Name = "dgvbutaca";
            this.dgvbutaca.Size = new System.Drawing.Size(441, 163);
            this.dgvbutaca.TabIndex = 42;
            this.dgvbutaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbutaca_CellContentClick);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(158, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(207, 25);
            this.lbTitulo.TabIndex = 43;
            this.lbTitulo.Text = "Seleccion de butaca";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(69, 161);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(86, 37);
            this.btCancelar.TabIndex = 44;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(350, 161);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(90, 37);
            this.btBuscar.TabIndex = 45;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(331, 66);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(58, 20);
            this.lbOrigen.TabIndex = 48;
            this.lbOrigen.Text = "Pasillo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ventanilla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Butacas disponibles:";
            // 
            // chkPasillo
            // 
            this.chkPasillo.AutoSize = true;
            this.chkPasillo.Location = new System.Drawing.Point(443, 66);
            this.chkPasillo.Name = "chkPasillo";
            this.chkPasillo.Size = new System.Drawing.Size(15, 14);
            this.chkPasillo.TabIndex = 51;
            this.chkPasillo.UseVisualStyleBackColor = true;
            // 
            // chkVentanilla
            // 
            this.chkVentanilla.AutoSize = true;
            this.chkVentanilla.Location = new System.Drawing.Point(443, 107);
            this.chkVentanilla.Name = "chkVentanilla";
            this.chkVentanilla.Size = new System.Drawing.Size(15, 14);
            this.chkVentanilla.TabIndex = 52;
            this.chkVentanilla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Piso:";
            // 
            // txtPiso
            // 
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.Location = new System.Drawing.Point(144, 95);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 26);
            this.txtPiso.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Filtros:";
            // 
            // ListadoButacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkVentanilla);
            this.Controls.Add(this.chkPasillo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgvbutaca);
            this.Name = "ListadoButacas";
            this.Text = "ListadoButacas";
            this.Load += new System.EventHandler(this.ListadoButacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbutaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbutaca;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPasillo;
        private System.Windows.Forms.CheckBox chkVentanilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label4;
    }
}