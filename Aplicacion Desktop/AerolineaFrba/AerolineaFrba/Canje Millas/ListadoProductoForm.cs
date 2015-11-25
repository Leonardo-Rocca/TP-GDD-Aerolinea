using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class ListadoProductoForm : Listado_Estadistico.ListadoMaestro
    {
        public ListadoProductoForm()
        {
            InitializeComponent();
            string query = "select nombre_producto,valor_en_milas,stock from dbas.productos order by 2 desc";
            hacerQuery(query, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns.Count - 1) { completar(dataGridView1); this.Close(); }
        }

        private void completar(DataGridView dataGridView1)
        {
            string producto = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();

           llamada.setProducto(producto);
            llamada.Show();
        }

        public void setAnterior(CanjeForm anterior)
        {
            llamada = anterior;
        }

        public CanjeForm llamada { get; set; }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoProductoForm_Load(object sender, EventArgs e)
        {
            string query = "select nombre_producto,valor_en_milas valorEnMillas,stock from dbas.productos order by 2 ";
            hacerQuery(query, dataGridView1);
        }
    }
}
