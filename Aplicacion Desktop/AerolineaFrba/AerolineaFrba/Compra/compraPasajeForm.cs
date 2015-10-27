using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Ciudad;
namespace AerolineaFrba.Compra
{
    public partial class compraPasajeForm : FormGenerico
    {
        public compraPasajeForm()
        {
            InitializeComponent();
            txtCityOrigen.ReadOnly = true;
            txtDestino.ReadOnly = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCityOrigen.Text = "";
            txtDestino.Text="";
            this.Hide();
        }

        private void btsOringen_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtCityOrigen);
            lOrigen.Show();
        }

        private void btsDestino_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref txtDestino);
            lOrigen.Show();
        }

    }
}
