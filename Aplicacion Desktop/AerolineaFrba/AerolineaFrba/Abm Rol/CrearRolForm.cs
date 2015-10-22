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
    public partial class CrearRolForm : Form
    {
        string nombreRol;

        public CrearRolForm()
        {  
            InitializeComponent();
            chkListaFuncionalidades.Items.Insert(0,"Dar de baja Usuarios");
            chkListaFuncionalidades.Items.Insert(1, "Dar de alta Usuarios");
            chkListaFuncionalidades.Items.Insert(2, "aprobar");
            chkListaFuncionalidades.Items.Insert(3, "Usuarios");
            chkListaFuncionalidades.SetItemCheckState(3, CheckState.Checked);

        }
   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregadas");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------Guardar-------
        private void button3_Click(object sender, EventArgs e)
        {   
            if(txtNombreRol.Text.Equals(string.Empty)){
                 MessageBox.Show("Falta agregar nombre",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
             }
              if(chkListaFuncionalidades.CheckedIndices.Count==0){
                 MessageBox.Show("Falta elegir funcionalidad",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
             };

              DataTable tblfunc = new DataTable("func");
                tblfunc.Columns.Add("Id",typeof(int));
                for (int i = 0; i <= chkListaFuncionalidades.Items.Count - 1; i++)
                {
                   if (chkListaFuncionalidades.GetItemChecked(i)){
                      tblfunc.Rows.Add(i+1);
                   }
                 }
                MessageBox.Show("Rol agregado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide(); //.Close();
                return;
         }   
        

        private void button2_Click(object sender, EventArgs e)
        {
            //cancelar     // this.Close();
            this.Hide();
        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {
           nombreRol = txtNombreRol.Text.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}