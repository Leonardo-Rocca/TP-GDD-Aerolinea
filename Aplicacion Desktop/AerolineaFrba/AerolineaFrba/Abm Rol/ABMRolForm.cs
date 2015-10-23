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
    public partial class ABMRolForm : Form
    {
        public ABMRolForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearRolForm crear = new CrearRolForm();
            crear.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarForm modify = new ModificarForm("Modificar Rol", "Modificar", 1);
            modify.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarForm modify = new ModificarForm("Eliminar Rol", "Eliminar",2);
            modify.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
