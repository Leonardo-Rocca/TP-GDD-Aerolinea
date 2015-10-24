using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class crearRutaForm : Form
    {
        public crearRutaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ruta agregada (dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide(); 
            return;
        }
    }
}
