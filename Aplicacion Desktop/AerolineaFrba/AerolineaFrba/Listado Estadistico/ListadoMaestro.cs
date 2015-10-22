using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoMaestro : Form
    {
        public Form formularioAnterior;
     

        public ListadoMaestro()
        {
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFiltro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro1_TextChanged(object sender, EventArgs e)
        {

        }

        public void armarQueryCompleja(ref string queryBase, string agregado, bool yaTieneCondicion)
        {
            if (yaTieneCondicion)
                queryBase += " AND " + agregado;
            else
            {
                queryBase += agregado;
            }
        }

        public void hacerQuery(string query, DataGridView dataGrid) 
        {
            ConexionSQL conn = new ConexionSQL();
            DataTable dt = conn.cargarTablaSQL(query);
            dataGrid.DataSource = dt;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados en la consulta", "Fallo la busqueda", MessageBoxButtons.OK);
                dataGrid.DataSource = null;

            }

            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }

        private void ListadoMaestro_Load(object sender, EventArgs e)
        {

        }

        public void setFormAnteriorSup(Form formulario) {
            this.formularioAnterior = formulario;
        }

    }
}
