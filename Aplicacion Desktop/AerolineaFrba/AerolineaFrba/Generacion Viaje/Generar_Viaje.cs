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
using AerolineaFrba.FormsPrincipales;

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
            textCodRuta.Text = "";
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }


        private void seleccionarDesde_Click(object sender, EventArgs e)
        {
           
        }

        private void seleccionarHasta_Click(object sender, EventArgs e)
        {
            
        }

        private void seleccionarMatricula_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.setAnterior(this);
            _Viaje paquete = new _Viaje(textBoxMatricula);
            listado.setViaje(paquete);
            listado.Show();
        }

        private void Generar_Viaje_Load(object sender, EventArgs e)
        {

        }

        private void seleccionarCodigo_Click(object sender, EventArgs e)
        {

        }

       
    }
}
