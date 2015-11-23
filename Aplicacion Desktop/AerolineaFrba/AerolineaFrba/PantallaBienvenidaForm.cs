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
using AerolineaFrba.Login;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba
{
    public partial class PantallaBienvenidaForm : Form
    {
        public PantallaBienvenidaForm()
        {
            InitializeComponent();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_rol FROM  DBAS.roles Where habilitado_rol > 0 "); //gd_esquema.Maestra
            cmbRoles.DataSource = dt.DefaultView;
            cmbRoles.ValueMember = "nombre_rol"; 
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {           
            if (cmbRoles.Text == "Administrador" || cmbRoles.Text == "Administrador General")
            {
                LoginAdministrador ingreso = new LoginAdministrador();
                ingreso.Show();
                //this.Hide();
                this.Close();
            }
            else
            {
                //Sesion s = new Sesion();
                Sesion.iniciar("","",cmbRoles.Text);
                Redireccionador redirec = new Redireccionador();
                redirec.setFunciones(Sesion.getFuncionalidadesDisponibles);
                //  (new  Abm_Rol.Form1()).Show();
                redirec.Show();
              //  this.Hide();
                this.Close();
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}