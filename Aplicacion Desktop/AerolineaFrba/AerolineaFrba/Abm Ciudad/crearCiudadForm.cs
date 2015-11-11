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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class crearCiudadForm : Form
    {
        public crearCiudadForm()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreCity.Text.Equals(string.Empty))
            {
                MessageBox.Show("Falta agregar nombre", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select * FROM  DBAS.ciudades WHERE nombre_ciudad LIKE '_" + txtNombreCity.Text + "'OR nombre_ciudad LIKE '" + txtNombreCity.Text + "' ");
            //--pregunto si hay alguna fila cuyo nombre coincida con el ingresado-- 
            if (dt.Rows.Count == 0)
            {
                //ALTA DE CIUDADES 
                string comando = "INSERT INTO DBAS.ciudades (nombre_ciudad) values ('" + txtNombreCity.Text + "')";
                (new ConexionSQL()).ejecutarComandoSQL(comando);
                MessageBox.Show("Ciudad Agregada ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                 if (dt.Rows[0][2].ToString() == "0")
                 {
                     string comando = "  Update dbas.ciudades set habilitada_ciudad = 1 where id_ciudad= " +dt.Rows[0][0] ;
                     (new ConexionSQL()).ejecutarComandoSQL(comando);
                    MessageBox.Show("Ciudad dada de Alta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }else{
                MessageBox.Show("La ciudad ya existe", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
            }
            navegacion.modificarCiudad.cargarComboSeleccion();
            navegacion.EliminarCiudad.cargarComboSeleccion();
  //          MessageBox.Show("Ciudad agregada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide(); //.Close();
            txtNombreCity.Text = "";
            return;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtNombreCity.Text = "";
            return;
        }

        private void crearCiudadForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
