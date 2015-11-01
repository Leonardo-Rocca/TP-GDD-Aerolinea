using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Dominio;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ModificarEliminarRuta : FormGenerico
    {
        int tipoDeForm; //1 modificar ,2 eliminar

        public ModificarEliminarRuta(int tipo)
        {
            InitializeComponent();

            inicializar();
            tipoDeForm = tipo;
            if (tipo == 1)
            {
                lbTitle.Text = "Modificar" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text+ "modificar:";
            }
            else
            {
                lbTitle.Text = "Eliminar" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text + "eliminar:";
            }

        }


        private void inicializar()
        {
            chkListaServicios.Items.Clear();
            chkListaServicios.Items.Insert(0, "Primera Clase");
            chkListaServicios.Items.Insert(1, "Ejecutivo");
            chkListaServicios.Items.Insert(2, "Turista");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (chkListaServicios.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Falta elegir tipos de servicio", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (txtCDestino.Text.Equals(string.Empty) || txtCodigo.Text.Equals(string.Empty) || txtCOrigen.Text.Equals(string.Empty) || txtPasajeLimInferior.Text.Equals(string.Empty) || txtPasajeSuperior.Text.Equals(string.Empty) || txtPKGLimInferior.Text.Equals(string.Empty) || txtPKGSuperior.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe completar todos los campos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void eliminarRuta()
        {
            
        }

        private void btsOringen_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtCOrigen);
            lOrigen.Show();
        }

        private void btsDestino_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtCDestino);
            lOrigen.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string query = "select distinct codigo_ruta, ciudad_Origen ,ciudad_Destino ,precio_base_por_pasaje ,precio_base_por_KG ,tipo_servicio, porcentaje_arancel FROM DBAS.caracteristicasRutas";

            query = query + " WHERE 1 = 1 ";
 
            if (txtCodigo.TextLength != 0)
            {
                query = query + "AND codigo_ruta = " + txtCodigo.Text;
            }

            if (txtCOrigen.TextLength != 0)
            {
                query = query + "AND ciudad_Origen = " + txtCOrigen.Text;
            }

            if (txtCDestino.TextLength != 0)
            {
                query = query + "AND ciudad_Destino = " + txtCDestino.Text;
            }

            if (txtPasajeLimInferior.TextLength != 0)
            {
                query = query + "AND precio_base_por_pasaje > " + txtPasajeLimInferior.Text;
            }

            if (txtPasajeSuperior.TextLength != 0)
            {
                query = query + "AND precio_base_por_pasaje < " + txtPasajeSuperior.Text;
            }

            if (txtPKGLimInferior.TextLength != 0)
            {
                query = query + "AND precio_base_por_KG > " + txtPKGLimInferior.Text;  
            }

            if (txtPKGSuperior.TextLength != 0)
            {
                query = query + "AND precio_base_por_KG < " + txtPKGSuperior.Text;
            }

            if (chkListaServicios.CheckedItems.Count != 0 ){

                query = query + "AND tipo_servicio IN (";
                foreach (Object service in chkListaServicios.CheckedItems)
                {
                    query = query + "'"+ service.ToString()+"',"; 
                }
                query = query + "'lalala')";  //esto se puede cambiar por un substring
            }

            //--sacada del listador generico--
            MessageBox.Show(query, " la busqueda", MessageBoxButtons.OK); 
            hacerQuery(query, dataGridView2);
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

        private void butCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
            this.Hide();
        }

    }
}
