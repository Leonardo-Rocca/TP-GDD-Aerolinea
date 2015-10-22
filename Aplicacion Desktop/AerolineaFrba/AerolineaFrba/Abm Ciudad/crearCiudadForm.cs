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
            MessageBox.Show("Ciudad agregada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide(); //.Close();
            txtNombreCity.Text = "";
            return;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtNombreCity.Text = "";
        }
    }
}
