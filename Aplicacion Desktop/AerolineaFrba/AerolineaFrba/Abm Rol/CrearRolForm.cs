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
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Abm_Rol
{
    public partial class CrearRolForm : Form
    {
        string nombreRol;

        public CrearRolForm()
        {  
            InitializeComponent();
            chkHabilitado.Checked = true;
            cargarChkFuncionalidades();

        }
   
        private void cargarChkFuncionalidades()
        {
             string comando = "select * from dbas.funcionalidades";
             DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);

             chkListaFuncionalidades.Items.Clear();
            for (int i = 0; i <= (dt.Rows.Count - 1); i++)
             {
                 int idf = Convert.ToInt32(dt.Rows[i][0]);
                 chkListaFuncionalidades.Items.Insert(i, new Funcionalidades(idf, dt.Rows[i][1].ToString(), this));
              }

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

              this.agregarRol();
           
                MessageBox.Show("Rol agregado (posta)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide(); //.Close();
                return;
         }

        private void agregarRol()
        {
            DataTable tblfunc = new DataTable("func");
            tblfunc.Columns.Add("Id", typeof(int));
           /* for (int i = 0; i <= chkListaFuncionalidades.Items.Count - 1; i++)
            {
                if (chkListaFuncionalidades.GetItemChecked(i))
                {
                    tblfunc.Rows.Add(i + 1);
                }
            }*/

            string comando = "insert into DBAS.rolesConFuncionalidades (nombre_rol,id_funcionalidad)select distinct '" + nombreRol + "', id_funcionalidad FROM DBAS.funcionalidades WHERE descripcion IN ( ";

            foreach (Funcionalidades elemento in chkListaFuncionalidades.CheckedItems)
            {
                comando = comando + " '" + elemento.Descripcion + "',";
            }
            comando = comando + "'lalala' )";
            MessageBox.Show(comando, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            (new ConexionSQL()).ejecutarComandoSQL(comando);


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
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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