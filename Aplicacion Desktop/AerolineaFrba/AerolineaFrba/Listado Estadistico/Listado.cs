using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            comboBoxFiltro3.SelectedIndex = -1;
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
            comboBoxFiltro3.SelectedIndex = -1;
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";
            dataGridView1.DataSource = null;

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Boolean yaTieneCondicion = false;
            string query = "select distinct Aeronave_Fabricante, Tipo_Servicio FROM gd_esquema.Maestra";

            if (!this.hayAlgunFiltro())
            {
                return;
            }

            query = query + " WHERE ";
            if (textBoxFiltro1.TextLength != 0)
            {
                string agregado = "Aeronave_Fabricante" + " LIKE '%" + textBoxFiltro1.Text + "%'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;

            }

            if (textBoxFiltro2.TextLength != 0)
            {
                string agregado = "000000000 LIKE '_" + textBoxFiltro2.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;

            }

            /* if (textBoxFiltro2Seleccionar.TextLength != 0)
             {
                 string agregado; //poner algo
                 armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                 yaTieneCondicion = true;

             }
             */

            ConexionSQL conn = new ConexionSQL();
            DataTable dt = conn.cargarTablaSQL(query);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

            comboBoxFiltro3.Text = "";
            comboBoxFiltro3.SelectedIndex = -1;
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            textBoxFiltro2Seleccionar.Text = "";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados en la consulta", "Fallo la busqueda", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private Boolean hayAlgunFiltro()
        {
            return (textBoxFiltro1.TextLength != 0 || textBoxFiltro2.TextLength != 0 || textBoxFiltro2Seleccionar.TextLength != 0 || comboBoxFiltro3.SelectedIndex != -1);
        }

        private void armarQueryCompleja(ref string query, string agregado, Boolean yaTieneCondicion)
        {
            if (yaTieneCondicion)
                query += " AND " + agregado;
            else
            {
                query += agregado;
            }
        }

    }

}
