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
    public partial class DeseaDarDeAltaUnaAeronave : Form
    {
        ModificarAeronave datos;
        MotivoDeBaja datosBaja;

        public DeseaDarDeAltaUnaAeronave(ModificarAeronave data,MotivoDeBaja data2)
        {
            InitializeComponent();
            datos = data;
            datosBaja = data2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaAeronave form = new AltaAeronave();
            form.setDiscriminador(datos,datosBaja);
            this.Hide();
            form.Show();
        }

        private void buttonCancelarPasajes_Click(object sender, EventArgs e)
        {
            datos.Close();
            datosBaja.Close();
            this.Close();
        }
    }
}
