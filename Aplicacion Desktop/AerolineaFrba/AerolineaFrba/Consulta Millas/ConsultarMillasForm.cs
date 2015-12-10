using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Dominio;
using AerolineaFrba.Utils;
namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultarMillasForm : Form
    {
        public ConsultarMillasForm()
        {
            InitializeComponent();
        }

        private void btMillas_Click(object sender, EventArgs e)
        {
            if(txtDni.Text==""){
                MessageBox.Show("Complete su dni");
                return;
            }

            if(!validarExtraDNI())return;



            string query = "select  top 1 dbas.millasVigentes ("+txtDni.Text+") from dbas.servicios";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);

              string queryExistencia ="select * from dbas.personas where dni_persona = "+txtDni.Text;
            DataTable dte = (new ConexionSQL()).cargarTablaSQL(queryExistencia);
            if (dte.Rows.Count == 0)
            {
                MessageBox.Show("El dni: " + txtDni.Text + " no se encuentra en la base ");
                return;
            }
           
            if (dte.Rows.Count > 1)
            {
                MessageBox.Show("Hay inconsistencia en la base de datos por DNI repetido. Dirigirse a hablar con el administrador");
                return;
            }

            string millas = dt.Rows[0][0].ToString();
            if(millas=="")//millas="0";
            {
                millas = "0";
            }

            MessageBox.Show("Usted tiene "+millas+" millas");
        }

        private bool validarExtraDNI()
        {
            Int32 a;

            if (txtDni.TextLength > 9)
            {
                MessageBox.Show("El DNI no esta en un rango valido (0 - 999999999)", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                a = Convert.ToInt32(txtDni.Text);

            }
            catch
            {
                MessageBox.Show("El DNI no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (a < 0)
            {
                MessageBox.Show("El DNI debe ser positivo", "Error", MessageBoxButtons.OK);
                return false;
            }

         return true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            inicializar();
            this.Hide();
        }

        private void inicializar()
        {
            txtDni.Text = "";
            dgvmillas.DataSource = null;
            dgvProd.DataSource = null;
        }

        private void btPuntos_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Complete su dni");
                return;
            }

            string queryExistencia = "select * from dbas.personas where dni_persona = " + txtDni.Text;
            DataTable dte = (new ConexionSQL()).cargarTablaSQL(queryExistencia);
            if (dte.Rows.Count == 0)
            {
                MessageBox.Show("El dni: " + txtDni.Text + " no se encuentra en la base ");
                return;
            }

            if (dte.Rows.Count > 1)
            {
                MessageBox.Show("Hay inconsistencia en la base de datos por DNI repetido. Dirigirse a hablar con el administrador");
                return;
            }

            if (!validarExtraDNI()) return;

            CompletadorDeTablas.hacerQuery("select * from dbas.historialMillas ("+txtDni.Text+")", ref dgvmillas);
            if (dgvmillas.Columns.Count != 0) dgvmillas.Columns.Remove("seleccionar");

            CompletadorDeTablas.hacerQuery("select * from DBAS.millasCanjeadas (" + txtDni.Text + ")", ref dgvProd);
            
            if (dgvProd.Columns.Count != 0) dgvProd.Columns.Remove("seleccionar");
        }

        private void ConsultarMillasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
