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

namespace AerolineaFrba.Compra
{
    public partial class datosPasajeroForm : Form
    {
        private compraForm compraForm;
        private int tipo;//1 pasaje, 2encomienda  //0persona
        Butaca butacaPasaje;

        public datosPasajeroForm()
        {
            InitializeComponent();
        }

        public datosPasajeroForm(compraForm compraForm, int tipe)
        {
            InitializeComponent();
            this.compraForm = compraForm;
            this.tipo = tipe;
            if(tipe==1||tipe==0){
                txtKg.Visible=false;
                lbkasterix.Visible=false;
                lbKG.Visible=false;
            }
            if (tipe == 2 || tipe == 0)
            {
                lbButaca.Visible=false;
                txtButaca.Visible=false;
                btButaca.Visible=false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            compraForm.Show();
            Compra.inicializar();
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(!validarCamposVacios())return;

            string butacaKg="";
            if (tipo == 1) butacaKg = txtButaca.Text;
            if (tipo == 2) butacaKg = txtKg.Text;
            PasajeEncomienda pasEn = new PasajeEncomienda(txtnombre.Text,txtApellido.Text,dni,tel,txtMail.Text,dateTimePickerFnac.Text,butacaKg);

            if (tipo == 0)
            {
                if (Compra.pagaEnEfectivo) {
                    Compra.comprador = pasEn;
                    Compra.realizarCompra(); }
                else{
                    datosCompradorForm tarjeta = new datosCompradorForm();
                    tarjeta.Show();
                    compraForm.Hide();
                    this.Close();
                    }
                return;
            }
            if (tipo == 1){
                compraForm.cargarPasaje(pasEn);
            }
            if (tipo == 2){
                compraForm.cargarEncomienda(pasEn);
            }
            compraForm.Show();
            this.Close();
        }

        private bool validarCamposVacios()
        {
            if (txtnombre.Text == "" || txtApellido.Text == "" || dni=="" || tel==""){
                MessageBox.Show("Debe completar todos los campos obligatorios");
                return false;
            }
            if (tipo == 1 && txtButaca.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
                return false;
            }
            if (tipo == 2 && txtKg.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
                return false;
            }
            return true;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {     //VERIFICAR SOLO NUMEROS                              TO-DO
            
           dni = txtDni.Text;
           string query = "select* from dbas.personas WHERE dni_persona ="+dni;
            DataTable dt =(new ConexionSQL()).cargarTablaSQL(query);
            if(dt.Rows.Count==0)return;
            txtnombre.Text = dt.Rows[0][2].ToString();
            txtApellido.Text = dt.Rows[0][3].ToString();
            txtDireccion.Text = dt.Rows[0][4].ToString();
            txtPhone.Text = dt.Rows[0][5].ToString();
    //        dateTimePickerFnac.Text = dt.Rows[0][6].ToString(); ---rompe    TO-DO

        }

        public string dni { get; set; }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            tel = txtPhone.Text;
        }

        public string tel { get; set; }

        private void btButaca_Click(object sender, EventArgs e)
        {
            ListadoButacas list = new ListadoButacas(compraForm.viaje);
            list.anterior = this;
            list.Show();
            this.Hide();
        }


        public void cargarButaca(Butaca seleccionada)
        {
            txtButaca.Text = seleccionada.numero_butaca;
            butacaPasaje = seleccionada;
        }
    }
}
