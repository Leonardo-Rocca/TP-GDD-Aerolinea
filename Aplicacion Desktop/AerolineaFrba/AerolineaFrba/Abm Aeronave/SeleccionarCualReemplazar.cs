using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Listado_Estadistico;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class SeleccionarCualReemplazar : ListadoMaestro
    {
        reemplazoCancelarPasajes anterior;
        public SeleccionarCualReemplazar(DataTable dt, reemplazoCancelarPasajes ant)
        {
            InitializeComponent();
            anterior = ant;
            if (dataGridView1.DataSource != null) dataGridView1.Columns.Remove("seleccionar");
            dataGridView1.DataSource = dt;
        }

        private void SeleccionarCualReemplazar_Load(object sender, EventArgs e)
        {
            
           
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.Name = "Seleccionar";
            boton.HeaderText = "Seleccionar";
            boton.Text = "Seleccionar";
            boton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, boton);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns.Count - 1) {
                string matricula = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                anterior.modificaPorEsta(matricula);
                this.Close();
            }

          

        }
    }
}
