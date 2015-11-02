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

namespace AerolineaFrba.FormsPrincipales
{
    public partial class ABMGenericoForm : Form
    {
        Form crear;
        Form modificar;
        Form eliminar;

        public ABMGenericoForm(string textoAbm,Form bcrear,Form modify,Form beliminar)
        {
            InitializeComponent();
            crear = bcrear;
            modificar = modify;
            eliminar = beliminar;
            label1.Text = textoAbm;
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
           crear.Show();
    
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            modificar.Show();
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminar.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
