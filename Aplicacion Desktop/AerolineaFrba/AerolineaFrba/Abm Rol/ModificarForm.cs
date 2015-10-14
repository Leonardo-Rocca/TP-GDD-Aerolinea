﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarForm : Form
    {
        int tipoDeForm; //1=modificar 2=eliminar

        public ModificarForm()
        {
            InitializeComponent(); 
            comboBoxRol.Items.Insert(0, "Usuario");
            comboBoxRol.Items.Insert(1, "El que mueve la papota");
            
        }

        public ModificarForm(string nombre,string nombreBoton,int tipo)
        {
            InitializeComponent();
            comboBoxRol.Items.Insert(0, "Usuario");
            comboBoxRol.Items.Insert(1, "El que mueve la papota");
            buttonGuardar.Text = nombreBoton;
            label1.Text = nombre;
            tipoDeForm = tipo;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.Text.Equals(string.Empty))
            {
                MessageBox.Show("No seleccionó ningun Rol", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tipoDeForm==1){
            string cadena = comboBoxRol.Text;
            modificarRolEspecificado modify = new modificarRolEspecificado(cadena);
            modify.Show();
            }
            else{
                MessageBox.Show("Rol eliminado",this.Text, MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            this.Close();  
         }

        private void button2_Click(object sender, EventArgs e)
        {
         //   Form1 abm = new Form1();
         //   abm.Show();
            this.Close();
        }
    }
}
