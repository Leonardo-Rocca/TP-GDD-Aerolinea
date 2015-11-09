namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLLegadaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoFiltro = new System.Windows.Forms.TextBox();
            this.btFiltroOrigen = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.resultadoFiltro2 = new System.Windows.Forms.TextBox();
            this.btFiltroDestino = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Matricula de Aeronave:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula.Location = new System.Drawing.Point(261, 87);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(232, 24);
            this.txtmatricula.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Registro de LLegadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Aeropuerto del cual proviene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Aeropuerto al cual arribó";
            // 
            // resultadoFiltro
            // 
            this.resultadoFiltro.Location = new System.Drawing.Point(569, 200);
            this.resultadoFiltro.Name = "resultadoFiltro";
            this.resultadoFiltro.Size = new System.Drawing.Size(51, 20);
            this.resultadoFiltro.TabIndex = 58;
            this.resultadoFiltro.Visible = false;
            this.resultadoFiltro.TextChanged += new System.EventHandler(this.resultadoFiltro_TextChanged);
            // 
            // btFiltroOrigen
            // 
            this.btFiltroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltroOrigen.Location = new System.Drawing.Point(520, 153);
            this.btFiltroOrigen.Name = "btFiltroOrigen";
            this.btFiltroOrigen.Size = new System.Drawing.Size(141, 41);
            this.btFiltroOrigen.TabIndex = 57;
            this.btFiltroOrigen.Text = "Buscar por filtro";
            this.btFiltroOrigen.UseVisualStyleBackColor = true;
            this.btFiltroOrigen.Click += new System.EventHandler(this.btFiltroOrigen_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.Location = new System.Drawing.Point(261, 155);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(232, 28);
            this.cmbOrigen.TabIndex = 56;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // resultadoFiltro2
            // 
            this.resultadoFiltro2.Location = new System.Drawing.Point(569, 289);
            this.resultadoFiltro2.Name = "resultadoFiltro2";
            this.resultadoFiltro2.Size = new System.Drawing.Size(51, 20);
            this.resultadoFiltro2.TabIndex = 61;
            this.resultadoFiltro2.Visible = false;
            this.resultadoFiltro2.TextChanged += new System.EventHandler(this.resultadoFiltro2_TextChanged);
            // 
            // btFiltroDestino
            // 
            this.btFiltroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltroDestino.Location = new System.Drawing.Point(520, 242);
            this.btFiltroDestino.Name = "btFiltroDestino";
            this.btFiltroDestino.Size = new System.Drawing.Size(141, 41);
            this.btFiltroDestino.TabIndex = 60;
            this.btFiltroDestino.Text = "Buscar por filtro";
            this.btFiltroDestino.UseVisualStyleBackColor = true;
            this.btFiltroDestino.Click += new System.EventHandler(this.btFiltroDestino_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.Location = new System.Drawing.Point(261, 244);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(232, 28);
            this.cmbDestino.TabIndex = 59;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(492, 347);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(117, 58);
            this.btAceptar.TabIndex = 63;
            this.btAceptar.Text = "Siguiente>>";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(109, 347);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 58);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "<<Volver";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // RegistroLLegadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 432);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.resultadoFiltro2);
            this.Controls.Add(this.btFiltroDestino);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.resultadoFiltro);
            this.Controls.Add(this.btFiltroOrigen);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label1);
            this.Name = "RegistroLLegadaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultadoFiltro;
        private System.Windows.Forms.Button btFiltroOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.TextBox resultadoFiltro2;
        private System.Windows.Forms.Button btFiltroDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}