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
            return true;
        }
        private void llegadaAvionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
