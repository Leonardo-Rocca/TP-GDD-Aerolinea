﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ListadoAeronave : Listado_Estadistico.ListadoMaestro
    {
        public _Viaje viaje;
        public _Aeronave modifAnterior;
        public Form llamada;

        public ListadoAeronave()
        {
            InitializeComponent();
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM  DBAS.servicios");
            comboBoxServicio.DataSource = dt.DefaultView;
            viaje = null;
            comboBoxServicio.ValueMember = "tipo_servicio"; 
            iniciar();
        }

        private void iniciar()
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textButacas.Text = ""; 
            textFabricante.Text = "";
            comboBoxServicio.Text = "";
            textBoxDesdekg.Text = "";
            textBoxHastakg.Text = "";
            textBoxHastakg.Visible = false;
            textBoxDesdekg.Visible = false;
            checkEncomienda.Checked = false;
            checkHabilitado.Checked = false;
            checkInhabilitado.Checked = false;
            checkPasaje.Checked = false;
            label4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            comboBoxServicio.SelectedIndex = -1;      
        }

        private void ListadoAeronave_Load(object sender, EventArgs e)
        {
            string query = "select matricula_aeronave,numero_aeronave,modelo_aeronave,kg_disponible_encomienda,id_fabricante,id_servicio FROM DBAS.aeronaves a";
            hacerQuery(query, dataGridView1);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkEncomienda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEncomienda.Checked)
            {
                checkPasaje.Checked = false;
                textBoxHastakg.Visible = true;
                label4.Visible = true;
                label10.Visible = true;
                textBoxDesdekg.Visible = true;
                label9.Visible = true;
            }else
            {
                textBoxHastakg.Visible = false;
                textBoxDesdekg.Visible = false;
                label9.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                textBoxHastakg.Text = "";
                textBoxDesdekg.Text="";
            }
        }

        private void checkPasaje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPasaje.Checked)
            {
                checkEncomienda.Checked = false;
                textBoxHastakg.Visible = false;
                label4.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBoxDesdekg.Text = "";
                textBoxHastakg.Text = "";
                textBoxHastakg.Visible = false;
                textBoxDesdekg.Visible = false;
                textBoxHastakg.Text = "";
            }
        }

        private void checkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHabilitado.Checked)
            {
               checkInhabilitado.Checked = false;
            }
        }

        private void checkInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInhabilitado.Checked)
            {
                checkHabilitado.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!validaciones())
            {
                return;
            }

            string query = "select matricula_aeronave,numero_aeronave,modelo_aeronave,kg_disponible_encomienda,id_fabricante,id_servicio FROM DBAS.aeronaves a";
            Boolean yaTieneCondicion = false;
            query = query + " WHERE ";

            if (checkHabilitado.Checked || (!checkHabilitado.Checked && !checkInhabilitado.Checked))
            {
                string agregado = "(fecha_reinsercion <= GETDATE() or fecha_reinsercion IS NULL) AND fecha_baja_servicio_definitiva is NULL";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkInhabilitado.Checked)
            {
                string agregado = "fecha_reinsercion IS NOT NULL AND fecha_baja_servicio_definitiva IS NOT NULL";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (txtMatricula.TextLength != 0)
            {
                string agregado = "a.matricula_aeronave LIKE '" + txtMatricula.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (txtModelo.TextLength != 0)
            {
                string agregado = "a.modelo_aeronave LIKE '" + txtModelo.Text + "'";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textFabricante.TextLength != 0)
            {
                string agregado = "a.id_Fabricante = (select id_fabricante from DBAS.fabricantes WHERE nombre_fabricante LIKE '" + textFabricante.Text + "')";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (textButacas.TextLength != 0)
            {
                string agregado = "a.cantidad_butacas < " + textButacas.Text;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkPasaje.Checked)
            {
                //hay que chequear
                string agregado = "p.encomienda_cliente_KG = 0";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (checkEncomienda.Checked)
            {
                string agregado = "kg_disponible_encomienda BETWEEN " + textBoxDesdekg.Text + "AND " + textBoxHastakg.Text;
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            if (comboBoxServicio.SelectedIndex != -1)
            {
                string agregado = "a.id_servicio = (select id_servicio from DBAS.servicios WHERE tipo_servicio LIKE '" + comboBoxServicio.Text + "')";
                armarQueryCompleja(ref query, agregado, yaTieneCondicion);
                yaTieneCondicion = true;
            }

            //POR FECHAS

            hacerQuery(query, dataGridView1);
        }

        private bool validaciones()
        {
            if (checkEncomienda.Checked)
            {
                if (textBoxDesdekg.TextLength != 0 && textBoxHastakg.TextLength != 0)
                {
                }
                else
                {
                    MessageBox.Show("Falta especificar rango de kilogramos para la encomienda", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }
            }


            if (!hayFiltros())
            {
                return false;
            }

            if (checkEncomienda.Checked)
            {
                int a = Convert.ToInt32(textBoxDesdekg.Text);
                int b = Convert.ToInt32(textBoxHastakg.Text);
                if (a < 0 || b < 0)
                {
                    MessageBox.Show("Los kilogramos especificados no son validos", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }

                if (a > b)
                {
                    MessageBox.Show("El rango de kilogramos esta mal especificado", "Fallo la busqueda", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }

        private bool hayFiltros()
        {
            return (txtMatricula.TextLength != 0 || txtModelo.TextLength != 0 || comboBoxServicio.SelectedIndex != -1 || textFabricante.TextLength != 0 || textButacas.TextLength != 0 || checkPasaje.Checked || checkInhabilitado.Checked || checkHabilitado.Checked || checkEncomienda.Checked);
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            obtenerRespuesta(dataGridView1);
        }

        public void cargarModificado(_Aeronave form)
        {
            modifAnterior = form;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns.Count - 1) { completar(dataGridView1); }
        }

        private void completar(DataGridView dataGridView1)
        {
            string matricula = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string modelo = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string idTipoServicio = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string idFabricante = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string kg = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string fabricante = ((new ConexionSQL()).cargarTablaSQL("select distinct nombre_fabricante FROM DBAS.fabricantes where id_fabricante = " + idFabricante)).Rows[0][0].ToString();
            string tipoServicio = ((new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios where id_servicio = " + idTipoServicio)).Rows[0][0].ToString();
            string cantPasillo = ((new ConexionSQL()).cargarTablaSQL("select count(id_butaca) from dbas.butacas where tipo_butaca like 'Pasillo' and matricula_aeronave like '" + matricula + "'")).Rows[0][0].ToString();
            string cantVentanila = ((new ConexionSQL()).cargarTablaSQL("select count(id_butaca) from dbas.butacas where tipo_butaca like 'Ventanilla' and matricula_aeronave like '" + matricula + "'")).Rows[0][0].ToString();
            string cantPisos = ((new ConexionSQL()).cargarTablaSQL("select count(distinct piso_butaca) from dbas.butacas where matricula_aeronave like '" + matricula + "'")).Rows[0][0].ToString(); ;

            if (viaje != null)
            {
                viaje.textBoxMatricula.Text = matricula;
                viaje = null;
            }
            else
            {
                modifAnterior.textBox1.Text = matricula;
                modifAnterior.textBox1.ReadOnly = true;
                modifAnterior.textBox2.Text = modelo;
                modifAnterior.textBox3.Text = cantPisos;
                modifAnterior.textBox4.Text = cantPasillo;
                modifAnterior.textBox5.Text = cantVentanila;
                modifAnterior.textBox6.Text = kg;
                modifAnterior.combo1.Text = tipoServicio;
                modifAnterior.combo2.Text = fabricante;
            }

            this.iniciar();
            this.Hide();
            this.llamada.Show();
        }

        public void setAnterior(Form anterior) 
        {
            llamada = anterior;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void setViaje(_Viaje v)
        {
            viaje = v;
        }
    }
}
