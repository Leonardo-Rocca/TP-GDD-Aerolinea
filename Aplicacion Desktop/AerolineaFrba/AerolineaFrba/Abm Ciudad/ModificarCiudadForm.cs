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
namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ModificarCiudadForm : Form
    {
        string nombreDeLaCiudadAModificar;
        modificarEliminarCityForm formAnterior;

        public ModificarCiudadForm(string ciudad,Form elFormAnterior)
        {
            InitializeComponent();
            lbtitulo.Text = lbtitulo.Text + ciudad;
            txtNombreCiudad.Text = ciudad;
            nombreDeLaCiudadAModificar = ciudad;
            formAnterior = (modificarEliminarCityForm)elFormAnterior;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreCiudad.Text.Equals(string.Empty))
            {
                MessageBox.Show("Falta agregar nombre", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
//            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM  DBAS.ciudades WHERE nombre_ciudad LIKE '_" + txtNombreCiudad.Text + "'OR nombre_ciudad LIKE '" + txtNombreCiudad.Text + "' ");
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM  DBAS.ciudades WHERE nombre_ciudad LIKE '" + txtNombreCiudad.Text + "' ");
            //--pregunto si hay alguna fila cuyo nombre coincida con el ingresado-- 
            if (dt.Rows.Count == 0)
            {
                string comando = "UPDATE DBAS.ciudades  SET nombre_ciudad = '" + txtNombreCiudad.Text + "' WHERE nombre_ciudad = '" + nombreDeLaCiudadAModificar +"'";
                (new ConexionSQL()).ejecutarComandoSQL(comando);
                MessageBox.Show("Ciudad Modificada (posta)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formAnterior.cargarComboSeleccion();
            }
            else
            {       //falta ver si es la misma ciudad
                MessageBox.Show("La ciudad ya existe", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ((modificarEliminarCityForm)navegacion.modificarCiudad).cargarComboSeleccion();
            ((modificarEliminarCityForm)navegacion.EliminarCiudad).cargarComboSeleccion();

            this.Close();
            txtNombreCiudad.Text = "";
            return;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
