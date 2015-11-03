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
namespace AerolineaFrba.Compra
{
    public partial class compraForm : Form
    {
       public Viaje viaje;
        List<PasajeEncomienda> pasajes = new List<PasajeEncomienda>();
        PasajeEncomienda encomiendas;

        public compraForm()
        {
            InitializeComponent();
            inicializar();
        }
        public compraForm(Viaje v)
        {
            InitializeComponent();
            viaje = v;
            inicializar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
            this.Hide();
        }

        private void inicializar()
        {
            pasajes = new List<PasajeEncomienda>();
            txtEncomienda.Text = "0";
            cmbPasaje.Items.Clear();
            cmbPasaje.Text = "";

        }

        private void btPasaje_Click(object sender, EventArgs e)
        {
            datosPasajeroForm pasajeF = new datosPasajeroForm(this,1);
            pasajeF.Show();
        }

        private void btEncomienda_Click(object sender, EventArgs e)
        {
            datosPasajeroForm encomiendaF = new datosPasajeroForm(this, 2);
            encomiendaF.Show();
        }
        public void cargarPasaje(PasajeEncomienda pasaje){
            cmbPasaje.Items.Add(pasaje.nombre);
            cmbPasaje.SelectedIndex = 0;
            pasajes.Add(pasaje);
        }
        public void cargarEncomienda(PasajeEncomienda encomienda)
        {
            txtEncomienda.Text = encomienda.butacaKg;
            encomiendas= (encomienda);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
