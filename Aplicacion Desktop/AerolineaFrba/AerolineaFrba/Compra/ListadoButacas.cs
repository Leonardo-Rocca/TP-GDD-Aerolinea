using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Utils;
namespace AerolineaFrba.Compra
{
    public partial class ListadoButacas : Form
    {
        private Dominio.Viaje viaje;

        public ListadoButacas()
        {
            InitializeComponent();
        }

        public ListadoButacas(Dominio.Viaje viaje)
        {
            InitializeComponent();
            this.viaje = viaje;
            chkPasillo.Checked = true;
            chkVentanilla.Checked = true;
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string query = "select distinct numero_butaca,tipo_butaca, piso_butaca  from dbas.butacas  WHERE matricula_aeronave = '" + viaje.matriculaAeronave+
                "' AND piso_butaca = "+txtPiso.Text;

            string agregado = " AND tipo_butaca IN (";
            if (chkPasillo.Checked)
            {
                agregado = agregado+"'Pasillo',";
            }
            if (chkVentanilla.Checked)
            {
                agregado = agregado + "'Ventanilla',";
            }
            agregado = agregado + " 'lalala')";
            query = query + agregado +" Order BY 1";

            CompletadorDeTablas.hacerQuery(query,ref dgvbutaca);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
