namespace AerolineaFrba.Abm_Aeronave
{
    partial class ListadoAeronave
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
            this.lblErrores = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDesdekg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textFechaHasta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textFechaDesde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkInhabilitado = new System.Windows.Forms.CheckBox();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.textBoxHastakg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkEncomienda = new System.Windows.Forms.CheckBox();
            this.checkPasaje = new System.Windows.Forms.CheckBox();
            this.textButacas = new System.Windows.Forms.TextBox();
            this.textFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(632, 144);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 13);
            this.lblErrores.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxServicio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxDesdekg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textFechaHasta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textFechaDesde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkInhabilitado);
            this.groupBox1.Controls.Add(this.checkHabilitado);
            this.groupBox1.Controls.Add(this.textBoxHastakg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkEncomienda);
            this.groupBox1.Controls.Add(this.checkPasaje);
            this.groupBox1.Controls.Add(this.textButacas);
            this.groupBox1.Controls.Add(this.textFabricante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Location = new System.Drawing.Point(408, 30);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(239, 21);
            this.comboBoxServicio.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Hasta";
            this.label10.Visible = false;
            // 
            // textBoxDesdekg
            // 
            this.textBoxDesdekg.Location = new System.Drawing.Point(222, 205);
            this.textBoxDesdekg.Name = "textBoxDesdekg";
            this.textBoxDesdekg.Size = new System.Drawing.Size(81, 20);
            this.textBoxDesdekg.TabIndex = 50;
            this.textBoxDesdekg.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Desde";
            this.label9.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(539, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 21);
            this.button5.TabIndex = 46;
            this.button5.Text = "Seleccionar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textFechaHasta
            // 
            this.textFechaHasta.Location = new System.Drawing.Point(367, 135);
            this.textFechaHasta.Name = "textFechaHasta";
            this.textFechaHasta.Size = new System.Drawing.Size(166, 20);
            this.textFechaHasta.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Hasta";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 21);
            this.button4.TabIndex = 43;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textFechaDesde
            // 
            this.textFechaDesde.Location = new System.Drawing.Point(367, 101);
            this.textFechaDesde.Name = "textFechaDesde";
            this.textFechaDesde.Size = new System.Drawing.Size(166, 20);
            this.textFechaDesde.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Desde";
            // 
            // checkInhabilitado
            // 
            this.checkInhabilitado.AutoSize = true;
            this.checkInhabilitado.Location = new System.Drawing.Point(471, 70);
            this.checkInhabilitado.Name = "checkInhabilitado";
            this.checkInhabilitado.Size = new System.Drawing.Size(80, 17);
            this.checkInhabilitado.TabIndex = 43;
            this.checkInhabilitado.Text = "Inhabilitada";
            this.checkInhabilitado.UseVisualStyleBackColor = true;
            this.checkInhabilitado.CheckedChanged += new System.EventHandler(this.checkInhabilitado_CheckedChanged);
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Location = new System.Drawing.Point(327, 70);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkHabilitado.TabIndex = 42;
            this.checkHabilitado.Text = "Habilitada";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            this.checkHabilitado.CheckedChanged += new System.EventHandler(this.checkHabilitado_CheckedChanged);
            // 
            // textBoxHastakg
            // 
            this.textBoxHastakg.Location = new System.Drawing.Point(367, 205);
            this.textBoxHastakg.Name = "textBoxHastakg";
            this.textBoxHastakg.Size = new System.Drawing.Size(79, 20);
            this.textBoxHastakg.TabIndex = 41;
            this.textBoxHastakg.Visible = false;
            this.textBoxHastakg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kg encomienda";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkEncomienda
            // 
            this.checkEncomienda.AutoSize = true;
            this.checkEncomienda.Location = new System.Drawing.Point(20, 208);
            this.checkEncomienda.Name = "checkEncomienda";
            this.checkEncomienda.Size = new System.Drawing.Size(85, 17);
            this.checkEncomienda.TabIndex = 39;
            this.checkEncomienda.Text = "Encomienda";
            this.checkEncomienda.UseVisualStyleBackColor = true;
            this.checkEncomienda.CheckedChanged += new System.EventHandler(this.checkEncomienda_CheckedChanged);
            // 
            // checkPasaje
            // 
            this.checkPasaje.AutoSize = true;
            this.checkPasaje.Location = new System.Drawing.Point(20, 172);
            this.checkPasaje.Name = "checkPasaje";
            this.checkPasaje.Size = new System.Drawing.Size(58, 17);
            this.checkPasaje.TabIndex = 38;
            this.checkPasaje.Text = "Pasaje";
            this.checkPasaje.UseVisualStyleBackColor = true;
            this.checkPasaje.CheckedChanged += new System.EventHandler(this.checkPasaje_CheckedChanged);
            // 
            // textButacas
            // 
            this.textButacas.Location = new System.Drawing.Point(121, 134);
            this.textButacas.Name = "textButacas";
            this.textButacas.Size = new System.Drawing.Size(183, 20);
            this.textButacas.TabIndex = 29;
            // 
            // textFabricante
            // 
            this.textFabricante.Location = new System.Drawing.Point(121, 101);
            this.textFabricante.Name = "textFabricante";
            this.textFabricante.Size = new System.Drawing.Size(183, 20);
            this.textFabricante.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cantidad butacas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre Fabricante";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(121, 32);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(183, 20);
            this.txtMatricula.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(121, 65);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(183, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo aeronave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula aeronave";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 21);
            this.button3.TabIndex = 28;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 21);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo de Servicio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 290);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 215);
            this.dataGridView1.TabIndex = 43;
            // 
            // ListadoAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoAeronave";
            this.Text = "ListadoAeronave";
            this.Load += new System.EventHandler(this.ListadoAeronave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textButacas;
        private System.Windows.Forms.TextBox textFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textFechaHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textFechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkInhabilitado;
        private System.Windows.Forms.CheckBox checkHabilitado;
        private System.Windows.Forms.TextBox textBoxHastakg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkEncomienda;
        private System.Windows.Forms.CheckBox checkPasaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDesdekg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxServicio;
    }
}