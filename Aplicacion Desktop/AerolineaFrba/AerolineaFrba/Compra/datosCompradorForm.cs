using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class datosCompradorForm : Form
    {
        public datosCompradorForm()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            inicializar();
        }

        private void inicializar()
        {
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select * from dbas.tiposTarjeta");
            cmbTipoTarjeta.DataSource = dt.DefaultView;
            cmbTipoTarjeta.ValueMember = "descripcion_tipo";
            cmbTipoTarjeta.SelectedIndex = -1;
        }

        private void datosCompradorForm_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Compra.compra.Show();
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Compra.inicializar();
            Compra.tarjeta = new Tarjeta(txtNumero.Text, txtPass.Text, dateTimePickerFnac.Value.ToString(), "1", cmbCuotas.Text, "1");
            Compra.realizarCompra();
            this.Close();
        }

        private void cmbTipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTarjeta.Text == "") return;

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select cuotas from dbas.tiposTarjeta WHERE descripcion_tipo = '"+cmbTipoTarjeta.Text+"'");
            int cantidadCuotas=0;

            if(dt.Rows.Count!=0)
            cantidadCuotas =Convert.ToInt32(dt.Rows[0][0]);

            cmbCuotas.Items.Clear();
            if(cantidadCuotas==0)cmbCuotas.Items.Insert(0,"0");
            for (int i = 0; i < cantidadCuotas; i++)
            {
                cmbCuotas.Items.Insert(i,(i+1).ToString());
            }
            cmbCuotas.SelectedIndex = 0;
        }

        private void cmbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
