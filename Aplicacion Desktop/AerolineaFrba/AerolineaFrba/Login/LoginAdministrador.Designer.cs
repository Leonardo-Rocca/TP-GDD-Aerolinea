namespace AerolineaFrba.Login
{
    partial class LoginAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(125, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 24);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.Location = new System.Drawing.Point(332, 219);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(124, 53);
            this.botonIniciarSesion.TabIndex = 17;
            this.botonIniciarSesion.Text = "Iniciar Sesión";
            this.botonIniciarSesion.UseVisualStyleBackColor = true;
            this.botonIniciarSesion.Click += new System.EventHandler(this.botonIniciarSesion_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(91, 219);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(118, 53);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "<< Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(125, 107);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(340, 24);
            this.txtpass.TabIndex = 18;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // LoginAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(540, 309);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.botonVolver);
            this.Name = "LoginAdministrador";
            this.Text = "LoginAdministrador";
            this.Load += new System.EventHandler(this.LoginAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox txtpass;
    }
}