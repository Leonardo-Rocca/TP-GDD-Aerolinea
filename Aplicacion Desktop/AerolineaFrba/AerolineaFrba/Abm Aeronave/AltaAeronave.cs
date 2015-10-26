using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        public AltaAeronave()
        {
            InitializeComponent();
            iniciar();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios");
            comboBoxServicio.DataSource = dt.DefaultView;
            comboBoxServicio.ValueMember = "tipo_servicio";

            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_fabricante FROM DBAS.fabricantes");
            comboBoxFabricante.DataSource = dta.DefaultView;
            comboBoxFabricante.ValueMember = "nombre_fabricante"; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AltaAeronave_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textPisos.Text = "";
            textButacasPasillo.Text = "";
            textButacasVentanilla.Text = "";
            textKdDisponibles.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(!Validaciones())
            {
                return;
            }

            string idFabricante = ((new ConexionSQL()).cargarTablaSQL("select distinct id_fabricante FROM DBAS.fabricantes where nombre_fabricante like '" + comboBoxFabricante.Text + "'")).Rows[0][0].ToString();
            string idServicio = ((new ConexionSQL()).cargarTablaSQL("select distinct id_servicio FROM DBAS.servicios where tipo_servicio like '" + comboBoxServicio.Text + "'")).Rows[0][0].ToString();
            string query = "execute dbas.altaAeronave " + idFabricante + ", " + idServicio + ", '" + txtMatricula.Text + "', '" + txtModelo.Text + "', "+ textKdDisponibles.Text + ", " + textButacasPasillo.Text + ", " + textButacasVentanilla.Text + ", " + textPisos.Text;

            (new ConexionSQL()).cargarTablaSQL(query);
            
            MessageBox.Show("Alta aeronave exitosa", "Alta aeronave", MessageBoxButtons.OK);
            iniciar();
        }

        private bool Validaciones()
        {

            if(!estaCompleto())
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatricula.Text != "")
            {

                DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave FROM DBAS.aeronaves where matricula_aeronave like '" + txtMatricula.Text + "'");
                if (dta.Rows.Count != 0)
                {
                    MessageBox.Show("El numero de matricula ya existe", "Matricula invalida", MessageBoxButtons.OK);
                    return false;
                }
               
            }

            int a = Convert.ToInt32(textButacasPasillo.Text);
            int b = Convert.ToInt32(textButacasVentanilla.Text);
            int c = Convert.ToInt32(textPisos.Text);
            if (a < 1 || b < 1)
            {
                MessageBox.Show("Cantidad de butacas invalida", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (c < 1)
            {
                MessageBox.Show("Cantidad de pisos invalida", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool estaCompleto()
        {
            return (txtMatricula.TextLength != 0 && txtModelo.TextLength != 0 && textPisos.TextLength != 0 && textKdDisponibles.TextLength != 0 && textButacasVentanilla.TextLength != 0 && textButacasPasillo.TextLength != 0); //&& comboBoxFabricante.SelectedIndex != -1 && comboBoxServicio.SelectedIndex != -1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }
    }
}
