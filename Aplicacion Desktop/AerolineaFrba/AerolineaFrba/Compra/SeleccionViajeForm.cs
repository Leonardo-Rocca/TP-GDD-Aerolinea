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

            string query = "select id_viaje,fecha_salida,fecha_llegada_estimada,(precio_base_por_pasaje*s.porcentaje_arancel) as precio_pasaje ,precio_base_por_KG as precio_por_KG," +
            " s.tipo_servicio,v.matricula_aeronave" +
            " FROM dbas.rutas r,dbas.viajes v,dbas.ciudades co,dbas.ciudades cd ,dbas.aeronaves a, dbas.servicios s" +
            " WHERE habilitada_ruta = 1 AND r.codigo_ruta = v.codigo_ruta AND r.ciudad_origen_id=co.id_ciudad AND s.id_servicio = a.id_servicio AND " +
            "r.ciudad_destino_id = cd.id_ciudad AND co.nombre_ciudad = '" + txtCityOrigen.Text + "' AND cd.nombre_ciudad = '" + txtDestino.Text + "' AND a.matricula_aeronave = v.matricula_aeronave" +
            " AND datepart(year,fecha_salida) = '" + dateTimePicker1.Value.Year.ToString() +
            "' AND datepart(MONTH,fecha_salida) = '" + dateTimePicker1.Value.Month.ToString() +
            "' AND datepart(day,fecha_salida) = '" + dateTimePicker1.Value.Day.ToString() + "'";
           
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
                 
           int anterior= DateTime.Compare(DateTime.Parse(dateTimePicker1.Text), DateTime.Now);
           if (anterior < 0)
            {
                MessageBox.Show("La fecha de salida debe ser posterior al dia de hoy", "Viaje", MessageBoxButtons.OK);
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

        private void seleccionar(DataGridView dataGridView1)
        {
            string idViaje = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string fechaSalida = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string precioPasaje = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string precioKg = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string matriculaAeronave = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();

            Viaje vdammy = new Viaje(idViaje,fechaSalida,precioPasaje,precioKg,matriculaAeronave);
           // vdammy.matriculaAeronave = "BZD-177";
             (new compraForm(vdammy)).Show();
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
