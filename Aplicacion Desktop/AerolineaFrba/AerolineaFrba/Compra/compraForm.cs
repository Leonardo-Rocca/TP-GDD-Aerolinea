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
       public List<PasajeEncomienda> pasajes = new List<PasajeEncomienda>();
       public PasajeEncomienda encomiendas;
       public int kgEncomiendas;

        public compraForm()
        {
            InitializeComponent();
            inicializar();
            btEncomienda.Visible = false;
       //     viaje = new Viaje();
       //     viaje.matriculaAeronave = "BZD-177";
        }
        public compraForm(Viaje v)
        {
            InitializeComponent();
            viaje = v;
          //  btEncomienda.Visible = false;
            Compra.inicializar();
            inicializar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Compra.inicializar();
            inicializar();
            this.Hide();
        }

        private void inicializar()
        {
            pasajes = new List<PasajeEncomienda>();
            encomiendas = null;
            txtEncomienda.Text = "0";
            cmbPasaje.Items.Clear();
            cmbPasaje.Text = "";

        }

        private void btPasaje_Click(object sender, EventArgs e)
        {
             int espacioDisponible = Convert.ToInt32(viaje.butacas_disponibles)- pasajes.Count(); 
            if (espacioDisponible < 0)
                {
                    MessageBox.Show("No quedan mas pasajes para este vuelo");
                    return;
                }
            datosPasajeroForm pasajeF = new datosPasajeroForm(this,1);
            pasajeF.Show();
        }

        private void btEncomienda_Click(object sender, EventArgs e)
        {
            int espacioDisponible = kgsEncomiendasDisponible(); 
            if (espacioDisponible < 0)
            {
                MessageBox.Show("No queda mas espacio para encomiendas en este viaje");
                return;
            }
            datosPasajeroForm encomiendaF = new datosPasajeroForm(this, 2);
            encomiendaF.Show();
        }

        public int kgsEncomiendasDisponible()
        {
            return Convert.ToInt32(viaje.kgs_disponibles);
          /*  int encomiendaEnKillo;
 
            if (encomiendas == null) { 
                encomiendaEnKillo = 0; 
            }  else { 
                encomiendaEnKillo = Convert.ToInt32(encomiendas.butacaKg);
            }
            return Convert.ToInt32(viaje.kgs_disponibles) - encomiendaEnKillo ;*/
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
            if ((txtEncomienda.Text == "" || txtEncomienda.Text == "0") && cmbPasaje.Items.Count == 0) {
                MessageBox.Show("Debe agregar pasajes o encomiendas");
                return;
            }

            Compra.compra = this;
            Compra.pagaEnEfectivo = false;
            if(Sesion.Usuario.nombreRol=="Administrador General"){
                if (MessageBox.Show("¿Desea abonar en efectivo ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Compra.pagaEnEfectivo = true;

                }
            }
            datosPasajeroForm compradorF = new datosPasajeroForm(this, 0);
            compradorF.Show();
            this.Hide();

        }

        private void txtEncomienda_TextChanged(object sender, EventArgs e)
        {
            if(txtEncomienda.Text!="")
            kgEncomiendas = Convert.ToInt32(txtEncomienda.Text);
        }

        private void cmbPasaje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
