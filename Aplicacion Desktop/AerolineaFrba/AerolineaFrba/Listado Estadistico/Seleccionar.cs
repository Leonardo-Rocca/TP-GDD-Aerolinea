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
    public partial class Seleccionar : Form
    {
        Form formularioQueLoLlamo;

        public Seleccionar()
        {
            InitializeComponent();
            comboBoxFiltro3.Text = "";
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";
            dataGridView1.DataSource = null;
        }

        private void Seleccionar_Load(object sender, EventArgs e)
        {
        }

        public void setearFormularioQueMeLlamo(Form formulario)
        {
            formularioQueLoLlamo = formulario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             monthCalendar1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textBoxFiltro2Seleccionar.Text = "Desde = " + e.Start.ToShortDateString() + ": Hasta = " + e.End.ToShortDateString();
            monthCalendar1.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxFiltro3.Text = "";
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioQueLoLlamo.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();
            DataTable dt = conn.cargarTablaSQL("select distinct Aeronave_Fabricante, Tipo_Servicio FROM gd_esquema.Maestra");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

    }
}
