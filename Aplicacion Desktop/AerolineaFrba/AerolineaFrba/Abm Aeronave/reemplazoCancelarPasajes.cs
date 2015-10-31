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
            (new ConexionSQL()).cargarTablaSQL(query);
            MessageBox.Show("Pasajes cancelados", "Baja Aeronave", MessageBoxButtons.OK);

        }

        private void buttonReemplazar_Click(object sender, EventArgs e)
        {
            string matricula = llamado.getMatricula();
            string query = "select * from dbas.aeronavesDeReemplazo('" + matricula + "')";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                DeseaDarDeAltaUnaAeronave form = new DeseaDarDeAltaUnaAeronave();
                this.Hide();
                form.Show();
            }
            else
            {
                //otra cosa
            }
        }
    }
}
