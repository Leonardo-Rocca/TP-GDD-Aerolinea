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
            this.groupBox2.SuspendLayout();
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
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 435);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ListadoRol";
            this.Text = "ListadoRol";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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

    }
}