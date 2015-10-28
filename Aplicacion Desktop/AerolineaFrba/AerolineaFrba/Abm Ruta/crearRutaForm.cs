using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Ciudad;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class crearRutaForm : FormGenerico
    {
       
        public crearRutaForm()
        {
            InitializeComponent();

         //   DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios");
            inicializar();
        }

        private void inicializar()
        {
            chkListaServicios.Items.Insert(0, "Primera Clase");
            chkListaServicios.Items.Insert(1, "Ejecutivo");
            chkListaServicios.Items.Insert(2, "Turista");
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select top 1 (codigo_ruta +1)AS codigo_ruta FROM DBAS.rutas ORDER BY codigo_ruta DESC");
            DataRow row = dt.Rows[0];

            txtCodigo.Text = row.ToString();
           // txtCodigo.Text = "-1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (chkListaServicios.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Falta elegir tipos de servicio", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (txtCDestino.Text.Equals(string.Empty) || txtCodigo.Text.Equals(string.Empty) || txtCOrigen.Text.Equals(string.Empty) || txtPrecioPasaje.Text.Equals(string.Empty) || txtPregiokg.Text.Equals(string.Empty)){
                MessageBox.Show("Debe completar todos los campos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            agregarRuta();
            MessageBox.Show("Ruta agregada (dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide(); 
            return;
        }

        private void agregarRuta()
        {
            //TO DO
            // Cambiar por vista
            string comando = "INSERT INTO DBAS.rutasvISTA values " + txtCOrigen.Text + "," + txtCDestino.Text + " , ";
        }

        private void btsOringen_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
           lOrigen.setFormAnteriorSup(this);
           lOrigen.setBuffer(ref txtCOrigen);
           lOrigen.Show();

           

        }

        private void btsDestino_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtCDestino);
             lOrigen.Show();
        }

        public void obtenerResultado(object contenido, Form emisor)
        {
            MessageBox.Show("Resultado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void txtCOrigen_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
