using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ListadoRol : Listado_Estadistico.ListadoMaestro
    {
        private string query = "select distinct nombre_rol FROM DBAS.roles";
        private Boolean yaTieneCondicion = false;

        public ListadoRol()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            radioButHabilitado.Checked = true;
            dataGridView2.DataSource = null;
            radioButInhabilitado.Checked = false;
            checkBox1.Checked = false;
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private Boolean hayAlgunFiltro()
        {
            return (radioButHabilitado.Checked || radioButInhabilitado.Checked || textBoxFiltro1.TextLength != 0 || textBoxFiltro2.TextLength != 0);
        }
    

        private void optEstadoAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButHabilitado.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButHabilitado.Checked = false;
                radioButInhabilitado.Checked = false;
            }

            if (!checkBox1.Checked && !radioButHabilitado.Checked && !radioButInhabilitado.Checked)
            {
                checkBox1.Checked = true;
            }
        }

        private void radioButInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButInhabilitado.Checked)
            {
                checkBox1.Checked = false;
            }
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!this.hayAlgunFiltro())
            {
                return;
            }


            query = query + " WHERE ";
            if (textBoxFiltro1.TextLength != 0)
            {
                string agregado = "nombre_rol" + " LIKE '%" + textBoxFiltro1.Text + "%'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textBoxFiltro2.TextLength != 0)
            {
                string agregado = "nombre_rol LIKE '_" + textBoxFiltro2.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (!checkBox1.Checked)
            {
                string agregado;
                if (radioButHabilitado.Checked)
                {
                    agregado = "habilitado_rol = 1";
                }
                else
                {
                    agregado = "habilitado_rol = 0";
                }

                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            iniciar();
            hacerQuery(query,dataGridView2);

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }


    }
}
