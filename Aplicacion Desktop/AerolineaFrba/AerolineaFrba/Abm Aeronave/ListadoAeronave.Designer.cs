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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblErrores = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.checkInhabilitado = new System.Windows.Forms.CheckBox();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.textFabricante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 215);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 21);
            this.button3.TabIndex = 28;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 21);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox1.Controls.Add(this.checkInhabilitado);
            this.groupBox1.Controls.Add(this.checkHabilitado);
            this.groupBox1.Controls.Add(this.textFabricante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 135);
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
            // checkInhabilitado
            // 
            this.checkInhabilitado.AutoSize = true;
            this.checkInhabilitado.Location = new System.Drawing.Point(378, 104);
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
            this.checkHabilitado.Location = new System.Drawing.Point(378, 68);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkHabilitado.TabIndex = 42;
            this.checkHabilitado.Text = "Habilitada";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            this.checkHabilitado.CheckedChanged += new System.EventHandler(this.checkHabilitado_CheckedChanged);
            // 
            // textFabricante
            // 
            this.textFabricante.Location = new System.Drawing.Point(121, 101);
            this.textFabricante.Name = "textFabricante";
            this.textFabricante.Size = new System.Drawing.Size(183, 20);
            this.textFabricante.TabIndex = 28;
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
            // ListadoAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoAeronave";
            this.Text = "ListadoAeronave";
            this.Load += new System.EventHandler(this.ListadoAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textFabricante;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkInhabilitado;
        private System.Windows.Forms.CheckBox checkHabilitado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxServicio;
    }
}