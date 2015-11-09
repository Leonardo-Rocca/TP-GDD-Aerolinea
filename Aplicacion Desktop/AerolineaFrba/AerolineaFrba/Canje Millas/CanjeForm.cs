using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeForm : Form
    {
        public CanjeForm()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            string query = "select  * FROM DBAS.productos order by valor_en_milas ";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            cmbProductos.DataSource = dt.DefaultView;
            cmbProductos.ValueMember = "nombre_producto";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(validacionTextosVacios())return;
           
            if (!validacionPuntosSuficientes()) return;

        }

        private bool validacionPuntosSuficientes()
        {
            string query = "select  top 1 dbas.millasVigentes (" + txtDni.Text + ") from dbas.roles";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);

            string millas = dt.Rows[0][0].ToString();
            if (millas == "")//millas="0";
            {
                MessageBox.Show("El dni: " + txtDni.Text + " no se encuentra en la base ");
                return false;
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

            //to-do realizar canje
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
    }
}
