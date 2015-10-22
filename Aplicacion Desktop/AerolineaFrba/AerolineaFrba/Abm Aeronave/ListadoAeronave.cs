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
    public partial class ListadoAeronave : Listado_Estadistico.ListadoMaestro
    {

        private string query = "select distinct matricula_aeronave,numero_aeronave,modelo_aeronave FROM DBAS.aeronaves";
        private Boolean yaTieneCondicion = false;

        public ListadoAeronave()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textButacas.Text = ""; 
            textFabricante.Text = "";
            textFechaDesde.Text = "";
            textServicio.Text = "";
            textBoxDesdekg.Text = "";
            textBoxHastakg.Text = "";
            textBoxHastakg.Visible = false;
            textBoxDesdekg.Visible = false;
            checkEncomienda.Checked = false;
            checkHabilitado.Checked = false;
            checkInhabilitado.Checked = false;
            checkPasaje.Checked = false;
            textServicio.ReadOnly = true;
            label4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
         
        }

        private void ListadoAeronave_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkEncomienda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEncomienda.Checked)
            {
                checkPasaje.Checked = false;
                textBoxHastakg.Visible = true;
                label4.Visible = true;
                label10.Visible = true;
                textBoxDesdekg.Visible = true;
                label9.Visible = true;
            }else
            {
                textBoxHastakg.Visible = false;
                textBoxDesdekg.Visible = false;
                label9.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                textBoxHastakg.Text = "";
                textBoxDesdekg.Text="";
            }
        }

        private void checkPasaje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPasaje.Checked)
            {
                checkEncomienda.Checked = false;
                textBoxHastakg.Visible = false;
                label4.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBoxDesdekg.Text = "";
                textBoxHastakg.Text = "";
                textBoxHastakg.Visible = false;
                textBoxDesdekg.Visible = false;
                textBoxHastakg.Text = "";
            }
        }

        private void checkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHabilitado.Checked)
            {
               checkInhabilitado.Checked = false;
            }
        }

        private void checkInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInhabilitado.Checked)
            {
                checkHabilitado.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!validaciones())
            {
                return;
            }

            query = query + " WHERE ";
            if (txtMatricula.TextLength != 0)
            {
                string agregado = "matricula_aeronave LIKE '_" + txtMatricula.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (txtModelo.TextLength != 0)
            {
                string agregado = "modelo_aeronave LIKE '_" + txtModelo.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            //EL DE FABRICANTE

            if (textButacas.TextLength != 0)
            {
                string agregado = "cantidad_butacas < " + textButacas.Text;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkPasaje.Checked)
            {
                string agregado = "kg_disponible_encimienda = 0.0";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkEncomienda.Checked)
            {
                string agregado = "kg_disponible_encimienda BETWEEN " + textBoxDesdekg.Text + "AND " + textBoxHastakg;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkHabilitado.Checked)
            {
                string agregado = "baja_fuera_de_servicio = 0 AND baja_vida_util = 0";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }
            //DESHABILITADAS
            //POR FECHAS

            iniciar();
            hacerQuery(query, dataGridView1);
        }

        private bool validaciones()
        {
            if (checkEncomienda.Checked)
            {
                if (textBoxDesdekg.TextLength != 0 && textBoxHastakg.TextLength != 0)
                {
                }
                else
                {
                    MessageBox.Show("Falta especificar rango de kilogramos para la encomienda", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }
            }

            if ((textFechaHasta.TextLength == 0 && textFechaDesde.TextLength == 0))
            {
            }
            else
            {
                if ((textFechaDesde.TextLength != 0 && textFechaHasta.TextLength != 0))
                {
                }
                else
                {
                    MessageBox.Show("Falta especificar rango de fechas para la busqueda", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (hayFiltros())
            {
                return false;
            }

            int a = Convert.ToInt32(textBoxDesdekg.Text);
            int b = Convert.ToInt32(textBoxHastakg.Text);
            if (a<0 || b<0)
            {
                MessageBox.Show("Los kilogramos especificados no son validos", "Fallo la busqueda", MessageBoxButtons.OK);
                return false;
            }
            
            if (a > b)
            {
                MessageBox.Show("El rango de kilogramos esta mal especificado", "Fallo la busqueda", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool hayFiltros()
        {
            return (txtMatricula.TextLength != 0 || txtModelo.TextLength != 0 || textServicio.TextLength != 0 || textFabricante.TextLength != 0 || textButacas.TextLength != 0 || checkPasaje.Checked || checkInhabilitado.Checked || checkHabilitado.Checked);
        }

    }
}
