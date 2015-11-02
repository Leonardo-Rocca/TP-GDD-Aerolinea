using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class modificarRolEspecificado : Form
    {
        public modificarRolEspecificado(string rol)
        {
            InitializeComponent();
            txtNombreRol.Text = rol;
            cargarChkFuncionalidades();
            cargarFuncionalidades(rol);
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
            };

            DataTable tblfunc = new DataTable("func");
            tblfunc.Columns.Add("Id", typeof(int));
            for (int i = 0; i <= chkListaFuncionalidades.Items.Count - 1; i++)
            {
                if (chkListaFuncionalidades.GetItemChecked(i))
                {
                    tblfunc.Rows.Add(i + 1);
                }
            }
            MessageBox.Show("Rol Modificado(dammy)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //this.Close();
            this.Hide();
            return;
        }

        private void chkListaFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancelar   this.Close();
            this.Hide();
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
    }
}
