namespace AerolineaFrba.Abm_Rol
{
    partial class ListadoRol
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButInhabilitado = new System.Windows.Forms.RadioButton();
            this.radioButHabilitado = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxFiltro2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltro1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(392, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Ninguno";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButInhabilitado);
            this.groupBox2.Controls.Add(this.radioButHabilitado);
            this.groupBox2.Location = new System.Drawing.Point(385, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 84);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por estado";
            // 
            // radioButInhabilitado
            // 
            this.radioButInhabilitado.AutoSize = true;
            this.radioButInhabilitado.Location = new System.Drawing.Point(6, 52);
            this.radioButInhabilitado.Name = "radioButInhabilitado";
            this.radioButInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.radioButInhabilitado.TabIndex = 14;
            this.radioButInhabilitado.TabStop = true;
            this.radioButInhabilitado.Text = "Inhabilitado";
            this.radioButInhabilitado.UseVisualStyleBackColor = true;
            this.radioButInhabilitado.CheckedChanged += new System.EventHandler(this.radioButInhabilitado_CheckedChanged);
            // 
            // radioButHabilitado
            // 
            this.radioButHabilitado.AutoSize = true;
            this.radioButHabilitado.Location = new System.Drawing.Point(6, 29);
            this.radioButHabilitado.Name = "radioButHabilitado";
            this.radioButHabilitado.Size = new System.Drawing.Size(72, 17);
            this.radioButHabilitado.TabIndex = 13;
            this.radioButHabilitado.TabStop = true;
            this.radioButHabilitado.Text = "Habilitado";
            this.radioButHabilitado.UseVisualStyleBackColor = true;
            this.radioButHabilitado.CheckedChanged += new System.EventHandler(this.optEstadoAlta_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 21);
            this.button3.TabIndex = 26;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 21);
            this.button2.TabIndex = 25;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxFiltro2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxFiltro1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 176);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros de Busqueda";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // textBoxFiltro2
            // 
            this.textBoxFiltro2.Location = new System.Drawing.Point(166, 52);
            this.textBoxFiltro2.Name = "textBoxFiltro2";
            this.textBoxFiltro2.Size = new System.Drawing.Size(136, 20);
            this.textBoxFiltro2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Que en su nombre contenga";
            // 
            // textBoxFiltro1
            // 
            this.textBoxFiltro1.Location = new System.Drawing.Point(166, 24);
            this.textBoxFiltro1.Name = "textBoxFiltro1";
            this.textBoxFiltro1.Size = new System.Drawing.Size(136, 20);
            this.textBoxFiltro1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Por igualdad de palabra";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(574, 247);
            this.dataGridView2.TabIndex = 28;
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 435);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ListadoRol";
            this.Text = "ListadoRol";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButInhabilitado;
        private System.Windows.Forms.RadioButton radioButHabilitado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxFiltro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltro1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;

    }
}