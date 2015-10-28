namespace AerolineaFrba.Abm_Ruta
{
    partial class crearRutaForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.txtCOrigen = new System.Windows.Forms.TextBox();
            this.btsOringen = new System.Windows.Forms.Button();
            this.btsDestino = new System.Windows.Forms.Button();
            this.txtCDestino = new System.Windows.Forms.TextBox();
            this.lbDestino = new System.Windows.Forms.Label();
            this.txtPregiokg = new System.Windows.Forms.TextBox();
            this.lbPrecioKG = new System.Windows.Forms.Label();
            this.txtPrecioPasaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkListaServicios = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(284, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(116, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Crear Ruta";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(35, 108);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(120, 20);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "Codigo de Ruta";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(229, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(319, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(35, 262);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(110, 20);
            this.lbOrigen.TabIndex = 6;
            this.lbOrigen.Text = "Ciudad Origen";
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.Location = new System.Drawing.Point(35, 165);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(120, 20);
            this.lbService.TabIndex = 7;
            this.lbService.Text = "Tipo de Servicio";
            // 
            // txtCOrigen
            // 
            this.txtCOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOrigen.Location = new System.Drawing.Point(229, 259);
            this.txtCOrigen.Name = "txtCOrigen";
            this.txtCOrigen.ReadOnly = true;
            this.txtCOrigen.Size = new System.Drawing.Size(319, 26);
            this.txtCOrigen.TabIndex = 9;
            this.txtCOrigen.TextChanged += new System.EventHandler(this.txtCOrigen_TextChanged);
            // 
            // btsOringen
            // 
            this.btsOringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsOringen.Location = new System.Drawing.Point(574, 258);
            this.btsOringen.Name = "btsOringen";
            this.btsOringen.Size = new System.Drawing.Size(108, 29);
            this.btsOringen.TabIndex = 10;
            this.btsOringen.Text = "Seleccionar";
            this.btsOringen.UseVisualStyleBackColor = true;
            this.btsOringen.Click += new System.EventHandler(this.btsOringen_Click);
            // 
            // btsDestino
            // 
            this.btsDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsDestino.Location = new System.Drawing.Point(574, 323);
            this.btsDestino.Name = "btsDestino";
            this.btsDestino.Size = new System.Drawing.Size(108, 29);
            this.btsDestino.TabIndex = 13;
            this.btsDestino.Text = "Seleccionar";
            this.btsDestino.UseVisualStyleBackColor = true;
            this.btsDestino.Click += new System.EventHandler(this.btsDestino_Click);
            // 
            // txtCDestino
            // 
            this.txtCDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDestino.Location = new System.Drawing.Point(229, 324);
            this.txtCDestino.Name = "txtCDestino";
            this.txtCDestino.ReadOnly = true;
            this.txtCDestino.Size = new System.Drawing.Size(319, 26);
            this.txtCDestino.TabIndex = 12;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.Location = new System.Drawing.Point(35, 327);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(118, 20);
            this.lbDestino.TabIndex = 11;
            this.lbDestino.Text = "Ciudad Destino";
            // 
            // txtPregiokg
            // 
            this.txtPregiokg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregiokg.Location = new System.Drawing.Point(229, 388);
            this.txtPregiokg.Name = "txtPregiokg";
            this.txtPregiokg.Size = new System.Drawing.Size(319, 26);
            this.txtPregiokg.TabIndex = 15;
            // 
            // lbPrecioKG
            // 
            this.lbPrecioKG.AutoSize = true;
            this.lbPrecioKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioKG.Location = new System.Drawing.Point(35, 391);
            this.lbPrecioKG.Name = "lbPrecioKG";
            this.lbPrecioKG.Size = new System.Drawing.Size(148, 20);
            this.lbPrecioKG.TabIndex = 14;
            this.lbPrecioKG.Text = "Precio Base por KG";
            // 
            // txtPrecioPasaje
            // 
            this.txtPrecioPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPasaje.Location = new System.Drawing.Point(229, 449);
            this.txtPrecioPasaje.Name = "txtPrecioPasaje";
            this.txtPrecioPasaje.Size = new System.Drawing.Size(319, 26);
            this.txtPrecioPasaje.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio Base por Pasaje";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(547, 518);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(117, 58);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Agregar Ruta";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkListaServicios
            // 
            this.chkListaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListaServicios.FormattingEnabled = true;
            this.chkListaServicios.Location = new System.Drawing.Point(229, 158);
            this.chkListaServicios.Name = "chkListaServicios";
            this.chkListaServicios.Size = new System.Drawing.Size(319, 80);
            this.chkListaServicios.TabIndex = 20;
            // 
            // crearRutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 595);
            this.Controls.Add(this.chkListaServicios);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPrecioPasaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPregiokg);
            this.Controls.Add(this.lbPrecioKG);
            this.Controls.Add(this.btsDestino);
            this.Controls.Add(this.txtCDestino);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.btsOringen);
            this.Controls.Add(this.txtCOrigen);
            this.Controls.Add(this.lbService);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbTitle);
            this.Name = "crearRutaForm";
            this.Text = "crearRutaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.TextBox txtCOrigen;
        private System.Windows.Forms.Button btsOringen;
        private System.Windows.Forms.Button btsDestino;
        private System.Windows.Forms.TextBox txtCDestino;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.TextBox txtPregiokg;
        private System.Windows.Forms.Label lbPrecioKG;
        private System.Windows.Forms.TextBox txtPrecioPasaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox chkListaServicios;
    }
}