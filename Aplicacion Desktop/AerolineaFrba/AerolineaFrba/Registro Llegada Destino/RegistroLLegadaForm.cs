using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLLegadaForm : FormGenerico
    {
        public RegistroLLegadaForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btFiltroOrigen_Click(object sender, EventArgs e)
        {
            cargarCiudad(resultadoFiltro);
        }

        private void cargarCiudad(TextBox invisible)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref invisible);
            lOrigen.Show();
        }

        private void resultadoFiltro_TextChanged(object sender, EventArgs e)
        {
            cmbOrigen.Text = resultadoFiltro.Text;
        }

        private void btFiltroDestino_Click(object sender, EventArgs e)
        {
            cargarCiudad(resultadoFiltro2);
        }

        private void resultadoFiltro2_TextChanged(object sender, EventArgs e)
        {
            cmbDestino.Text = resultadoFiltro2.Text;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
           llegadaAvionForm registro = new llegadaAvionForm(txtmatricula.Text);
        }
    }
}
