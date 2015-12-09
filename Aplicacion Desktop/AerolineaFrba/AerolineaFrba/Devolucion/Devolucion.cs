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


namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {

        public List<String> pasajes = new List<String>();
        public Devolucion()
        {
            InitializeComponent();
            iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.iniciar();
            this.Hide();
        }

        private void iniciar()
        {
            textBox0.Text = "";
            comboBox1.Text = "";
            foreach (String elemento in pasajes)
            {
                comboBox1.Items.Remove(elemento);
            }
            pasajes.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = Program.nuevaFechaSistema().Substring(0,10);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            pasajes.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            pasajes.Remove(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
            if (pasajes.Count == 0)
            {
                comboBox1.Text = "";
            }
            else
            {
                comboBox1.Text = (pasajes.ElementAt(0)).ToString();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }
            cancelar();
        }

        private bool validaciones()
        {
            if (textBox0.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (pasajes.Count == 0 && textBox4.Text == ""))
            {
                MessageBox.Show("Debe completar todos los campos", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                return false;
            }

            if (textBox0.TextLength > 9)
            {
                MessageBox.Show("El DNI no esta en un rango valido (0 - 999999999)", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (textBox3.TextLength > 100)
            {
                MessageBox.Show("El motivo de cancelacion no debe superar los 100 caracteres", "Error", MessageBoxButtons.OK);
                return false;
            }

            Int32 a;

            try
            {
                a = Convert.ToInt32(textBox0.Text);

            }
            catch
            {
                MessageBox.Show("El DNI no posee un tipo de datos valido", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (a < 0)
            {
                MessageBox.Show("El DNI debe ser positivo", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void cancelar()
        {
            DataTable cancelacion = new DataTable("cancelacion");
            cancelacion.Columns.Add("Id", typeof(int));
            string pnr = textBox2.Text;
            DataTable dt =  ((new ConexionSQL()).cargarTablaSQL("select distinct id_persona from dbas.personas where dni_persona = '" + textBox0.Text+"'"));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El dni no esta en la base", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                return;
            }     
            string idCli = dt.Rows[0][0].ToString();
            string motivo = textBox3.Text;
            string encomienda;
            string comando;
            string resto = "";
            if (textBox4.Text == "")
            {
                encomienda = "-1";
            }
            else
            {
                 encomienda = textBox4.Text;
            }

            if (comboBox1.SelectedIndex != -1)
            {
                comando = "insert into DBAS.PasajesCancelados values (" + pnr + "," + idCli + ",'" + motivo + "',";
                resto= ","+encomienda+ ")";
            }
            else
            {
                comando = "insert into DBAS.PasajesCancelados values (" + pnr + "," + idCli + ",'" + motivo + "',-1," + encomienda + ")";
            }

            DataTable dtas = (new ConexionSQL()).cargarTablaSQL("SELECT * FROM DBAS.compras c,dbas.clientes cli WHERE c.id_cliente = cli.id_cliente AND id_compra_PNR = '" + pnr + "' and id_persona = '" + idCli + "'");
                if (dtas.Rows.Count == 0)
                {
                    MessageBox.Show("El PNR ingresado es invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                    return;
                }

            int i = 1;
            int cant = pasajes.Count;
            
            foreach (String elemento in pasajes)
            {

                //MessageBox.Show(elemento);

                DataTable dta = (new ConexionSQL()).cargarTablaSQL("select codigo_pasaje FROM DBAS.pasajes where id_compra_PNR = "+pnr+" and codigo_pasaje = '" + elemento + "'");
                if (dta.Rows.Count == 0)
                {
                    MessageBox.Show("Hay un codigo de pasaje invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                    return;
                }


              /*  if (i < cant)
                {
                    comando = comando + " '" + elemento + "',";
                }
                else
                {
                    comando = comando + " '" + elemento + "')";
                }
                i++;
                */
            }

           // MessageBox.Show(comando);
            if (cant == 0)
            {
                try
                {
                    (new ConexionSQL()).ejecutarComandoSQL(comando);
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Message.StartsWith("Hay un codigo de pasaje invalido"))
                    {
                        MessageBox.Show("Hay un codigo de pasaje invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }

                    if (sqlEx.Message.StartsWith("Hay un codigo de encomienda invalido"))
                    {
                        MessageBox.Show("Hay un codigo de encomienda invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }
                    if (sqlEx.Message.StartsWith("El PNR ingresado es incorrecto"))
                    {
                        MessageBox.Show("El PNR ingresado es incorrecto", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }

                    if (sqlEx.Message.StartsWith("Hay un pasaje que ya fue cancelado"))
                    {
                     //   MessageBox.Show('2' + ' ' + comando);
                        MessageBox.Show("Hay un pasaje que ya fue cancelado", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }

                    if (sqlEx.Message.StartsWith("Hay una encomienda que ya fue cancelada"))
                    {
                        MessageBox.Show("Hay una encomienda que ya fue cancelada", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }

                    if (sqlEx.Message.StartsWith("El viaje ya fue realizado, no puede cancelar el pasaje"))
                    {
                        MessageBox.Show("El viaje ya fue realizado, no puede cancelar el pasaje", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }

                    if (sqlEx.Message.StartsWith("El viaje ya fue realizado, no puede cancelar la encomienda"))
                    {
                        MessageBox.Show("El viaje ya fue realizado, no puede cancelar la encomienda", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                        return;
                    }


                }
            }else{

                foreach (String elemento in pasajes)
                {
                    string comandoNuevo = comando + elemento + resto;
                    //MessageBox.Show(comandoNuevo);
                    try
                    {
                        (new ConexionSQL()).ejecutarComandoSQL(comandoNuevo);
                    }
                    catch (SqlException sqlEx)
                    {
                        if (sqlEx.Message.StartsWith("Hay un codigo de pasaje invalido"))
                        {
                            MessageBox.Show("Hay un codigo de pasaje invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                        if (sqlEx.Message.StartsWith("Hay un codigo de encomienda invalido"))
                        {
                            MessageBox.Show("Hay un codigo de encomienda invalido", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }
                        if (sqlEx.Message.StartsWith("El PNR ingresado es incorrecto"))
                        {
                            MessageBox.Show("El PNR ingresado es incorrecto", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                        if (sqlEx.Message.StartsWith("Hay un pasaje que ya fue cancelado"))
                        {
                   //         MessageBox.Show('1' +' '+ comandoNuevo);

                            MessageBox.Show("Hay un pasaje que ya fue cancelado", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                        if (sqlEx.Message.StartsWith("Hay una encomienda que ya fue cancelada"))
                        {
                            MessageBox.Show("Hay una encomienda que ya fue cancelada", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                        if (sqlEx.Message.StartsWith("El viaje ya fue realizado, no puede cancelar el pasaje"))
                        {
                            MessageBox.Show("El viaje ya fue realizado, no puede cancelar el pasaje", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                        if (sqlEx.Message.StartsWith("El viaje ya fue realizado, no puede cancelar la encomienda"))
                        {
                            MessageBox.Show("El viaje ya fue realizado, no puede cancelar la encomienda", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
                            return;
                        }

                    }
                }
              //  MessageBox.Show(sqlEx.Message);
            }

            MessageBox.Show("Cancelacion exitosa", "Cancelacion de pasajes y/o encomiendas", MessageBoxButtons.OK);
            this.iniciar();
            this.Hide();

           }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
