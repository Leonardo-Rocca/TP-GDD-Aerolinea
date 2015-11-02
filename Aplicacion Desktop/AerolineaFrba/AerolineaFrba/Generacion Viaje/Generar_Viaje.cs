using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ruta;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Generar_Viaje : Form
    {
        public int discriminador;
        public Generar_Viaje()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            textBoxMatricula.Text = "";
            textFechaDesde.Text = "";
            textFechaHasta.Text = "";
            textCodRuta.Text = "";
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (discriminador == 1)
            {
                textFechaDesde.Text = calendario.SelectionStart.ToString();
            }
            else
            {
                textFechaHasta.Text = calendario.SelectionStart.ToString();
            }
            mostrarBotones();
            calendario.Visible = false;
        }

        private void mostrarBotones()
        {
            seleccionarCodigo.Visible = true;
            seleccionarDesde.Visible = true;
            seleccionarHasta.Visible = true;
            seleccionarMatricula.Visible = true;
        }

        private void ocultarBotones()
        {
            seleccionarCodigo.Visible = false;
            seleccionarDesde.Visible = false;
            seleccionarHasta.Visible = false;
            seleccionarMatricula.Visible = false;
        }

        private void seleccionarDesde_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            calendario.Visible = true;
            discriminador = 1;
        }

        private void seleccionarHasta_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            calendario.Visible = true;
            discriminador = 0;
        }

        private void seleccionarMatricula_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.Show();
        }

       
    }
}
