using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Login;

namespace AerolineaFrba
{
    public partial class PantallaBienvenida : Form
    {
        public PantallaBienvenida()
        {
            InitializeComponent();
        }

        private void PantallaBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btAdministrador_Click(object sender, EventArgs e)
        {
          LoginAdministrador ingreso= new LoginAdministrador();
          ingreso.Show();
          this.Hide();
        }
    }
}
