﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {

        public List<String> pasajes = new List<String>();
        public Devolucion()
        {
            InitializeComponent();
            iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.iniciar();
            this.Hide();
        }

        private void iniciar()
        {
            textBox0.Text = "";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateFecha.Value = DateTime.Today;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            pasajes.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            pasajes.Remove(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }
            cancelar();
        }

        private bool validaciones()
        {
            if (textBox0.Text == "" || textBox4.Text == "" || textBox2.Text=="" || textBox3.Text=="" || comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Debe completar todos los campos", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void cancelar()
        {
            DataTable cancelacion = new DataTable("cancelacion");
            cancelacion.Columns.Add("Id", typeof(int));
            string pnr = textBox2.Text;
            string idCli = ((new ConexionSQL()).cargarTablaSQL("select distinct id_persona from dbas.personas where dni_persona = '" + textBox0.Text+"'")).Rows[0][0].ToString();
            string motivo = textBox3.Text;
            string encomienda = textBox4.Text;
            string comando = "insert into DBAS.PasajesCancelados(id_compra_PNR,id_cliente, motivo_cancelacion, codigo_pasaje,codigo_encomienda) select distinct " + pnr + ","+idCli+",'"+motivo+"',codigo_pasaje,"+encomienda+" FROM DBAS.pasajes WHERE id_cliente = "+idCli +" and codigo_pasaje IN ( ";

            int i = 1;
            int cant = pasajes.Count;
            foreach (String elemento in pasajes)
            {
                if (i < cant)
                {
                    comando = comando + " '" + elemento + "',";
                }
                else
                {
                    comando = comando + " '" + elemento + "')";
                }
                i++;
                
            }

            try
            {
                (new ConexionSQL()).ejecutarComandoSQL(comando);
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Message.StartsWith("Hay un codigo de pasaje invalido"))
                {
                    MessageBox.Show("Hay un codigo de pasaje invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                    return;
                }

                if (sqlEx.Message.StartsWith("Hay un codigo de encomienda invalido"))
                {
                    MessageBox.Show("Hay un codigo de encomienda invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                    return;
                }
                if (sqlEx.Message.StartsWith("El PNR ingresado es incorrecto"))
                {
                    MessageBox.Show("El PNR ingresado es incorrecto", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                    return;
                }


                throw new Exception();
            }

            MessageBox.Show("Cancelacion exitosa", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);


           }

    }
}
