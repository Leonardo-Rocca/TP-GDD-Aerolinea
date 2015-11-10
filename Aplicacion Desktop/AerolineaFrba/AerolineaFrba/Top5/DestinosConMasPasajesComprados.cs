using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Top5
{
    public partial class DestinosConMasPasajesComprados : Form
    {
        DiscriminadorTop5 anterior;
        int discriminador;
        public DestinosConMasPasajesComprados(DiscriminadorTop5 a,int i)
        {
            InitializeComponent();
            anterior = a;
            discriminador = i;
            iniciar();
        }

        private void iniciar()
        {
            textBox1.Text = "";
            comboBoxSemestre.Text = "Primer Semestre";
            comboBoxSemestre.Items.Add("Primer Semestre");
            comboBoxSemestre.Items.Add("Segundo Semestre");
        }

        private void DestinosConMasPasajesComprados_Load(object sender, EventArgs e)
        {

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {

            if (!validaciones())
            {
                return;
            }

            if (discriminador == 1)
            {
                pasajesMasComprados();
                return;
            }

            if (discriminador == 2)
            {
                aeronavesConMasDiasFueraDeServicio();
                return;
            }

            if (discriminador == 3)
            {
                personasConMasPuntosAcumulados();
                return;
            }

            if (discriminador == 4)
            {
                personasConMasPasajesCancelados();
                return;
            }

            if (discriminador == 5)
            {
                aeronavesMasVacias();
                return;
            }
            
        }

        private void aeronavesMasVacias()
        {
            int semestre = 1;
            if (comboBoxSemestre.Text == "Segundo Semestre") semestre = 2;
            string query = "select * from dbas.Top5AeronavesMasVacias(" + semestre.ToString() + ", " + textBox1.Text + ")";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Aeronaves mas vacias", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void personasConMasPasajesCancelados()
        {
            int semestre = 1;
            if (comboBoxSemestre.Text == "Segundo Semestre") semestre = 2;
            string query = "select * from dbas.Top5DeLosDestinosConMasPasajesCancelados(" + semestre.ToString() + ", " + textBox1.Text + ")";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Mas pasajes cancelados", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void personasConMasPuntosAcumulados()
        {
            int semestre = 1;
            if (comboBoxSemestre.Text == "Segundo Semestre") semestre = 2;
            string query = "select * from dbas.Top5ClientesConMasPuntosAcumulados(" + semestre.ToString() + ", " + textBox1.Text + ")";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Mas puntos Acumulados", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void aeronavesConMasDiasFueraDeServicio()
        {
            int semestre = 1;
            if (comboBoxSemestre.Text == "Segundo Semestre") semestre = 2;
            string query = "select * from dbas.Top5AeronavesConMayorCantidadDeDiasFueraDeServicio(" + semestre.ToString() + ", " + textBox1.Text + ")";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Aeronaves con mas dias fuera de servicio", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void pasajesMasComprados()
        {
            int semestre = 1;
            if (comboBoxSemestre.Text == "Segundo Semestre") semestre = 2;
            string query = "select * from dbas.Top5DeLosDestinosConMasPasajesComprados(" + semestre.ToString() + ", " + textBox1.Text + ")";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Destinos con mas pasajes Comprados", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private bool validaciones()
        {
            if (textBox1.Text == "" || comboBoxSemestre.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Top 5", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return false;
            }

            int anio;
            try {Convert.ToInt32(textBox1.Text); }
            catch
            {
                MessageBox.Show("Error en los datos ingresados. No es un año valido", "Top 5", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return false;
               
            }

            anio = Convert.ToInt32(textBox1.Text);
            if (anio < 1800 || anio > DateTime.Parse(Program.nuevaFechaSistema()).Year) //no tocar el año, ya va a andar cuando cambien la fecha del sistema
            {
                MessageBox.Show("El año especificado se encuentra fuera de los rangos validos", "Top 5", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
            anterior.Show();
            this.Close();
        }
    }
}
