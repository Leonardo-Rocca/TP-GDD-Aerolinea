using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoCiudad : Listado_Estadistico.ListadoMaestro
       {
        public ListadoCiudad()
        {
            InitializeComponent();
           
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            string query = "select distinct nombre_ciudad FROM DBAS.ciudades";
            hacerQuery(query, dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

             if (!this.hayAlgunFiltro())
            {
                return;
            }


             Boolean yaTieneCondicion = false;
             string query = "select distinct nombre_ciudad FROM DBAS.ciudades";
         
            query = query + " WHERE ";
           
            if (textBoxFiltro1.TextLength != 0)
            {
                string agregado = "nombre_ciudad" + " LIKE '%" + textBoxFiltro1.Text + "%'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textBoxFiltro2.TextLength != 0)
            {
                string agregado = "nombre_ciudad LIKE '_" + textBoxFiltro2.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            hacerQuery(query,dataGridView2);
        }

    private bool hayAlgunFiltro()
        {
          return (textBoxFiltro1.TextLength != 0 || textBoxFiltro2.TextLength != 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
            string query = "select distinct nombre_ciudad FROM DBAS.ciudades";
            hacerQuery(query, dataGridView2);
        }

private void iniciar()
{
          textBoxFiltro1.Text = "";
          textBoxFiltro2.Text = "";
}

private void butAceptar_Click(object sender, EventArgs e)
{
    obtenerRespuesta(dataGridView2);
    this.Close();
}

private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
        if (dataGridView2.CurrentCell.ColumnIndex == dataGridView2.Columns.Count - 1) { obtenerRespuesta(dataGridView2); this.Close(); }
}

private void buttonCancelar_Click(object sender, EventArgs e)
{
    this.Close();
}



       }

}
