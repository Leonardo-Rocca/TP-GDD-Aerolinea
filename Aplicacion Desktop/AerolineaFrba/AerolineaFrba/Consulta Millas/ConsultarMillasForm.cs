using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show("Usted tiene dammy millas");
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            inicializar();
            this.Hide();
        }

        private void inicializar()
        {
            txtDni.Text = "";
        }
    }
}
