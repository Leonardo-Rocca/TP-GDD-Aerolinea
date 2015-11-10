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
           if (!validarExistenciaViaje()) return;

            llegadaAvionForm registro = new llegadaAvionForm(txtmatricula.Text,cmbOrigen.Text,cmbDestino.Text);
            registro.Show();
            this.Hide();
            inicializar();
        }

        private bool validarExistenciaViaje()
        {
           string query ="select * FROM dbas.rutas r,dbas.viajes v,dbas.ciudades co,dbas.ciudades cd "+ 
              "WHERE r.codigo_ruta = v.codigo_ruta AND r.ciudad_origen_id=co.id_ciudad AND r.ciudad_destino_id = cd.id_ciudad  AND habilitado_viaje = 1 "+
			  "AND co.nombre_ciudad = '" + cmbOrigen.Text + "' AND cd.nombre_ciudad = '" + cmbDestino.Text + "' AND matricula_aeronave = '"+txtmatricula.Text+"'";
           DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
           if (dt.Rows.Count == 0)
           {
               MessageBox.Show("No existe tal viaje", "invalido", MessageBoxButtons.OK);
               return false;
           }

           return true;
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
