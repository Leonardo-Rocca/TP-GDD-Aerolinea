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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoMaestro : Form
    {
        public FormGenerico formularioAnterior;
       
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
            if (dataGrid.DataSource != null) dataGrid.Columns.Remove("seleccionar"); 

            dataGrid.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados en la consulta", "Fallo la busqueda", MessageBoxButtons.OK);
                dataGrid.DataSource = null;

            }
            else
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.Name = "Seleccionar";
                boton.HeaderText = "Seleccionar";
                boton.Text = "Seleccionar";
                boton.UseColumnTextForButtonValue = true;
                dataGrid.Columns.Insert(dataGrid.Columns.Count, boton);
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void ListadoMaestro_Load(object sender, EventArgs e)
        {

        }

        public void setFormAnteriorSup(FormGenerico formulario) {
            this.formularioAnterior = formulario;
        }

        public void obtenerRespuesta(DataGridView dataGrid)
        {
            string contenido = dataGrid[dataGrid.CurrentCell.ColumnIndex-1, dataGrid.CurrentCell.RowIndex].Value.ToString();
         
        //    this.formularioAnterior.setBufferSeleccion( contenido);
            ((TextBox)formularioAnterior.Controls[buffer.Name]).Text = contenido;
            this.Hide();
       //    formularioAnterior.obtenerResultado(contenido,this);
        }
        public void setBuffer(ref TextBox bufferRespuesta)
        {
            this.buffer = bufferRespuesta;
        }

        public TextBox buffer;// { get; set; }
    }
}
