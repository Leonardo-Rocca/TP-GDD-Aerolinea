using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ModificarAeronave : Form
    {
        public int variable;
        public ModificarAeronave(int discriminador)
        {
            InitializeComponent();
            variable = discriminador;
        
            iniciar();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios");
            comboBoxServicio.DataSource = dt.DefaultView;
            comboBoxServicio.ValueMember = "tipo_servicio";

            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_fabricante FROM DBAS.fabricantes");
            comboBoxFabricante.DataSource = dta.DefaultView;
            comboBoxFabricante.ValueMember = "nombre_fabricante"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.setAnterior(this);
            _Aeronave paquete = new _Aeronave(txtMatricula,txtModelo,textPisos,textButacasPasillo,textButacasVentanilla,textKdDisponibles,comboBoxServicio,comboBoxFabricante);
            listado.cargarModificado(paquete);
            listado.Show();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
            {
                return;
            }

            string idFabricante = ((new ConexionSQL()).cargarTablaSQL("select distinct id_fabricante FROM DBAS.fabricantes where nombre_fabricante like '" + comboBoxFabricante.Text + "'")).Rows[0][0].ToString();
            string idServicio = ((new ConexionSQL()).cargarTablaSQL("select distinct id_servicio FROM DBAS.servicios where tipo_servicio like '" + comboBoxServicio.Text + "'")).Rows[0][0].ToString();
           // string query = "execute dbas. ";

            //EJECUTAR PROCEDURE

           // (new ConexionSQL()).cargarTablaSQL(query);

            MessageBox.Show("Modificacion de aeronave exitosa", "Modificacion aeronave", MessageBoxButtons.OK);
            iniciar();
        }

        private bool Validaciones()
        {

            if (!estaCompleto())
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

        public void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textPisos.Text = "";
            textButacasPasillo.Text = "";
            textButacasVentanilla.Text = "";
            textKdDisponibles.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!validaciones2()) return;
            MotivoDeBaja motivo = new MotivoDeBaja(this);
            this.Hide();
            motivo.Show();
        }

        private bool validaciones2()
        {
            if (!estaCompleto())
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatricula.Text != "")
            {

                DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave FROM DBAS.aeronaves where matricula_aeronave like '" + txtMatricula.Text + "'");
                if (dta.Rows.Count == 0)
                {
                    MessageBox.Show("El numero de matricula no existe", "Matricula invalida", MessageBoxButtons.OK);
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

        public string getMatricula()
        {
            return txtMatricula.Text;
        }

        public string getPisos()
        {
            return textPisos.Text;
        }

        public string getButacasPasillo()
        {
            return textButacasPasillo.Text;
        }

        public string getButacasVentanilla()
        {
            return textButacasVentanilla.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ModificarAeronave_Load(object sender, EventArgs e)
        {
            if (variable == 0)
            {
                butAceptar.Visible = true;
                button3.Visible = false;

            }
            else
            {
                butAceptar.Visible = false;
                button3.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.iniciar();
            this.Hide();
        }

    }
}
