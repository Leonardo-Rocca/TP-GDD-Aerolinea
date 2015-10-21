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

        public TextBox filtro1;
        public TextBox filtro2;

        public ListadoMaestro()
        {
            InitializeComponent();
            filtro1 = textBoxFiltro1;
            filtro2 = textBoxFiltro2;
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

       

        public void limpiarObjetosGenerales()
        {
            textBoxFiltro1.Text = "";
            textBoxFiltro2.Text = "";
            dataGridView1.DataSource = null;
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

        public Boolean hayAlgunFiltroGeneral()
        {
            return (textBoxFiltro1.TextLength != 0 || textBoxFiltro2.TextLength != 0);
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

        public void hacerQuery(string query) 
        {
            ConexionSQL conn = new ConexionSQL();
            DataTable dt = conn.cargarTablaSQL(query);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados en la consulta", "Fallo la busqueda", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;

            }
        }
    }
}
