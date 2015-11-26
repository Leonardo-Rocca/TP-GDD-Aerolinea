using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class llegadaAvionForm : Form
    {
        private string matricula;
        private string cOrigen;
        private string cDestino;

        public llegadaAvionForm()
        {
            InitializeComponent();
            
        }

        public llegadaAvionForm(string p)
        {
            InitializeComponent();
            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave,numero_aeronave , modelo_aeronave, nombre_fabricante,tipo_servicio  FROM DBAS.aeronaves a,DBAS.servicios s,Dbas.fabricantes f WHERE a.id_servicio = s.id_servicio AND a.id_fabricante = f.id_fabricante AND matricula_aeronave like '" + p + "'");
            this.matricula = p;
            lbMatricula.Text = lbMatricula.Text + dta.Rows[0][0].ToString();
            lbNumero.Text = lbNumero.Text + dta.Rows[0][1].ToString();
            lbModelo.Text = lbModelo.Text + dta.Rows[0][2].ToString();
            lbServicio.Text=lbServicio.Text+dta.Rows[0][4].ToString();
            lbFabricante.Text=lbFabricante.Text+dta.Rows[0][3].ToString();
            dateTimePicker1.Text = Program.nuevaFechaSistema().ToString();
        }

        public llegadaAvionForm(string p1, string p2, string p3)
        {
            InitializeComponent();
            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave,numero_aeronave , modelo_aeronave, nombre_fabricante,tipo_servicio  FROM DBAS.aeronaves a,DBAS.servicios s,Dbas.fabricantes f WHERE a.id_servicio = s.id_servicio AND a.id_fabricante = f.id_fabricante AND matricula_aeronave like '" + p1 + "'");
            this.matricula = p1;
            lbMatricula.Text = lbMatricula.Text + dta.Rows[0][0].ToString();
            lbNumero.Text = lbNumero.Text + dta.Rows[0][1].ToString();
            lbModelo.Text = lbModelo.Text + dta.Rows[0][2].ToString();
            lbServicio.Text = lbServicio.Text + dta.Rows[0][4].ToString();
            lbFabricante.Text = lbFabricante.Text + dta.Rows[0][3].ToString();
            this.cOrigen = p2;
            this.cDestino = p3;
            dateTimePicker1.Text = Program.nuevaFechaSistema().ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMillas_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarTextosCompletos()) return;
            string qsp = "execute dbas.registroLLegadaAeronave "+matricula+","+cOrigen+","+cDestino+", '"+dateTimePicker1.Value.ToString()+"'";
            try{
                (new ConexionSQL()).ejecutarComandoSQL(qsp);
                }catch(Exception er){
                    MessageBox.Show(er.Message);
                    return;
                }
            MessageBox.Show("llegada registrada");
            this.Close();
        }


        private bool validarTextosCompletos()
        {
            if (txtDestino.Text == "") return false;
            if (textBox1.Text == "") return false;

            int horas = Int32.Parse(txtDestino.Text);
            int minutos = Int32.Parse(textBox1.Text);
            if (horas < 0 || horas > 24)
            {
                MessageBox.Show("La hora de llegada no es una hora valida", "Registro de llegada", MessageBoxButtons.OK);
                return false;
            }

            if (minutos < 0 || minutos > 59)
            {
                MessageBox.Show("Los minutos de llegada no estan dentro de un rango valido", "Registro de llegada", MessageBoxButtons.OK);
                return false;
            }

            int ant1 = DateTime.Compare(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(Program.nuevaFechaSistema()).AddDays(-1));
            if (ant1 < 0)
            {
                MessageBox.Show("La fecha de llegada debe ser posterior al dia de hoy", "Registro de llegada", MessageBoxButtons.OK);
                return false;
            }
           
            return true;
        }
        private void llegadaAvionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
