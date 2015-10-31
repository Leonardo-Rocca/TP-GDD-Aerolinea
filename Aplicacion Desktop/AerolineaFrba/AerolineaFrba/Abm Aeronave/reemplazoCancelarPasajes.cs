using System;
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
    public partial class reemplazoCancelarPasajes : Form
    {
        public Form llamado;
        public Form anterior;
        public reemplazoCancelarPasajes(Form datos,Form ant)
        {
            InitializeComponent();
            llamado = datos;
            anterior = ant;
        }

        private void buttonCancelarPasajes_Click(object sender, EventArgs e)
        {
            string query = "execute dbas.cancelacionPasajesBajaAeronave " + anterior.Controls["textBoxFecha"].ToString() + ", '---MOTIVO CANCELACION---', " + llamado.Controls["txtMatricula"].ToString() + ", "+ "algo";
        }

        private void buttonReemplazar_Click(object sender, EventArgs e)
        {

        }
    }
}
