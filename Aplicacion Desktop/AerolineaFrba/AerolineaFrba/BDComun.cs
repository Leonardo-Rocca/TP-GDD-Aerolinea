using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AerolineaFrba
{
    public class BDComun

    {
        public static SqlConnection obtenerConexion(){

        //    SqlConnection conect = new SqlConnection("Data source=ABM-PC//SQLSERVER2012; Initial Catalog=GD2C2015;User Id=gd; Password=gd2015");
            SqlConnection conect = new SqlConnection("Data source=.\\SQLSERVER2012; Initial Catalog=GD2C2015;User Id=gd; Password=gd2015");
            conect.Open();
            return conect;
        }

        public static int select(){
            
            int retorno=0;
            using (SqlConnection  conn = BDComun.obtenerConexion())
                {
                SqlCommand comando = new SqlCommand(string.Format("select * FROM gd_esquema.Maestra"),conn);
                
                retorno = comando.ExecuteNonQuery();
                }
            return retorno;
         }
    }
}
