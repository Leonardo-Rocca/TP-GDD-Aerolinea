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
namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarForm : FormGenerico
    {
        int tipoDeForm; //1=modificar 2=eliminar

        public ModificarForm()
        {
            InitializeComponent(); 
            comboBoxRol.Items.Insert(0, "Usuario");
            comboBoxRol.Items.Insert(1, "El que mueve la papota");
            
        }

        public ModificarForm(string nombre,string nombreBoton,int tipo)
        {
            InitializeComponent();
            comboBoxRol.Items.Insert(0, "Usuario");
            comboBoxRol.Items.Insert(1, "El que mueve la papota");
            buttonGuardar.Text = nombreBoton;
            label1.Text = nombre;
            tipoDeForm = tipo;
            Inicializar();

        }

        private void Inicializar()
        {
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_rol FROM DBAS.roles");
            comboBoxRol.DataSource = dt.DefaultView;
            comboBoxRol.ValueMember = "nombre_rol";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.Text.Equals(string.Empty))
            {
                MessageBox.Show("No seleccionó ningun Rol", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tipoDeForm==1){
            string cadena = comboBoxRol.Text;
            modificarRolEspecificado modify = new modificarRolEspecificado(cadena);
            modify.Show();
            }
            else{
             
                if (MessageBox.Show("¿Realmente desea dar de baja el rol " + comboBoxRol.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //dar baja logica
                MessageBox.Show("Rol eliminado (dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide(); //this.Close();  
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            ListadoRol listado = new ListadoRol();
            listado.setFormAnteriorSup(this);
            listado.Show();
        }

        public void obtenerResultado(string nombreRolDesdeListado)
        {
            comboBoxRol.Text = nombreRolDesdeListado;
        }
    }
}
