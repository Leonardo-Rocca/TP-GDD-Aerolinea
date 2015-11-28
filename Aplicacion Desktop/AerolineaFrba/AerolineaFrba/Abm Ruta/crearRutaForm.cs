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
using AerolineaFrba.Dominio;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class crearRutaForm : FormGenerico
    {
        int tipo = 0;//0 crear, 1 modificar
        private Ruta miRuta;

        public crearRutaForm()
        {
            InitializeComponent();
         //   DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios");

            inicializar();
        }

        public crearRutaForm(int tipoF)
        {
            tipo = tipoF;
            InitializeComponent();
            inicializar();
            if (tipo == 1)
            {
                lbTitle.Text = "ModificarRuta";
                buttonGuardar.Text = "Modificar";
                lbseleccion.Visible = true;
            }

        }

        private void inicializar()
        {

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select top 1 (codigo_ruta +1)AS codigo_ruta FROM DBAS.rutas ORDER BY codigo_ruta DESC");
            DataRow row = dt.Rows[0];

            txtCodigo.Text = row[0].ToString();
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
            if (tipo == 0)
            {
                this.Hide();
            }
            else
            {
                this.Close();
            }

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
            if (txtCDestino.Text.Equals(txtCOrigen.Text))
            {
                MessageBox.Show("La ciudad de Origen debe ser distinta que la de Destino");
                return;
            }

            Int32 a, b;

         /*   try
            {
                a = Convert.ToInt32(txtPregiokg.Text);
            }
            catch
            {
                MessageBox.Show("El precio base por kg no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                b = Convert.ToInt32(txtPrecioPasaje.Text);
            }
            catch
            {
                MessageBox.Show("El precio base por pasaje no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return;
            }

            if (a < 0)
            {
                MessageBox.Show("El precio base por kg no es valido", "Error", MessageBoxButtons.OK);
                return;
            }

            if (b < 0)
            {
                MessageBox.Show("El precio base por pasaje no es valido", "Error", MessageBoxButtons.OK);
                return;
            }
*/
            try
            {
            if (tipo == 0)
            {
                agregarRuta();
            }
            else
            {
                modificarRuta();
            }
            navegacion.modificarRuta.inicializar();
            navegacion.eliminarRuta.inicializar();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error con el tipo de datos ingresado");
               // MessageBox.Show(er.Message);
                return;
            }

            this.Hide(); 
            return;
        }

        private void agregarRuta()
        {

            
                agregarModificar("-1");
            
            MessageBox.Show("Ruta creada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializar();
        }

        private void agregarModificar(string code)
        {

            // probar  (es posible q haya que cambiar los nombres de atributos en la vista)
            string comando = "INSERT INTO DBAS.caracteristicasRutas   " +
                           "(codigo_ruta ,  precio_base_por_KG,  precio_base_por_pasaje,ciudad_Origen, ciudad_Destino, tipo_servicio) " +  //porcentaje_arancel
           "select distinct "+code+", '" + txtPregiokg.Text + "' , '" + txtPrecioPasaje.Text + "','" + txtCOrigen.Text + "','" + txtCDestino.Text + "' , tipo_servicio FROM DBAS.servicios WHERE tipo_servicio IN ( ";

            foreach (Object elemento in chkListaServicios.CheckedItems)
            {
                comando = comando + " '" + elemento.ToString() + "',";
            }
            comando = comando + "'lalala' )";

          
                (new ConexionSQL()).ejecutarComandoSQL(comando);
            
           
          return;
        }

        private void modificarRuta()
        {
            string service = "dammy";

            agregarModificar(txtCodigo.Text);
            

         // foreach (string service in chkListaServicios.CheckedItems)
            for (int i = 0; i <= (chkListaServicios.CheckedItems.Count - 1); i++) 
            {
             //   string subSelect = "(select top "+(i+1).ToString()+" tipo_servicio From DBAS.servicios)";
              if(chkListaServicios.GetItemChecked(i)){
                
                string comando = "UPDATE DBAS.caracteristicasRutas  SET ciudad_Origen = '" + txtCOrigen.Text + "', ciudad_Destino = '"+txtCDestino.Text+"', precio_base_por_pasaje = "+Convert.ToDouble(txtPrecioPasaje.Text).ToString() +", precio_base_por_KG = "+txtPregiokg.Text+ //, tipo_servicio = '"+service+"'"+
            " WHERE codigo_ruta = " + txtCodigo ;
        //        (new ConexionSQL()).ejecutarComandoSQL(comando); --rompe
              
              }
            }

                MessageBox.Show("Ruta Modificada ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
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

        public void cargarRuta(Ruta r)
        {
            txtCodigo.Text = r.idRuta.ToString();
            txtCOrigen.Text = r.ciudad_Origen;
            txtCDestino.Text = r.ciudad_Destino;
            txtPrecioPasaje.Text = r.precio_base_por_pasaje;
            txtPregiokg.Text = r.precio_base_por_KG;

              for (int i = 0; i <= (chkListaServicios.Items.Count - 1); i++) {
      
                  if (r.servicios.Contains(chkListaServicios.Items[i].ToString()))
               {
                      chkListaServicios.SetItemCheckState(i, CheckState.Checked);
               }
                  else
                  {
                     chkListaServicios.SetItemCheckState(i, CheckState.Unchecked);
                  }
              }

        }

        private void crearRutaForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
