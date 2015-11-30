using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ModificarAeronave : Form
    {
        public int variable;
        public ModificarAeronave(int discriminador)
        {
            InitializeComponent();
            variable = discriminador;
        
            iniciar();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("select distinct tipo_servicio FROM DBAS.servicios");
            comboBoxServicio.DataSource = dt.DefaultView;
            comboBoxServicio.ValueMember = "tipo_servicio";

            DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct nombre_fabricante FROM DBAS.fabricantes");
            comboBoxFabricante.DataSource = dta.DefaultView;
            comboBoxFabricante.ValueMember = "nombre_fabricante"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.setAnterior(this);
            _Aeronave paquete = new _Aeronave(txtMatricula,txtModelo,textPisos,textButacasPasillo,textButacasVentanilla,textKdDisponibles,comboBoxServicio,comboBoxFabricante);
            listado.cargarModificado(paquete);
            listado.Show();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
            {
                return;
            }

            int cantidad = Int32.Parse(((new ConexionSQL()).cargarTablaSQL("select count(*) from dbas.aeronavesEnServicio() where matricula_aeronave like '" + txtMatricula.Text + "'")).Rows[0][0].ToString());
            if (cantidad != 1)
            {
                MessageBox.Show("Esta Aeronave ya fue eliminada, no puede modificarla", "Modificar Aeronave", MessageBoxButtons.OK);
                return;
            }   

            string idFabricante = ((new ConexionSQL()).cargarTablaSQL("select distinct id_fabricante FROM DBAS.fabricantes where nombre_fabricante like '" + comboBoxFabricante.Text + "'")).Rows[0][0].ToString();
            string idServicio = ((new ConexionSQL()).cargarTablaSQL("select distinct id_servicio FROM DBAS.servicios where tipo_servicio like '" + comboBoxServicio.Text + "'")).Rows[0][0].ToString();
            string query = "execute DBAS.modificarAeronave '"+txtMatricula.Text+"',"+idFabricante.ToString()+","+idServicio.ToString()+",'"+txtMatricula.Text+"','"+txtModelo.Text+"',"+textKdDisponibles.Text+","+ textButacasPasillo.Text+","+textButacasVentanilla.Text+","+textPisos.Text;

            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
            }
            catch
            {
                MessageBox.Show("La aeronave fue usada, no puede modificarla", "Modificar Aeronave", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Modificacion de aeronave exitosa", "Modificar aeronave", MessageBoxButtons.OK);
            iniciar();
            this.Hide();
            
        }

        private bool Validaciones()
        {

            if (!estaCompleto())
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }

            /*  if (txtMatricula.Text != "" && (txtMatricula.Text != datosTraidos.textBox1.Text))
              {

                 DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave FROM DBAS.aeronaves where matricula_aeronave like '" + txtMatricula.Text+"'");
                  if (dta.Rows.Count != 0)
                  {
                      MessageBox.Show("El numero de matricula ya existe", "Matricula invalida", MessageBoxButtons.OK);
                      return false;
                  }
           

              }
                */
            int a, b, c, d;
            try
            {
                a = Convert.ToInt32(textButacasPasillo.Text);

            }
            catch
            {
                MessageBox.Show("La cantidad de butacas tipo pasillo no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                b = Convert.ToInt32(textButacasVentanilla.Text);

            }
            catch
            {
                MessageBox.Show("La cantidad de butacas tipo ventanilla no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                c = Convert.ToInt32(textPisos.Text);
            }
            catch
            {
                MessageBox.Show("La cantidad de pisos ingresada no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                d = Convert.ToInt32(textKdDisponibles.Text);
            }
            catch
            {
                MessageBox.Show("Los kilogramos ingresados no poseen un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (a < 1 || b < 1)
            {
                MessageBox.Show("Cantidad de butacas invalida", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (c < 1)
            {
                MessageBox.Show("Cantidad de pisos invalida", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (d < 1)
            {
                MessageBox.Show("Cantidad de kilogramos invalidos", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool estaCompleto()
        {
            return (txtMatricula.TextLength != 0 && txtModelo.TextLength != 0 && textPisos.TextLength != 0 && textKdDisponibles.TextLength != 0 && textButacasVentanilla.TextLength != 0 && textButacasPasillo.TextLength != 0); //&& comboBoxFabricante.SelectedIndex != -1 && comboBoxServicio.SelectedIndex != -1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        public void iniciar()
        {
            txtMatricula.ReadOnly = false;
            txtMatricula.Text = "";
            txtModelo.Text = "";
            textPisos.Text = "";
            textButacasPasillo.Text = "";
            textButacasVentanilla.Text = "";
            textKdDisponibles.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!validaciones2()) return;
        //--
    
              int cantidad = Int32.Parse(((new ConexionSQL()).cargarTablaSQL("select count(*) from dbas.aeronavesEnServicio() where matricula_aeronave like '" + txtMatricula.Text + "'")).Rows[0][0].ToString());
              if (cantidad != 1)
              {
                  MessageBox.Show("Esta Aeronave ya fue eliminada", "Baja Aeronave", MessageBoxButtons.OK);
                  return;
              }   
           
    //--
            MotivoDeBaja motivo = new MotivoDeBaja(this);
            this.Hide();
            motivo.Show();
        }

        private bool validaciones2()
        {
            if (!estaCompleto())
            {
                MessageBox.Show("Faltan completar campos", "Formulario Incompleto", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatricula.Text != "")
            {

                DataTable dta = (new ConexionSQL()).cargarTablaSQL("select distinct matricula_aeronave FROM DBAS.aeronaves where matricula_aeronave like '" + txtMatricula.Text + "'");
                if (dta.Rows.Count == 0)
                {
                    MessageBox.Show("El numero de matricula no existe", "Matricula invalida", MessageBoxButtons.OK);
                    return false;
                }

            }

            int a, b, c, d;
            try
            {
                a = Convert.ToInt32(textButacasPasillo.Text);

            }
            catch
            {
                MessageBox.Show("La cantidad de butacas tipo pasillo no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                b = Convert.ToInt32(textButacasVentanilla.Text);

            }
            catch
            {
                MessageBox.Show("La cantidad de butacas tipo ventanilla no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                c = Convert.ToInt32(textPisos.Text);
            }
            catch
            {
                MessageBox.Show("La cantidad de pisos ingresada no posee un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            try
            {
                d = Convert.ToInt32(textKdDisponibles.Text);
            }
            catch
            {
                MessageBox.Show("Los kilogramos ingresados no poseen un tipo de dato valido", "Error", MessageBoxButtons.OK);
                return false;
            }

          
            if (a < 1 || b < 1)
            {
                MessageBox.Show("Cantidad de butacas invalida", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (c < 1)
            {
                MessageBox.Show("Cantidad de pisos invalida", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (d < 1)
            {
                MessageBox.Show("Cantidad de kilogramos invalidos", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public string getMatricula()
        {
            return txtMatricula.Text;
        }

        public string getPisos()
        {
            return textPisos.Text;
        }

        public string getButacasPasillo()
        {
            return textButacasPasillo.Text;
        }

        public string getButacasVentanilla()
        {
            return textButacasVentanilla.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ModificarAeronave_Load(object sender, EventArgs e)
        {
            if (variable == 0)
            {
                butAceptar.Visible = true;
                button3.Visible = false;

            }
            else
            {
                butAceptar.Visible = false;
                button3.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.iniciar();
            this.Hide();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
