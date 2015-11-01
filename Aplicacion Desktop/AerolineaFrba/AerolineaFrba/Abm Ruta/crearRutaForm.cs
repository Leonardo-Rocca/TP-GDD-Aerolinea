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

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select top 1 (codigo_ruta +1)AS codigo_ruta FROM DBAS.rutas ORDER BY codigo_ruta DESC");
            DataRow row = dt.Rows[0];

            txtCodigo.Text = row.ToString();
           // txtCodigo.Text = "-1";
            vaciarTextos();

            chkListaServicios.Items.Clear();
            chkListaServicios.Items.Insert(0, "Primera Clase");
            chkListaServicios.Items.Insert(1, "Ejecutivo");
            chkListaServicios.Items.Insert(2, "Turista");

        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            inicializar();
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

            this.Hide(); 
            return;
        }

        private void agregarRuta()
        {
            // probar  (es posible q haya que cambiar los nombres de atributos en la vista)
            string comando = "INSERT INTO DBAS.caracteristicasRutas   "+
                           "( precio_base_por_KG,  precio_base_por_pasaje,ciudad_Origen, ciudad_Destino, tipo_servicio) " +  //porcentaje_arancel
           "select distinct '" + txtPregiokg.Text + "' , '" + txtPrecioPasaje + "','"  + txtCOrigen.Text + "','" + txtCDestino.Text + "' , tipo_servicio FROM DBAS.servicios WHERE tipo_servicio IN ( "; 
        
              foreach (Object elemento in chkListaServicios.CheckedItems)
            {
                comando = comando + " '" + elemento.ToString() + "',";
            }
            comando = comando + "'lalala' )";

            try
            {
                (new ConexionSQL()).ejecutarComandoSQL(comando);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }

            MessageBox.Show("Ruta creada (falta probar)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializar();
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

        private void vaciarTextos()
        {
             txtCOrigen.Text = "";
             txtCDestino.Text = "";
             txtPrecioPasaje.Text = "";
             txtPregiokg.Text = "";

        }

        private void txtCOrigen_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
