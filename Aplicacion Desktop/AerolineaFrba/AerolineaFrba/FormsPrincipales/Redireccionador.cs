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
    public partial class Redireccionador : Form
    {
        public Redireccionador()
        {
            InitializeComponent();
        }

        public void setFunciones(List<Funcionalidades> funciones)
        {
            cmbFuncionalidades.DataSource = funciones;
        }

        private void Redireccionador_Load(object sender, EventArgs e)
        {

        }

        private void btSeleccion_Click(object sender, EventArgs e)
        {
            Funcionalidades funcion = (Funcionalidades)cmbFuncionalidades.SelectedItem;
            (funcion.getFormAsociado()).Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            PantallaBienvenidaForm p = new PantallaBienvenidaForm();
            p.Show();
            this.Close();// this.Hide();
        }
    }
}
