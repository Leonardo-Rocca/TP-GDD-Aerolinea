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
namespace AerolineaFrba.Abm_Ciudad
{
    public partial class modificarEliminarCityForm : FormGenerico
    {
        int tipoDeForm; //1 modificar ,2 eliminar

        public modificarEliminarCityForm(string nombre, string nombreBoton, int tipo)
        {
            InitializeComponent();

            tipoDeForm = tipo;
            lbtitulo.Text = nombre;
            buttonGuardar.Text = nombreBoton;
            cargarComboSeleccion();
            resultadoFiltro.Visible = false;
        }

        public void cargarComboSeleccion()
        {
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM DBAS.ciudades ORDER BY 1");
            comboBoxCity.DataSource = dt.DefaultView;
            comboBoxCity.ValueMember = "nombre_ciudad";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (tipoDeForm == 1)
            {
                string cadena = comboBoxCity.Text;
                ModificarCiudadForm modify = new ModificarCiudadForm(cadena,this);
                modify.Show();
            }
            else
            {
                MessageBox.Show("Ciudad eliminada (dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide(); 

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref resultadoFiltro);
            lOrigen.Show();
        }

        private void resultadoFiltro_TextChanged(object sender, EventArgs e)
        {
            comboBoxCity.Text = resultadoFiltro.Text;
        }
    }
}