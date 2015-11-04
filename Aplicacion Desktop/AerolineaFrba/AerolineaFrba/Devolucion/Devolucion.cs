using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
            iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.iniciar();
            this.Hide();
        }

        private void iniciar()
        {
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateFecha.Value = DateTime.Today;
          
        }

    }
}
