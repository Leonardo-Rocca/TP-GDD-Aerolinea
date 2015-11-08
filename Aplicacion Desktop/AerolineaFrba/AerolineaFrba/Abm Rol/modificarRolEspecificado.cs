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

namespace AerolineaFrba.Abm_Rol
{
    public partial class modificarRolEspecificado : Form
    {
        private string nombreRolPasado;

        public modificarRolEspecificado(string rol)
        {
            InitializeComponent();
            inicializar(rol);
        }

        public void inicializar(string rol)
        {     txtNombreRol.Text = rol;
            nombreRolPasado = rol;
            cargarChkFuncionalidades();
            cargarFuncionalidades(rol);
            cargarChkHabilitado(rol);
        }

        private void cargarChkHabilitado(string rol)
        {
            string qHabilitado = "select habilitado_rol from dbas.roles WHERE nombre_rol = '" + rol + "'";
            DataTable dtHabilitado = (new ConexionSQL()).cargarTablaSQL(qHabilitado);

            if(Convert.ToInt32(dtHabilitado.Rows[0][0])==1){
            chkHabilitado.Checked= true;
            return;
            }
            chkHabilitado.Checked = false;
        }
        public void cargarFuncionalidades(string rol){
            string qfuncion = "select descripcion from  DBAS.obtenerFuncionalidadesAsociadas ('" + rol + "')";
            DataTable dtfunciones =  (new ConexionSQL()).cargarTablaSQL(qfuncion);

            List<string> servicios = new List<string>();

            //--cargo mi lista
            for (int i = 0; i <= (dtfunciones.Rows.Count - 1); i++)
            {
                servicios.Add(dtfunciones.Rows[i][0].ToString());
            }

            //--Comparo con loscheckElements
            for (int i = 0; i <= (chkListaFuncionalidades.Items.Count - 1); i++)
            {
                if (servicios.Contains(chkListaFuncionalidades.Items[i].ToString()))
                {
                    chkListaFuncionalidades.SetItemCheckState(i,CheckState.Checked);
                 }
                  else
                  {
                     chkListaFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
                  }
              
            }


        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text.Equals(string.Empty))
            {
                MessageBox.Show("No se puede tener nombre nulo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkListaFuncionalidades.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Falta elegir funcionalidad", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

             modificar();

            MessageBox.Show("Rol Modificado(dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            actualizarFormsRoles();

            //this.Close();
            this.Hide();
            return;
        }

        private void modificar()
        {
            string id = obtenerId();
            string habilitacion="1";
            if (chkHabilitado.Checked == false)
                habilitacion="0";
            
            string query = "INSERT INTO DBAS.modificarRoles (id_rol,nombre_rol,habilitado_rol,id_funcionalidad) SELECT distinct '"+id+"' , '"+txtNombreRol.Text+"','"+habilitacion+"',id_funcionalidad FROM DBAS.funcionalidades WHERE descripcion IN ( ";

            foreach (string elemento in chkListaFuncionalidades.CheckedItems)
            {
                query = query + " '" + elemento + "',";
            }
            query = query + "'lalala' )";
          
            (new ConexionSQL()).ejecutarComandoSQL(query);
       
        }

        private string obtenerId()
        {
            string quey = "Select id_rol From DBAS.roles  WHERE nombre_rol = '" + nombreRolPasado + "'";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(quey);
            return dt.Rows[0][0].ToString();
        }

        private static void actualizarFormsRoles()
        {
            ModificarForm m = (ModificarForm)navegacion.modifRol;
            m.Inicializar();
            ModificarForm el = (ModificarForm)navegacion.eliminarRol;
            el.Inicializar();
        }

        private void chkListaFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancelar  
            this.Close();
        }

        private void cargarChkFuncionalidades()
        {
            string comando = "select * from dbas.funcionalidades";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);

            chkListaFuncionalidades.Items.Clear();
            for (int i = 0; i <= (dt.Rows.Count - 1); i++)
            {
                int idf = Convert.ToInt32(dt.Rows[i][0]);
                chkListaFuncionalidades.Items.Insert(i, dt.Rows[i][1].ToString());
            }

        }

        private void btSeleccionarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= chkListaFuncionalidades.Items.Count - 1; i++)
            {
                chkListaFuncionalidades.SetItemCheckState(i, CheckState.Checked);
            }
        }
    }
}
