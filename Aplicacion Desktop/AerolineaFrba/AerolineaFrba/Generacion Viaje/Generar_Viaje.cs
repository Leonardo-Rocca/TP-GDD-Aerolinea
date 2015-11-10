using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.FormsPrincipales;
using System.Data.SqlClient;



namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Generar_Viaje : Form
    {
        public int discriminador;
        public Generar_Viaje()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            textBoxMatricula.Text = "";
            textCodRuta.Text = "";
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }


        private void seleccionarDesde_Click(object sender, EventArgs e)
        {
           
        }

        private void seleccionarHasta_Click(object sender, EventArgs e)
        {
            
        }

        private void seleccionarMatricula_Click(object sender, EventArgs e)
        {
            ListadoAeronave listado = new ListadoAeronave();
            listado.setAnterior(this);
            _Viaje paquete = new _Viaje(textBoxMatricula);
            listado.setViaje(paquete);
            listado.Show();
        }

        private void Generar_Viaje_Load(object sender, EventArgs e)
        {

        }

        private void seleccionarCodigo_Click(object sender, EventArgs e)
        {
            Abm_Ruta.ModificarEliminarRuta form = new Abm_Ruta.ModificarEliminarRuta(3);
            form.setFormAuxiliar(this);
            form.Show();

        }

        public void cargarRuta(Dominio.Ruta r)
        {
            textCodRuta.Text=r.idRuta.ToString();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(!validaciones())
            {
                return;
            }

            string query = "execute dbas.altaViaje '" + textBoxMatricula.Text + "', '" + DateTime.Parse(dateFechaDesde.Text).ToString() + "', '" + DateTime.Parse(dateFechaHasta.Text).ToString() + "', '" + textCodRuta.Text+"'";

            try
            {
                (new ConexionSQL()).cargarTablaSQL(query);
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Message.StartsWith("La fecha de salida ingresada no esta disponible"))
                {
                    MessageBox.Show("La fecha de salida ingresada no esta disponible. Intentelo en otro momento", "Generar Viaje", MessageBoxButtons.OK);
                    return;
                }
              
                if (sqlEx.Message.StartsWith("La ruta seleccionada no comienza en la ciudad de la aeronave"))
                {
                    MessageBox.Show("La ruta seleccionada no comienza en la ciudad de la aeronave", "Generar Viaje", MessageBoxButtons.OK);
                    return;
                }
                   
                 if (sqlEx.Message.StartsWith("El servicio de la aeronave no es posible para esta ruta"))
                {
                    MessageBox.Show("El servicio de la aeronave no es posible para esta ruta", "Generar Viaje", MessageBoxButtons.OK);
                    return;
                }

               throw new Exception();
            }

            MessageBox.Show("Viaje generado", "Generar Viaje", MessageBoxButtons.OK);
            iniciar();
            this.Hide();
        
        }

        private bool validaciones()
        {
            if (textBoxMatricula.Text == "" || textCodRuta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Generar Viaje", MessageBoxButtons.OK);
                return false;
            }

           int ant1= DateTime.Compare(DateTime.Parse(dateFechaDesde.Text), DateTime.Parse(Program.nuevaFechaSistema()));
           if (ant1 < 0)
            {
                MessageBox.Show("La fecha de salida debe ser posterior al dia de hoy", "Generar Viaje", MessageBoxButtons.OK);
                return false;
            }

            int ant2 = DateTime.Compare(DateTime.Parse(dateFechaDesde.Text), DateTime.Parse(dateFechaHasta.Text));
            if (ant2 > 0)
            {
                MessageBox.Show("La fechas ingresadas no son validas", "Generar Viaje", MessageBoxButtons.OK);
                return false;
            }

            TimeSpan ts = DateTime.Parse(dateFechaHasta.Text) - DateTime.Parse(dateFechaDesde.Text);
            int horas = Int32.Parse(ts.TotalHours.ToString());
            if (horas > 24)
            {
                MessageBox.Show("La fecha de llegada estimada no puede ser superior a 24 horas", "Generar Viaje", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void dateFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}
