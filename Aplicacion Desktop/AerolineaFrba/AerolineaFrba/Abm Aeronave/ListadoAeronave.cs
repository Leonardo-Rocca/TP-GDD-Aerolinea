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

        public ListadoAeronave()
        {
            InitializeComponent();
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM  DBAS.servicios");
            comboBoxServicio.DataSource = dt.DefaultView; 
            comboBoxServicio.ValueMember = "tipo_servicio"; 
            iniciar();
        }

        private void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textButacas.Text = ""; 
            textFabricante.Text = "";
            textFechaDesde.Text = "";
            comboBoxServicio.Text = "";
            textBoxDesdekg.Text = "";
            textBoxHastakg.Text = "";
            textBoxHastakg.Visible = false;
            textBoxDesdekg.Visible = false;
            checkEncomienda.Checked = false;
            checkHabilitado.Checked = false;
            checkInhabilitado.Checked = false;
            checkPasaje.Checked = false;
            label4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            comboBoxServicio.SelectedIndex = -1;      
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

            string query = "select distinct matricula_aeronave,numero_aeronave,modelo_aeronave FROM DBAS.aeronaves a, DBAS.pasajesEncomiendas p";
            Boolean yaTieneCondicion = false;
            query = query + " WHERE ";
            if (txtMatricula.TextLength != 0)
            {
                string agregado = "a.matricula_aeronave LIKE '" + txtMatricula.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (txtModelo.TextLength != 0)
            {
                string agregado = "a.modelo_aeronave LIKE '" + txtModelo.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textFabricante.TextLength != 0)
            {
                string agregado = "a.id_Fabricante = (select id_fabricante from DBAS.fabricantes WHERE nombre_fabricante LIKE '" + textFabricante.Text + "')";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textButacas.TextLength != 0)
            {
                string agregado = "a.cantidad_butacas < " + textButacas.Text;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkPasaje.Checked)
            {
                string agregado = "p.encomienda_cliente_KG = 0";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkEncomienda.Checked)
            {
                string agregado = "kg_disponible_encomienda BETWEEN " + textBoxDesdekg.Text + "AND " + textBoxHastakg.Text;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkHabilitado.Checked)
            {
                string agregado = "baja_fuera_de_servicio = 0 AND baja_vida_util = 0";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkInhabilitado.Checked)
            {
                string agregado = "baja_fuera_de_servicio = 1 OR baja_vida_util = 1";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (comboBoxServicio.SelectedIndex != -1)
            {
                string agregado = "a.id_servicio = (select id_servicio from DBAS.servicios WHERE tipo_servicio LIKE '" + comboBoxServicio.Text + "')";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            //POR FECHAS

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

            if (!hayFiltros())
            {
                return false;
            }

            if (checkEncomienda.Checked)
            {
                int a = Convert.ToInt32(textBoxDesdekg.Text);
                int b = Convert.ToInt32(textBoxHastakg.Text);
                if (a < 0 || b < 0)
                {
                    MessageBox.Show("Los kilogramos especificados no son validos", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }

                if (a > b)
                {
                    MessageBox.Show("El rango de kilogramos esta mal especificado", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }

        private bool hayFiltros()
        {
            return (txtMatricula.TextLength != 0 || txtModelo.TextLength != 0 || comboBoxServicio.SelectedIndex != -1 || textFabricante.TextLength != 0 || textButacas.TextLength != 0 || checkPasaje.Checked || checkInhabilitado.Checked || checkHabilitado.Checked || checkEncomienda.Checked);
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            obtenerRespuesta(dataGridView1);
        }

    }
}
