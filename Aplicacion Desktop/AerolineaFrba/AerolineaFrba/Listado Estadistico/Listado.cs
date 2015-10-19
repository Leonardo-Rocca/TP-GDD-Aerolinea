using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            comboBoxFiltro3.Text = "";
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";
            dataGridView1.DataSource = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccionar formSeleccionar = new Seleccionar();
            formSeleccionar.setearFormularioQueMeLlamo(this);
            this.Hide();
            formSeleccionar.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxFiltro3.Text = "";
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";
            dataGridView1.DataSource = null;

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
