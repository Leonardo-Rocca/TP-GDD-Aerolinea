using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AerolineaFrba
{
    class ConexionSQL
    {

        private SqlConnection miConexionSQL;
        private String miConnectionStringSQL;

        #region "Propiedades"

        public SqlConnection getMiConexionSQL()
        {
            return miConexionSQL;
        }

        public String getMiConnectionString()
        {
            return miConnectionStringSQL;
        }

        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor, toma el connectionString de la aplicacion
        /// </summary>
        /// <remarks></remarks>
        public ConexionSQL()
        {
            miConexionSQL = new SqlConnection();
            
            /*se usa para las conexiones tcp/ip*/
            //string gd20 = "Data source="+Program.ip()+","+Program.puerto()+"; Network Library=DBMSSOCN; Initial Catalog=GD2C2015;User Id=gd; Password=gd2015";
            
            /*se usa para las conexiones locales*/
            string gd20 = "Data source=.\\SQLSERVER2012; Initial Catalog=GD2C2015;User Id=gd; Password=gd2015";
    
            miConnectionStringSQL = gd20;
            miConexionSQL.ConnectionString = miConnectionStringSQL;
        }

        public ConexionSQL(String _connectionString)
        {
            miConexionSQL = new SqlConnection();
            miConnectionStringSQL = _connectionString;
            miConexionSQL.ConnectionString = miConnectionStringSQL;
        }

        #endregion

        #region "Metodos"

        public SqlConnection conectar()
        {

            // INTENTO CONECTARME
            try
            {
                miConexionSQL.Open();

                // SI NO PUEDO, RETORNO FALSE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return miConexionSQL;

        }

        public Boolean desconectar()
        {

            Boolean conexionOK = true;

            // INTENTO DESCONECTARME
            try
            {
                miConexionSQL.Close();

                // SI NO PUEDO, RETORNO FALSE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexionOK = false;
            }

            return conexionOK;
        }

        public DataTable cargarTabla(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;

            // REM CREO UN DATAREADER
            SqlDataAdapter dataAdapter = new SqlDataAdapter(miCommand);
            // REM CARGO EL DATATABLE PRODUCTOS A TRAVEZ DEL DATAREADER
            dataAdapter.Fill(ds);
            this.desconectar();
            return ds;
        }



        public DataTable cargarCombo(SqlCommand cmd)
        {
            this.conectar();
            DataTable dt = new DataTable();
            cmd.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            this.desconectar();
            return dt;

        }
        public void ejecutarProcedur(ref SqlCommand miCommand)
        {
            DataTable dataTable = new DataTable();

            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.StoredProcedure;

            // REM CREO UN DATAREADER
            miCommand.ExecuteNonQuery();
            this.desconectar();
        }

        public void ejecutarComando(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;

            miCommand.ExecuteNonQuery();
            this.desconectar();
        }

        public void ejecutarComandoSQL(string miCommand){
            SqlCommand coman2 = new SqlCommand(string.Format(miCommand), miConexionSQL);
            this.ejecutarComando(coman2);
        }

        public DataTable cargarTablaSQL(string miCommand)
        {  SqlCommand coman2 = new SqlCommand(string.Format(miCommand), miConexionSQL);

            DataTable ds = this.cargarTabla(coman2);
           return ds;
        }

        public void ejecutarComandoSQLConParametro(string query, string parametro)
        {
            SqlCommand coman2 = new SqlCommand(string.Format(query), miConexionSQL);
            coman2.Parameters.AddWithValue("@Parametro", Convert.ToDouble(parametro));
            this.ejecutarComando(coman2);
        }

        #endregion

    }


}