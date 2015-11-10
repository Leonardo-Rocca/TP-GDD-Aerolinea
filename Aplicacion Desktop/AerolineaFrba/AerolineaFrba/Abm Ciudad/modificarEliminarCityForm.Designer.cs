namespace AerolineaFrba.Abm_Ciudad
{
    partial class modificarEliminarCityForm
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btFiltro = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadoFiltro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(209, 27);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(174, 25);
            this.lbtitulo.TabIndex = 2;
            this.lbtitulo.Text = "Modificar Ciudad";
            // 
            // btFiltro
            // 
            this.btFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltro.Location = new System.Drawing.Point(477, 104);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(122, 52);
            this.btFiltro.TabIndex = 15;
            this.btFiltro.Text = "Buscar por filtro";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(446, 275);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(117, 58);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Modificar City";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(63, 275);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 58);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.Location = new System.Drawing.Point(215, 110);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(232, 28);
            this.comboBoxCity.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione Ciudad";
            // 
            // resultadoFiltro
            // 
            this.resultadoFiltro.Location = new System.Drawing.Point(522, 162);
            this.resultadoFiltro.Name = "resultadoFiltro";
            this.resultadoFiltro.Size = new System.Drawing.Size(51, 20);
            this.resultadoFiltro.TabIndex = 16;
            this.resultadoFiltro.TextChanged += new System.EventHandler(this.resultadoFiltro_TextChanged);
            // 
            // modificarEliminarCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 369);
            this.Controls.Add(this.resultadoFiltro);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtitulo);
            this.Name = "modificarEliminarCityForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.modificarEliminarCityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultadoFiltro;
    }
}