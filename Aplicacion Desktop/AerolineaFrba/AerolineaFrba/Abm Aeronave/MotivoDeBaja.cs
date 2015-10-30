using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class MotivoDeBaja : Form
    {
        public Form anterior;

        public MotivoDeBaja(Form ant)
        {
            InitializeComponent();
            iniciar();
            anterior = ant;
        }

        private void iniciar()
        {
            checkBoxFueraDeServicio.Checked = false;
            checkBoxBajaDefinitiva.Checked = false;
            labelFechaDeReinsercion.Visible = false;
            textBoxFecha.Visible = false;
            buttonSeleccionar.Visible = false;
            monthCalendarFecha.Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            labelFechaDeReinsercion.Visible = false;
            textBoxFecha.Visible = false;
            buttonSeleccionar.Visible = false;
            monthCalendarFecha.Visible = true;
        }

        private void monthCalendarFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
           textBoxFecha.Text = monthCalendarFecha.SelectionStart.ToString();
           labelFechaDeReinsercion.Visible = true;
           textBoxFecha.Visible = true;
           buttonSeleccionar.Visible = true;
           monthCalendarFecha.Visible = false;
        }

        private void checkBoxFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFueraDeServicio.Checked)
            {
                checkBoxBajaDefinitiva.Checked = false;
                labelFechaDeReinsercion.Visible = true;
                textBoxFecha.Visible = true;
                buttonSeleccionar.Visible = true;
                return;
            }
            if (!checkBoxBajaDefinitiva.Checked)
            {
                checkBoxFueraDeServicio.Checked = true ;
            }
        }

        private void checkBoxBajaDefinitiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBajaDefinitiva.Checked)
            {
                checkBoxFueraDeServicio.Checked = false;
                labelFechaDeReinsercion.Visible = false;
                textBoxFecha.Visible = false;
                buttonSeleccionar.Visible = false;
                monthCalendarFecha.Visible = false;
            }
           if(!checkBoxFueraDeServicio.Checked){
                checkBoxBajaDefinitiva.Checked = true;

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciar();
            anterior.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           
            if (!validaciones())
            {
                return;
            }
            this.Hide();
            this.iniciar();
            int motivo;
            if (checkBoxBajaDefinitiva.Checked) textBoxFecha.Text = monthCalendarFecha.TodayDate.ToString();
            if(checkBoxFueraDeServicio.Checked){
                motivo=1;
            }else{
                motivo=0;
            }
            string query = "execute dbas.bajaAeronave " + DateTime.Parse(textBoxFecha.Text.ToString()).ToString() + ", " + anterior.Controls["txtMatricula"] + ", " + motivo.ToString();
            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
            }
            catch(SqlException sqlEx)
            {
                if (sqlEx.Message.StartsWith("No puede dar de baja la aeronave, esta en vuelo"))
                {
                    MessageBox.Show("No puede dar de baja la aeronave, esta en vuelo. Intentelo en otro momento", "Baja aeronave", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("BOOOOOM", "Baja aeronave", MessageBoxButtons.OKCancel);
                    return;
                }
            }

            MessageBox.Show("Baja de aeronave exitosa", "Baja aeronave", MessageBoxButtons.OK);

        }

        private bool validaciones()
        {
          
            if (checkBoxFueraDeServicio.Checked)
            {
                if (textBoxFecha.TextLength != 0) return true;
                MessageBox.Show("Falta especificar fecha de reinsercion", "Error en los datos", MessageBoxButtons.OK);
                return false;
            }

            if (checkBoxBajaDefinitiva.Checked) return true;

            MessageBox.Show("Falta seleccionar un motivo", "Error en los datos", MessageBoxButtons.OK);
            return false;
        }
    }
}
