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
        public ModificarAeronave llamado;
        public MotivoDeBaja anterior;
        public reemplazoCancelarPasajes(ModificarAeronave datos,MotivoDeBaja ant)
        {
            InitializeComponent();
            llamado = datos;
            anterior = ant;
        }

        private void buttonCancelarPasajes_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Parse(anterior.getFecha()).ToString();
            string motivo = anterior.motivo();
            string matricula = llamado.getMatricula();
            string query = "execute dbas.cancelacionPasajesBajaAeronave '" + fecha + "', '" + matricula + "', "+ motivo;
            MessageBox.Show(query, "Va queriendo", MessageBoxButtons.OK);

        }

        private void buttonReemplazar_Click(object sender, EventArgs e)
        {

        }
    }
}
