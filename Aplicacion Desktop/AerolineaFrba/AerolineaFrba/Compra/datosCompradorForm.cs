using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class datosCompradorForm : Form
    {
        public datosCompradorForm()
        {
            InitializeComponent();
        }

        private void datosCompradorForm_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Compra.compra.Show();
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //TO-DO
            Compra.inicializar();
            this.Close();
        }
    }
}
