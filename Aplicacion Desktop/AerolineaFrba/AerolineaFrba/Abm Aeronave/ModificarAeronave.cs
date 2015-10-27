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
        public ModificarAeronave()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.setAnterior(this);
            _Aeronave paquete = new _Aeronave(txtMatricula,txtModelo,textPisos,textButacasPasillo,textButacasVentanilla,textKdDisponibles,comboBoxServicio,comboBoxFabricante);
            listado.cargarModificado(paquete);
            this.Hide();
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

        private void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textPisos.Text = "";
            textButacasPasillo.Text = "";
            textButacasVentanilla.Text = "";
            textKdDisponibles.Text = "";
        }
    }
}
