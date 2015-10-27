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

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Boolean yaTieneCondicion = false;
            string query = "select distinct nombre_ciudad FROM DBAS.ciudades";
            if (textBoxFiltro1.TextLength == 0 && textBoxFiltro2.TextLength == 0)
            {
                hacerQuery(query, dataGridView2);
                return;
            }


             if (!this.hayAlgunFiltro())
            {
                return;
            }

           
      
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
            if (dataGridView2.DataSource != null) dataGridView2.Columns.Remove("Seleccionar");
            iniciar();
        }

private void iniciar()
{
          textBoxFiltro1.Text = "";
          textBoxFiltro2.Text = "";
          dataGridView2.DataSource = null;
}

private void butAceptar_Click(object sender, EventArgs e)
{
    obtenerRespuesta(dataGridView2);
    this.Close();
}

private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
  
    {
        if (dataGridView2.CurrentCell.ColumnIndex == dataGridView2.Columns.Count - 1) { obtenerRespuesta(dataGridView2); }
    }
    }



       }

}
