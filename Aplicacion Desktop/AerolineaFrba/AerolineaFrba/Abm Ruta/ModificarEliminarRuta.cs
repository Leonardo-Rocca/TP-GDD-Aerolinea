﻿using System;
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
            vaciarTextos();
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

            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
                MessageBox.Show("Ruta Eliminada", "Baja ", MessageBoxButtons.OKCancel);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Baja ", MessageBoxButtons.OKCancel);

            }

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
                query = query + " AND codigo_ruta = " + txtCodigo.Text;
            }

            if (txtCOrigen.TextLength != 0)
            { 
                query = query + " AND ciudad_Origen = " + txtCOrigen.Text;
            }

            if (txtCDestino.TextLength != 0)
            {
                query = query + " AND ciudad_Destino = " + txtCDestino.Text;
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
          //  MessageBox.Show(query, " la busqueda", MessageBoxButtons.OK); 
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
                if (tipoDeForm == 1)
                {
                    completar(dataGridView2);
                }
                else
                {
                    eliminarRuta();
                }
            }
        }

        private void completar(DataGridView dataGridView1)
        {

            string codigo_ruta = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string ciudad_Origen = dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            string ciudad_Destino = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string tipo_servicio = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string precio_base_por_KG = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string precio_base_por_pasaje = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string porcentaje_arancel = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();

        /*    string fabricante = ((new ConexionSQL()).cargarTablaSQL("select distinct nombre_fabricante FROM DBAS.fabricantes where id_fabricante = " + idFabricante)).Rows[0][0].ToString();
            string tipoServicio = ((new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios where id_servicio = " + idTipoServicio)).Rows[0][0].ToString();
            DataTable dt = ((new ConexionSQL()).cargarTablaSQL("select count(b1.id_butaca),count(b2.id_butaca),count(distinct b1.piso_butaca) from dbas.butacas b1, dbas.butacas b2 where b1.tipo_butaca like 'Pasillo' and b2.tipo_butaca like 'Ventanilla' and b1.matricula_aeronave like '" + matricula + "' and b2.matricula_aeronave like '" + matricula + "'"));
            string cantPasillo = dt.Rows[0][0].ToString();
            string cantVentanila = dt.Rows[0][1].ToString();
            string cantPisos = dt.Rows[0][2].ToString();

            this.iniciar();
            this.Hide();
            this.llamada.Show();*/
        }

    }
}
