namespace AerolineaFrba.Abm_Rol
{
    partial class modificarRolEspecificado
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
            System.Windows.Forms.Label label4;
            this.chkListaFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.modificarRol = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btSeleccionarTodo = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(163, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 141);
            label4.TabIndex = 17;
            label4.Text = "Hacer doble click para marcar funcionalides";
            // 
            // chkListaFuncionalidades
            // 
            this.chkListaFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListaFuncionalidades.FormattingEnabled = true;
            this.chkListaFuncionalidades.Location = new System.Drawing.Point(305, 134);
            this.chkListaFuncionalidades.Name = "chkListaFuncionalidades";
            this.chkListaFuncionalidades.Size = new System.Drawing.Size(319, 175);
            this.chkListaFuncionalidades.TabIndex = 16;
            this.chkListaFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.chkListaFuncionalidades_SelectedIndexChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(600, 339);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(117, 58);
            this.buttonAgregar.TabIndex = 15;
            this.buttonAgregar.Text = "Modificar Rol";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Elegir Funcionalidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(305, 86);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(319, 26);
            this.txtNombreRol.TabIndex = 11;
            // 
            // modificarRol
            // 
            this.modificarRol.AutoSize = true;
            this.modificarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarRol.Location = new System.Drawing.Point(384, 31);
            this.modificarRol.Name = "modificarRol";
            this.modificarRol.Size = new System.Drawing.Size(138, 25);
            this.modificarRol.TabIndex = 10;
            this.modificarRol.Text = "Modificar Rol";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(708, 86);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(127, 24);
            this.chkHabilitado.TabIndex = 18;
            this.chkHabilitado.Text = "Rol Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btSeleccionarTodo
            // 
            this.btSeleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccionarTodo.Location = new System.Drawing.Point(650, 174);
            this.btSeleccionarTodo.Name = "btSeleccionarTodo";
            this.btSeleccionarTodo.Size = new System.Drawing.Size(114, 31);
            this.btSeleccionarTodo.TabIndex = 19;
            this.btSeleccionarTodo.Text = "Seleccionar todo";
            this.btSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btSeleccionarTodo.Click += new System.EventHandler(this.btSeleccionarTodo_Click);
            // 
            // modificarRolEspecificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(898, 485);
            this.Controls.Add(this.btSeleccionarTodo);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(label4);
            this.Controls.Add(this.chkListaFuncionalidades);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.modificarRol);
            this.Name = "modificarRolEspecificado";
            this.Text = "modificarRolEspecificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaFuncionalidades;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label modificarRol;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btSeleccionarTodo;

    }
}