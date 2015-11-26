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
        public ModificarAeronave anterior;
        public MotivoDeBaja(ModificarAeronave ant)
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
            dateFecha.Text = Program.nuevaFechaSistema().ToString();
            dateFecha.Visible = false;
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            labelFechaDeReinsercion.Visible = false;
            dateFecha.Visible = false;
      
        }

        private void monthCalendarFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
         
        }

        private void checkBoxFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFueraDeServicio.Checked)
            {
                checkBoxBajaDefinitiva.Checked = false;
                labelFechaDeReinsercion.Visible = true;
                dateFecha.Visible = true;
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
                dateFecha.Visible = false;
               
            }
           if(!checkBoxFueraDeServicio.Checked){
                checkBoxBajaDefinitiva.Checked = true;

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            iniciar();
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           
            if (!validaciones())
            {
                return;
            }
            this.Hide();
            string fecha;
            if (checkBoxBajaDefinitiva.Checked)
            {
                fecha = (DateTime.Parse(Program.nuevaFechaSistema())).ToString();
            }
            else
            {
                fecha = dateFecha.Value.ToString();
            }
            
            string query = "execute dbas.bajaAeronave '" + fecha +"', '" + anterior.getMatricula() + "', " + this.motivo();
            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
            }
            catch(SqlException sqlEx)
            {
                if (sqlEx.Message.StartsWith("No puede dar de baja la aeronave, esta en vuelo"))
                {
                    MessageBox.Show("No puede dar de baja la aeronave, esta en vuelo. Intentelo en otro momento", "Baja aeronave", MessageBoxButtons.OKCancel);
                    return;
                }
                else
                {
                    if (sqlEx.Message.StartsWith("La aeronave esta en uso"))
                    {
                        reemplazoCancelarPasajes proximo = new reemplazoCancelarPasajes(anterior, this);
                        proximo.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        throw new Exception();
                       
                    }
                }
            }

            MessageBox.Show("Baja de aeronave exitosa", "Baja aeronave", MessageBoxButtons.OK);
            anterior.iniciar();
            anterior.Hide();
            this.Close();
         

        }

        private bool validaciones()
        {

            if (checkBoxFueraDeServicio.Checked)
            {
                int ant1 = DateTime.Compare(DateTime.Parse(dateFecha.Text), DateTime.Parse(Program.nuevaFechaSistema()));
                if (ant1 < 0)
                {
                    MessageBox.Show("La fecha de reinsercion debe ser posterior al dia de hoy", "Motivo de baja", MessageBoxButtons.OK);
                    return false;
                }

                return true;
            }

            if (checkBoxBajaDefinitiva.Checked) return true;

            MessageBox.Show("Falta seleccionar un motivo", "Error en los datos", MessageBoxButtons.OK);
            return false;
        }

        public string motivo()
        {
            int motivo;
           
            if (checkBoxFueraDeServicio.Checked)
            {
                motivo = 1;
            }
            else
            {
                motivo = 0;
            }

            return motivo.ToString();
        }

       public string getFecha(){
           return DateTime.Parse(dateFecha.Text).ToString();
        }

       private void MotivoDeBaja_Load(object sender, EventArgs e)
       {

       }

    }
}
