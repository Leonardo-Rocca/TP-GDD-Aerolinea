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
            chkListaFuncionalidades.Items.Insert(0, "Preparar el cafe");
            chkListaFuncionalidades.Items.Insert(1, "codear Marta");
           chkListaFuncionalidades.Items.Insert(2, "Hacer lo logs");
            chkListaFuncionalidades.Items.Insert(3, "Usuarios");
            chkListaFuncionalidades.SetItemCheckState(3, CheckState.Checked);
            //chkHabilitado.AutoCheck;//(CheckState.Checked);

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
    }
}
