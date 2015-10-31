namespace AerolineaFrba.Abm_Aeronave
{
    partial class reemplazoCancelarPasajes
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
            this.buttonReemplazar = new System.Windows.Forms.Button();
            this.buttonCancelarPasajes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReemplazar
            // 
            this.buttonReemplazar.Location = new System.Drawing.Point(102, 89);
            this.buttonReemplazar.Name = "buttonReemplazar";
            this.buttonReemplazar.Size = new System.Drawing.Size(141, 21);
            this.buttonReemplazar.TabIndex = 40;
            this.buttonReemplazar.Text = "Reemplazar aeronave";
            this.buttonReemplazar.UseVisualStyleBackColor = true;
            this.buttonReemplazar.Click += new System.EventHandler(this.buttonReemplazar_Click);
            // 
            // buttonCancelarPasajes
            // 
            this.buttonCancelarPasajes.Location = new System.Drawing.Point(102, 49);
            this.buttonCancelarPasajes.Name = "buttonCancelarPasajes";
            this.buttonCancelarPasajes.Size = new System.Drawing.Size(141, 21);
            this.buttonCancelarPasajes.TabIndex = 39;
            this.buttonCancelarPasajes.Text = "Cancelar los pasajes";
            this.buttonCancelarPasajes.UseVisualStyleBackColor = true;
            this.buttonCancelarPasajes.Click += new System.EventHandler(this.buttonCancelarPasajes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "La aeronave esta en uso. Por favor indique que desea hacer: ";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(102, 128);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(141, 21);
            this.buttonCancelar.TabIndex = 42;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // reemplazoCancelarPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 188);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReemplazar);
            this.Controls.Add(this.buttonCancelarPasajes);
            this.Name = "reemplazoCancelarPasajes";
            this.Text = "Baja Aeronave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReemplazar;
        private System.Windows.Forms.Button buttonCancelarPasajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
    }
}