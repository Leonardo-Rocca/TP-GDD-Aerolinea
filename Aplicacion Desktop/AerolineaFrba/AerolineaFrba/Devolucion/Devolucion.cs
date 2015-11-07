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

        public List<String> pasajes = new List<String>();
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
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateFecha.Value = DateTime.Today;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            pasajes.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.Text = textBox1.Text;
            textBox0.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            pasajes.Remove(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
