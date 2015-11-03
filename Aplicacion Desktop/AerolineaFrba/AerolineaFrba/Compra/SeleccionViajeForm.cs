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
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Dominio;
namespace AerolineaFrba.Compra
{
    public partial class SeleccionViajeForm : FormGenerico
    {
        public SeleccionViajeForm()
        {
            InitializeComponent();
            txtCityOrigen.ReadOnly = true;
            txtDestino.ReadOnly = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCityOrigen.Text = "";
            txtDestino.Text="";
            this.Hide();
        }

        private void btsOringen_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtCityOrigen);
            lOrigen.Show();
        }

        private void btsDestino_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtDestino);
            lOrigen.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(!validarCamposCompletos())return;

            string query = "select id_viaje, matricula_aeronave from dbas.rutas r,dbas.viajes v WHERE r.codigo_ruta = v.codigo_ruta";

            hacerQuery(query, dgvViaje);

        }

        private bool validarCamposCompletos()
        {
            if (txtCityOrigen.Text == ""){
                MessageBox.Show("Faltan completar Campos","" , MessageBoxButtons.OK);
                return false;
            }
            if (txtDestino.Text == ""){
                MessageBox.Show("Faltan completar Campos", "", MessageBoxButtons.OK);
                return false;
            } 

            //VALIDAR FECHA
            return true;

        }

        private void dgvViaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViaje.CurrentCell.ColumnIndex == dgvViaje.Columns.Count - 1) ;
                    seleccionar(dgvViaje);
            
        }

        private void seleccionar(DataGridView dgvViaje)
        {
            Viaje vdammy = new Viaje();
            vdammy.matriculaAeronave = "BZD-177";
             (new compraForm(vdammy)).Show();//mandar viaje
             txtCityOrigen.Text = "";
             txtDestino.Text = "";
            this.Hide();
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

    }
}
