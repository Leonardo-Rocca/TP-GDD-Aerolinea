using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Dominio;

namespace AerolineaFrba.Login
{
    public partial class LoginAdministrador : Form
    {
        private string username, password;

        public LoginAdministrador()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }

        private void LoginAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            PantallaBienvenidaForm p =new PantallaBienvenidaForm();
            p.Show();
            this.Hide();
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (username == null || password == null){
             MessageBox.Show("Debe ingresar su nombre de usuario y contraseña");
            }
            else{
                Sesion s = new Sesion();
                      try{
                          MessageBox.Show("contraseña:" + getSha256(password));
                s.iniciar(username, getSha256(password),"Administrador");
                MessageBox.Show("bien");
                Redireccionador redirec = new Redireccionador();
                redirec.setFunciones(s.getFuncionalidadesDisponibles);
                redirec.Show();
                this.Hide();
                      }
                      catch(Exception er)
                      {
                          MessageBox.Show(er.Message );
                      }
            
            }
  
        }


        public String getSha256(String input)
        {
            SHA256Managed encriptador = new SHA256Managed();
            byte[] inputEnBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputHashBytes = encriptador.ComputeHash(inputEnBytes);
            return BitConverter.ToString(inputHashBytes).Replace("-", String.Empty).ToLower();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            username = txtNombre.Text;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            password = txtpass.Text;
        }
    }
}
