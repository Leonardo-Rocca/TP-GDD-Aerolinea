using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM  DBAS.ciudades WHERE nombre_ciudad LIKE '_" + txtNombreCity.Text + "'OR nombre_ciudad LIKE '" + txtNombreCity.Text + "' ");
            //--pregunto si hay alguna fila cuyo nombre coincida con el ingresado-- 
            if (dt.Rows.Count == 0)
            {
                //TO-DO
                MessageBox.Show("Ciudad Agregada (DAMMY)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("La ciudad ya existe", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Ciudad agregada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
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
    }
}
