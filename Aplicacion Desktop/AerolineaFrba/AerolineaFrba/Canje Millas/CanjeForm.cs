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
namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeForm : FormGenerico
    {
        public CanjeForm()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            txtDni.Text = "";
            textCantidad.Text = "";
            string query = "select  * FROM DBAS.productos order by valor_en_milas ";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            cmbProductos.DataSource = dt.DefaultView;
            cmbProductos.ValueMember = "nombre_producto";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(validacionTextosVacios())return;
            if (validacionExtra()) return;
            if (!validacionPuntosSuficientes()) return;

            string query = "select* from dbas.personas WHERE dni_persona = " + txtDni.Text;
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0) return;
            if (dt.Rows.Count > 1)
            {
                MessageBox.Show("Hay inconsistencia en la base de datos por DNI repetido. Dirigirse a hablar con el administrador");
                return;
            }
            string idPersona = dt.Rows[0][0].ToString();
             //----obtengo el idcliente
            query = "select id_cliente from dbas.clientes WHERE id_persona = " + idPersona;
            dt = (new ConexionSQL()).cargarTablaSQL(query);
            idPersona = dt.Rows[0][0].ToString();
            
            string idProd = obtenerIdProducto();
            string qsp = "execute dbas.canjeProducto " + idPersona + "," + idProd + "," + textCantidad.Text;
            (new ConexionSQL()).ejecutarComandoSQL(qsp);

           
            MessageBox.Show("Millas canjeadas correctamente", "Canje de Millas", MessageBoxButtons.OK);
            this.inicializar();
            this.Hide();
        }

        private bool validacionExtra()
        {
            Int32 a;
  
                try
                {
                    a = Convert.ToInt32(txtDni.Text);

                }
                catch
                {
                    MessageBox.Show("El DNI no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                    return true;
                }

                if (a < 0 || a > 99999999)
                {
                    MessageBox.Show("El DNI no esta en un rango valido", "Error", MessageBoxButtons.OK);
                    return true;
                }

                int b;
                try
                {
                    b = Convert.ToInt32(textCantidad.Text);

                }
                catch
                {
                    MessageBox.Show("La cantidad no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                    return true;
                }

                if (b<0)
                {
                    MessageBox.Show("La cantidad no esta en un rango valido", "Error", MessageBoxButtons.OK);
                    return true;
                }

                return false;
        }

        private string obtenerIdProducto()
        {
            string query = "select  * from dbas.productos WHERE nombre_producto = '" + cmbProductos.Text + "'";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows[0][0].ToString();
        }

        private bool validacionPuntosSuficientes()
        {
            string query = "select  top 1 dbas.millasVigentes (" + txtDni.Text + ") from dbas.roles";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);

            string queryExistencia = "select * from dbas.personas where dni_persona = " + txtDni.Text;
            DataTable dte = (new ConexionSQL()).cargarTablaSQL(queryExistencia);
            if (dte.Rows.Count == 0)
            {
                MessageBox.Show("El dni: " + txtDni.Text + " no se encuentra en la base ");
                return false;
            }

            string millas = dt.Rows[0][0].ToString();
            if (millas == "")//millas="0";
            {
                millas = "0";
            }

            query = "select  * from dbas.productos WHERE nombre_producto = '"+cmbProductos.Text+"'" ;
            dt = (new ConexionSQL()).cargarTablaSQL(query);
            int valorEnMillas = Convert.ToInt32(dt.Rows[0][1].ToString());
            int cantStock = Convert.ToInt32(dt.Rows[0][3].ToString());

            if (cantStock < Convert.ToInt32(textCantidad.Text)) 
            {
                MessageBox.Show("No se puede realizar el canje, solo quedan "+cantStock.ToString()+" unidades del producto en stock.");
                return false;
            }

            if (Convert.ToInt32(millas) < Convert.ToInt32(textCantidad.Text)*valorEnMillas)
            {
                MessageBox.Show("Las millas que tiene no son suficientes para realizar el canje");
                return false;
            }

            return true;

        }

        private bool validacionTextosVacios()
        {
            if (txtDni.Text == "") {
                MessageBox.Show("Debe completar su dni");
                return true;
            }

            if (textCantidad.Text == "")
            {
                MessageBox.Show("Debe indicar la cantidad del producto");
                return true;
            }
            return false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.inicializar();
            this.Hide();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            ListadoProductoForm lOrigen = new ListadoProductoForm();
            lOrigen.setAnterior(this);
            lOrigen.setBuffer(ref txtresultadoFiltro);
            lOrigen.Show();
        }

        internal void setProducto(string producto)
        {
            cmbProductos.Text = producto;
        }

        private void txtresultadoFiltro_TextChanged(object sender, EventArgs e)
        {
            cmbProductos.Text = txtresultadoFiltro.Text;
        }

        private void CanjeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
