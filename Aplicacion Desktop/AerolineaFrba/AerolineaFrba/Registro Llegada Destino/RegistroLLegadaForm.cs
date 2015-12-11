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
using AerolineaFrba.Dominio;
namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLLegadaForm : FormGenerico
    {
        public RegistroLLegadaForm()
        {
            InitializeComponent();
            navegacion.registroLlegada = this;
            cargarComboSeleccion();
        }

        private void inicializar()
        {
            txtmatricula.Text = "";
        }

        public void cargarComboSeleccion()
        {
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM DBAS.ciudades WHERE habilitada_ciudad = 1 ORDER BY nombre_ciudad");
            cmbOrigen.DataSource = dt.DefaultView;
            cmbOrigen.ValueMember = "nombre_ciudad";
            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_ciudad FROM DBAS.ciudades WHERE habilitada_ciudad = 1 ORDER BY nombre_ciudad");
            cmbDestino.DataSource = dta.DefaultView;
            cmbDestino.ValueMember = "nombre_ciudad";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btFiltroOrigen_Click(object sender, EventArgs e)
        {
            cargarCiudadOrigen(resultadoFiltro);
        }

        private void cargarCiudadOrigen( TextBox invisible)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref resultadoFiltro);
            lOrigen.Show();
        }

        private void cargarCiudadDestino(TextBox invisible)
        {
            ListadoCiudad lOrigen = new ListadoCiudad();
            lOrigen.setFormAnteriorSup(this);
            lOrigen.setBuffer(ref resultadoFiltro2);
            lOrigen.Show();
        }
        private void resultadoFiltro_TextChanged(object sender, EventArgs e)
        {
            cmbOrigen.Text = resultadoFiltro.Text;
        }

        private void btFiltroDestino_Click(object sender, EventArgs e)
        {
            cargarCiudadDestino(resultadoFiltro2);
        }

        private void resultadoFiltro2_TextChanged(object sender, EventArgs e)
        {
           cmbDestino.Text = resultadoFiltro2.Text;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
           if(!validaciones())return;
          
            llegadaAvionForm registro = new llegadaAvionForm(txtmatricula.Text,cmbOrigen.Text,cmbDestino.Text);
            registro.Show();
            this.Hide();
            inicializar();
        }

        private bool validaciones()
        {
            if(!camposCompletos())return false;

            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave FROM DBAS.aeronaves where matricula_aeronave like '" + txtmatricula.Text + "'");
            if (dta.Rows.Count == 0)
            {
                MessageBox.Show("El numero de matricula no existe", "Matricula invalida", MessageBoxButtons.OK);
                return false;
            }

            dta = (new ConexionSQL()).cargarTablaSQL("select * from dbas.aeronavesEnServicio () where matricula_aeronave like '" + txtmatricula.Text + "'");
            if (dta.Rows.Count == 0)
            {
                MessageBox.Show("La aeronave no esta habilitada", "Matricula inhabilitada", MessageBoxButtons.OK);
                return false;
            }

            if (cmbOrigen.Text == cmbDestino.Text)
            {
                MessageBox.Show("La ciudad de Origen no puede ser la misma que de Destino", "ciudades incorrectas", MessageBoxButtons.OK);
                return false;
            }

            string query = "SELECT * FROM DBAS.rutas tablaRutas, DBAS.ciudades tablaCiudadOrig, DBAS.ciudades tablaCiudadDest ,dbas.viajes v" +
               " WHERE  tablaRutas.ciudad_origen_id = tablaCiudadOrig.id_ciudad AND tablaRutas.ciudad_destino_id = tablaCiudadDest.id_ciudad AND v.codigo_ruta= tablaRutas.codigo_ruta" +
               " AND v.habilitado_viaje = 1  AND tablaCiudadOrig.nombre_ciudad = '"+cmbOrigen.Text+"' AND tablaCiudadDest.nombre_ciudad = '"+cmbDestino.Text+"'";
            dta = (new ConexionSQL()).cargarTablaSQL(query);
         
            if (dta.Rows.Count == 0)
            {
                MessageBox.Show("La aeronave y la ruta no coinciden en ningun viaje", "Matricula inhabilitada", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool camposCompletos()
        {
            if (txtmatricula.Text == "" || cmbOrigen.Text == "" || cmbDestino.Text == "")
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroLLegadaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
