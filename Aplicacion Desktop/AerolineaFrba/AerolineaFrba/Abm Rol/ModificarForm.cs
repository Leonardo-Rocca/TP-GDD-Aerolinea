using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarForm : Form
    {
        public ModificarForm()
        {
            InitializeComponent(); 
            comboBoxRol.Items.Insert(0, "Usuario");
            comboBoxRol.Items.Insert(1, "El que mueve la papota");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            string cadena = comboBoxRol.Text;
            modificarRolEspecificado modify = new modificarRolEspecificado(cadena);
            modify.Show();
            this.Close();
        }
    }
}
