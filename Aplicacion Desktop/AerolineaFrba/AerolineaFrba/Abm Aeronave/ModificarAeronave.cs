﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ModificarAeronave : Form
    {
        public ModificarAeronave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.cargarModificado(this);
            listado.Show();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}