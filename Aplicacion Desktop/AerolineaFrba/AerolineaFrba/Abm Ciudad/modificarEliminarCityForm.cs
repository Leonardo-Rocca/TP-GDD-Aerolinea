using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Dominio;
namespace AerolineaFrba.Abm_Ciudad
{
    public partial class modificarEliminarCityForm : FormGenerico
    {
        int tipoDeForm; //1 modificar ,2 eliminar

        public modificarEliminarCityForm(int tipo)
        {
            InitializeComponent();

            tipoDeForm = tipo;
            if (tipo == 1)
            {
                lbtitulo.Text = "Modificar Ciudad";
                buttonGuardar.Text = "modificar";
            }
            else
            {
                lbtitulo.Text = "Eliminar Ciudad";
                buttonGuardar.Text = "eliminar";
            }
            cargarComboSeleccion();
            resultadoFiltro.Visible = false;

            cargarReferenciasAForms();
        }


        public void cargarComboSeleccion()
        {
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM DBAS.ciudades WHERE habilitada_ciudad = 1 ORDER BY nombre_ciudad");
            comboBoxCity.DataSource = dt.DefaultView;
            comboBoxCity.ValueMember = "nombre_ciudad";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (tipoDeForm == 1)
            {
                navegacion.modificarCiudad = this;
                string cadena = comboBoxCity.Text;
                ModificarCiudadForm modify = new ModificarCiudadForm(cadena,this);
                modify.Show();
            }
            else
            {
                if (MessageBox.Show("¿Realmente desea dar de baja la ciudad: " + comboBoxCity.Text + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //dar baja logica
                string querybaja = "execute  DBAS.bajaCiudad '"+comboBoxCity.Text+"'";
                try{
                (new ConexionSQL()).ejecutarComandoSQL(querybaja);
                }catch(Exception er){
                    MessageBox.Show(er.Message);
                    if (MessageBox.Show("¿Desea cancelarlos ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    querybaja = "execute  DBAS.cancelarPasajesBajaCiudad '" + comboBoxCity.Text + "'";
                    (new ConexionSQL()).ejecutarComandoSQL(querybaja);
                }
                        navegacion.EliminarCiudad.cargarComboSeleccion();
                        navegacion.modificarCiudad.cargarComboSeleccion();
                MessageBox.Show("Ciudad eliminada ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide(); 

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref resultadoFiltro);
            lOrigen.Show();
        }

        private void resultadoFiltro_TextChanged(object sender, EventArgs e)
        {
            comboBoxCity.Text = resultadoFiltro.Text;
        }

        private void cargarReferenciasAForms()
        {
            if (tipoDeForm == 1) { 
                navegacion.modificarCiudad = this;
            }
            else
            {   navegacion.EliminarCiudad = this;
            }
        }

    }
}
