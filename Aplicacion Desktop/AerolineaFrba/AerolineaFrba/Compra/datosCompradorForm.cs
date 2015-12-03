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
            cmbCuotas.SelectedIndex = -1;
            dateTimePickerFnac.Text = Program.nuevaFechaSistema();
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
            if (!validaciones()) return;
            Compra.inicializar();
            Compra.tarjeta = new Tarjeta(txtNumero.Text, txtPass.Text, dateTimePickerFnac.Value.ToString(), "1", cmbCuotas.Text, "1");
            Compra.realizarCompra();
            this.Close();
        }

        private bool validaciones()
        {
            if (!estaCompleto())
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }

            if (txtNumero.TextLength > 9)
            {
                MessageBox.Show("El numero de tarjeta ingresado excede el maximo de 9 digitos permitido", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (txtPass.TextLength > 9)
            {
                MessageBox.Show("El password ingresado excede los 9 digitos permitidos", "Error", MessageBoxButtons.OK);
                return false;
            }
            Int32 a;
            
            try
            {
                a = Convert.ToInt32(txtNumero.Text);

            }
            catch
            {
                MessageBox.Show("El numero de tarjeta ingresado no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (a < 0)
            {
                MessageBox.Show("El numero de tarjeta ingresado debe ser positivo", "Error", MessageBoxButtons.OK);
                return false;
            }

            int ant1 = DateTime.Compare(DateTime.Parse(dateTimePickerFnac.Text), DateTime.Parse(Program.nuevaFechaSistema()));
            if (ant1 < 0)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior al dia de hoy", "Fecha de vencimiento invalida", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool estaCompleto()
        {
            return (txtNumero.TextLength != 0 && txtPass.TextLength != 0 && cmbCuotas.SelectedIndex != -1 && cmbTipoTarjeta.SelectedIndex != -1);
   
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

        private void dateTimePickerFnac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
