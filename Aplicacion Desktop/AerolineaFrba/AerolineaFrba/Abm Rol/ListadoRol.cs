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
            radioButHabilitado.Checked = true;
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private Boolean hayAlgunFiltro()
        {
            return (hayAlgunFiltroGeneral() || hayAlgunFiltroParticular());
        }
        private Boolean hayAlgunFiltroParticular()
        {
            return (radioButHabilitado.Checked || radioButInhabilitado.Checked);
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
        }

        private void radioButInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButInhabilitado.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        public void limpiarObjetosPropios()
        {
            checkBox1.Checked = false;
            radioButHabilitado.Checked = true;
            radioButInhabilitado.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarObjetosPropios();
            limpiarObjetosGenerales();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!this.hayAlgunFiltro())
            {
                return;
            }

            string argregadoAlQuery = "";
            if (!checkBox1.Checked)
            {
                yaTieneCondicion = true;
                if (radioButHabilitado.Checked)
                {
                    argregadoAlQuery = "habilitado_rol = 1";
                }
                else
                {
                    argregadoAlQuery = "habilitado_rol = 0";
                }
            }
            armarQueryCompleja(query, argregadoAlQuery,yaTieneCondicion);

        }

        private void armarQueryCompleja(string query, string agregadoAlQuery, bool yaTieneCondicion)
        {
            query = query + " WHERE ";
            if (filtro1.TextLength != 0)
            {
                string agregado = "nombre_rol" + " LIKE '%" + filtro1.Text + "%'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (filtro2.TextLength != 0)
            {
                string agregado = "nombre_rol LIKE '_" + filtro2.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;

            }

            if (agregadoAlQuery.Length != 0) 
            {
                armarQueryCompleja(ref query, agregadoAlQuery, yaTieneCondicion);
            }

            limpiarObjetosGenerales();
            limpiarObjetosPropios();
            hacerQuery(query);
        }


    }
}
