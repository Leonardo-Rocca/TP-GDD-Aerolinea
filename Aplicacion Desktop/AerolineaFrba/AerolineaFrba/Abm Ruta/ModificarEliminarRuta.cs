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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ModificarEliminarRuta : Form
    {
        int tipoDeForm; //1 modificar ,2 eliminar

        public ModificarEliminarRuta(int tipo)
        {
            InitializeComponent();
        
            tipoDeForm = tipo;
            if (tipo == 1)
            {
                lbTitle.Text = "Modificar" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text+ "modificar:";
            }
            else
            {
                lbTitle.Text = "Eliminar" + lbTitle.Text;
                lbSeleccion.Text = lbSeleccion.Text + "eliminar:";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (chkListaServicios.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Falta elegir tipos de servicio", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (txtCDestino.Text.Equals(string.Empty) || txtCodigo.Text.Equals(string.Empty) || txtCOrigen.Text.Equals(string.Empty) || txtPasajeLimInferior.Text.Equals(string.Empty) || txtPasajeSuperior.Text.Equals(string.Empty) || txtPKGLimInferior.Text.Equals(string.Empty) || txtPKGSuperior.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe completar todos los campos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void eliminarRuta()
        {
            
        }

    }
}
