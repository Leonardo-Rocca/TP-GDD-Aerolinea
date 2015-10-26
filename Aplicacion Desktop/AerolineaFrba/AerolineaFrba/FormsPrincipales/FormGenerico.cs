using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.FormsPrincipales
{
    public partial class FormGenerico : Form
    {
        public FormGenerico()
        {
            InitializeComponent();
        }

        private void FormGenerico_Load(object sender, EventArgs e)
        {

        }

        public void obtenerResultado(object contenido,Form quienLoEnvia){
            MessageBox.Show("padre", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            this.obtenerResultado(contenido, quienLoEnvia);
        }

    }
}
