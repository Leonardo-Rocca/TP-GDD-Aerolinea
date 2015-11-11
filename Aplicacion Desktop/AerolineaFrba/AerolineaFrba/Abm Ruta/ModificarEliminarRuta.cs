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
using AerolineaFrba.Generacion_Viaje;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ModificarEliminarRuta : FormGenerico
    {
        int tipoDeForm; //1 modificar ,2 eliminar
        Generar_Viaje formAuxiliar;

        public ModificarEliminarRuta(int tipo)
        {
            InitializeComponent();

            inicializar();
            tipoDeForm = tipo;
            if (tipo == 1)
            {
                lbTitle.Text = "Modificar" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text+ "modificar:";
                return;
            }
            if (tipo == 3)
            {
                lbTitle.Text = "Listado" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text + "viajar:";
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
            vaciarTextos();
            cargarTablacompleta();

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
            string codigo_ruta = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string query = "execute dbas.bajaRuta '" + codigo_ruta + "'";
        //    ConexionSQL conn = new ConexionSQL();

            if (MessageBox.Show("¿Realmente desea dar de baja la ruta " + codigo_ruta + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
                MessageBox.Show("Ruta Eliminada", "Baja ", MessageBoxButtons.OKCancel);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Baja ", MessageBoxButtons.OK);
                if (MessageBox.Show("¿desea cancelar los pasajes de la ruta: " + codigo_ruta + "?(falta probar)", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                  return;
                }
                string queryBajaPasajes = "execute DBAS.bajaRutaYCancelarPasajes '" + codigo_ruta + "'";
                (new ConexionSQL()).cargarTablaSQL(queryBajaPasajes);
            }
            inicializar();
            this.Hide();
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
            if (!validacionesExtras()) return;


            string query = "select distinct codigo_ruta, ciudad_Origen ,ciudad_Destino ,precio_base_por_pasaje ,precio_base_por_KG ,tipo_servicio, porcentaje_arancel FROM DBAS.caracteristicasRutas";

            query = query + " WHERE 1 = 1 ";
 
            if (txtCodigo.TextLength != 0)
            {
                query = query + " AND codigo_ruta = " + txtCodigo.Text;
            }

            if (txtCOrigen.TextLength != 0)
            { 
                query = query + " AND ciudad_Origen Like '" + txtCOrigen.Text+ "'";
            }

            if (txtCDestino.TextLength != 0)
            {
                query = query + " AND ciudad_Destino Like '" + txtCDestino.Text+ "'";
            }

            if (txtPasajeLimInferior.TextLength != 0)
            {
                query = query + " AND precio_base_por_pasaje > " + txtPasajeLimInferior.Text;
            }

            if (txtPasajeSuperior.TextLength != 0)
            {
                query = query + " AND precio_base_por_pasaje < " + txtPasajeSuperior.Text;
            }

            if (txtPKGLimInferior.TextLength != 0)
            {
                query = query + " AND precio_base_por_KG > " + txtPKGLimInferior.Text;  
            }

            if (txtPKGSuperior.TextLength != 0)
            {
                query = query + " AND precio_base_por_KG < " + txtPKGSuperior.Text;
            }

            if (chkListaServicios.CheckedItems.Count != 0 ){

                query = query + " AND tipo_servicio IN (";
                foreach (Object service in chkListaServicios.CheckedItems)
                {
                    query = query + "'"+ service.ToString()+"',"; 
                }
                query = query + "'lalala')";  //esto se puede cambiar por un substring
            }

            //--sacada del listador generico--
           // MessageBox.Show(query, " la busqueda", MessageBoxButtons.OK); 
            hacerQuery(query, dataGridView2);
        }

        private bool validacionesExtras()
        {
            int a;
            Double  b, c, d, e;
            if (txtCodigo.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(txtCodigo.Text);

                }
                catch
                {
                    MessageBox.Show("El codigo no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                    return false;
                }

                if (a < 1)
                {
                    MessageBox.Show("El codigo no es valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (txtPKGLimInferior.Text != "")
            {
                try
                {
                    b = Convert.ToDouble(txtPKGLimInferior.Text);

                }
                catch
                {
                    MessageBox.Show("El limite inferior del precio base por kg no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                    return false;
                }

                if (b < 0)
                {
                    MessageBox.Show("El limite inferior del precio por kg no es valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            if(txtPKGSuperior.Text != ""){
            try
            {
                c = Convert.ToDouble(txtPKGSuperior.Text);

            }
            catch
            {
                MessageBox.Show("El limite superior del precio base por kg no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (c < 0)
            {
                MessageBox.Show("El limite superior del precio base por kg no es valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            }

            if (txtPasajeLimInferior.Text != "")
            {
                try
                {
                    d = Convert.ToDouble(txtPasajeLimInferior.Text);

                }
                catch
                {
                    MessageBox.Show("El limite inferior del precio base por pasaje no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                    return false;
                }

                if (d < 0)
                {
                    MessageBox.Show("El limite inferior del precio base por pasaje no es valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }


            if (txtPasajeSuperior.TextLength != 0)
            {
                try
                {
                    e = Convert.ToDouble(txtPasajeSuperior.Text);

                }
                catch
                {
                    MessageBox.Show("El limite superior del precio base por pasaje no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                    return false;
                }

                if (e < 0)
                {
                    MessageBox.Show("El limite superior del precio base por pasaje no es valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
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

        private void vaciarTextos()
        {
            txtCodigo.Text = "";
            txtCOrigen.Text = "";
            txtCDestino.Text = "";
            txtPasajeLimInferior.Text = "";
            txtPasajeSuperior.Text = "";
            txtPKGLimInferior.Text = "";
            txtPKGSuperior.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == dataGridView2.Columns.Count - 1) {
                if (tipoDeForm == 1 || tipoDeForm == 3)
                {
                    completar(dataGridView2);
                }
                else
                {
                    eliminarRuta();
                }
            }
        }

        private void completar(DataGridView dataGridView2)
        {
            string codigo_ruta = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();

            string ciudad_Origen = dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string ciudad_Destino = dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string tipo_servicio = dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string precio_base_por_KG = dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string precio_base_por_pasaje = dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string porcentaje_arancel = dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString();

            string query = "select tipo_servicio FROM DBAS.caracteristicasRutas WHERE codigo_ruta = "+codigo_ruta ;
            ConexionSQL conn = new ConexionSQL();
            DataTable dt = conn.cargarTablaSQL(query);

           List<string> servicios = new List<string>();

           for (int i = 0; i <= (dt.Rows.Count- 1); i++)
           {
               servicios.Add(dt.Rows[i][ 0].ToString());
           }

            Ruta aModificar = new Ruta(Convert.ToInt32(codigo_ruta), ciudad_Origen, ciudad_Destino, precio_base_por_pasaje, precio_base_por_KG, tipo_servicio, porcentaje_arancel,servicios);


            this.inicializar();
            this.Hide();

            if(tipoDeForm==1){
              crearRutaForm modify =new crearRutaForm(1);
                            modify.cargarRuta(aModificar);
                            modify.Show();
                }
            if(tipoDeForm==3){
                formAuxiliar.cargarRuta(aModificar);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void cargarTablacompleta()
        {
            string query = "select distinct codigo_ruta, ciudad_Origen ,ciudad_Destino ,precio_base_por_pasaje ,precio_base_por_KG ,tipo_servicio, porcentaje_arancel FROM DBAS.caracteristicasRutas";
            hacerQuery(query, dataGridView2); 
        }

        private void ModificarEliminarRuta_Load(object sender, EventArgs e)
        {
              cargarTablacompleta();
        }

        public void setFormAuxiliar(Generacion_Viaje.Generar_Viaje gv)
        {
            formAuxiliar = gv;
        }
    }
}
