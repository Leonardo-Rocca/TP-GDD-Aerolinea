namespace AerolineaFrba.Consulta_Millas
{
    partial class ConsultarMillasForm
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.btMillas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvmillas = new System.Windows.Forms.DataGridView();
            this.btPuntos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmillas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(47, 337);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(112, 49);
            this.botonVolver.TabIndex = 21;
            this.botonVolver.Text = "<< Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // btMillas
            // 
            this.btMillas.BackColor = System.Drawing.Color.Turquoise;
            this.btMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMillas.Location = new System.Drawing.Point(431, 74);
            this.btMillas.Name = "btMillas";
            this.btMillas.Size = new System.Drawing.Size(134, 39);
            this.btMillas.TabIndex = 19;
            this.btMillas.Text = "Consultar Millas";
            this.btMillas.UseVisualStyleBackColor = false;
            this.btMillas.Click += new System.EventHandler(this.btMillas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Consultade millas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Dni:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(153, 81);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 24);
            this.txtDni.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Consulta de Puntos:";
            // 
            // dgvmillas
            // 
            this.dgvmillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmillas.Location = new System.Drawing.Point(22, 198);
            this.dgvmillas.Name = "dgvmillas";
            this.dgvmillas.Size = new System.Drawing.Size(606, 116);
            this.dgvmillas.TabIndex = 50;
            // 
            // btPuntos
            // 
            this.btPuntos.BackColor = System.Drawing.Color.Turquoise;
            this.btPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPuntos.Location = new System.Drawing.Point(431, 340);
            this.btPuntos.Name = "btPuntos";
            this.btPuntos.Size = new System.Drawing.Size(134, 49);
            this.btPuntos.TabIndex = 51;
            this.btPuntos.Text = "Consultar Puntos";
            this.btPuntos.UseVisualStyleBackColor = false;
            this.btPuntos.Click += new System.EventHandler(this.btPuntos_Click);
            // 
            // ConsultarMillasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 409);
            this.Controls.Add(this.btPuntos);
            this.Controls.Add(this.dgvmillas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.btMillas);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarMillasForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button btMillas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvmillas;
        private System.Windows.Forms.Button btPuntos;
    }
}